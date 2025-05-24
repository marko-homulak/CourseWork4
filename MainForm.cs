using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BeeBearGUI
{
    public partial class Form1 : Form
    {
        private SimulationController _simulation;
        private FileLogger _logger;
        private UIManager _ui;

        private int _potCapacity;
        private int _currentHoney = 0;

        public Form1()
        {
            InitializeComponent();
            InitUI();
            LoadSimulationList();

            _ui = new UIManager(chartResult, listBoxLogs);

            btnStop.Enabled = false;
        }

        private void InitUI()
        {
            comboBoxSimulations.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChartType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterSet.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxChartType.Items.AddRange(new string[] { "Deliveries", "AvgTime", "Boxplot", "FillTime" });
        }

        private void StartSimulation()
        {
            if (!TryGetSimulationParameters(out int bees, out int capacity, out int minTime, out int maxTime, out int bearEatTime))
                return;

            _potCapacity = capacity;
            _currentHoney = 0;

            _logger = new FileLogger("honeypot_log.txt");
            _simulation = new SimulationController();

            _simulation.OnLog += msg =>
            {
                _logger.Log(msg);
            };

            _simulation.OnQueueUpdate += (queueSize) =>
            {
                FormHelpers.SafeInvoke(this, () =>
                {
                    labelQueueStatus.Text = $"{queueSize} 🐝";
                });
            };

            _simulation.OnLog += LogMessage;
            _simulation.OnHoneyAdded += IncrementHoney;
            _simulation.OnPotEmptied += ResetHoney;

            _simulation.StartSimulation(bees, capacity, minTime, maxTime, bearEatTime, checkBoxSoundEffects.Checked);

            SetUIControls(true);
        }

        private void StopSimulation()
        {
            _simulation?.StopSimulation();

            SetUIControls(false);
            LoadSimulationList();
        }

        private bool TryGetSimulationParameters(out int bees, out int capacity, out int minTime, out int maxTime, out int bearEatTime)
        {
            bees = capacity = minTime = maxTime = bearEatTime = 0;

            if (!int.TryParse(numUpDownBeeCount.Text, out bees) ||
                !int.TryParse(numUpDownPotCapacity.Text, out capacity) ||
                !int.TryParse(numUpDownMinTime.Text, out minTime) ||
                !int.TryParse(numUpDownMaxTime.Text, out maxTime) ||
                !int.TryParse(numUpDownBearEatTime.Text, out bearEatTime))
            {
                FormHelpers.ShowWarningMsg("Please enter valid numeric values.");
                return false;
            }

            int advisableMinCountBee = 1;
            int advisableMaxCountBee = 500;
            int advisableMinTime = 50;
            int advisableBearEatTime = 2000;

            if (bees < advisableMinCountBee)
            {
                FormHelpers.ShowWarningMsg($"The number of bees must be at least {advisableMinCountBee}.");
                return false;
            }

            if (bees > advisableMaxCountBee)
            {
                FormHelpers.ShowWarningMsg($"The number of bees exceeds the recommended maximum ({advisableMaxCountBee}).");
                return false;
            }

            if (capacity < bees)
            {
                FormHelpers.ShowWarningMsg("The size of the pot should be no smaller than the number of bees.");
                return false;
            }

            if (minTime < 0 || maxTime < 0)
            {
                FormHelpers.ShowWarningMsg("Time values ​​cannot be negative.");
                return false;
            }

            if (minTime < advisableMinTime)
            {
                FormHelpers.ShowWarningMsg($"The minimum time is less than the recommended minimum ({advisableMinTime}).");
                return false;
            }

            if (maxTime < minTime)
            {
                FormHelpers.ShowWarningMsg("The maximum time cannot be less than the minimum.");
                return false;
            }

            if (bearEatTime < advisableBearEatTime)
            {
                FormHelpers.ShowWarningMsg($"The time a bear eats honey should be at least {advisableBearEatTime}.");
                return false;
            }

            return true;
        }

        private void LogMessage(string message)
        {
            _ui.Log(message, checkBoxLogging.Checked);
        }

        private void IncrementHoney()
        {
            FormHelpers.SafeInvoke(progressBarPotCapacity, () =>
            {
                _currentHoney = Math.Min(_currentHoney + 1, _potCapacity);
                progressBarPotCapacity.Value = _currentHoney;
            });
        }

        private void ResetHoney()
        {
            FormHelpers.SafeInvoke(progressBarPotCapacity, () =>
            {
                _currentHoney = 0;
                progressBarPotCapacity.Value = 0;
            });
        }

        private void SetUIControls(bool isRunning)
        {
            btnStart.Enabled = !isRunning;
            btnStop.Enabled = isRunning;
            checkBoxLogging.Enabled = !isRunning;
            checkBoxSoundEffects.Enabled = !isRunning;

            numUpDownBeeCount.Enabled = !isRunning;
            numUpDownPotCapacity.Enabled = !isRunning;
            numUpDownMinTime.Enabled = !isRunning;
            numUpDownMaxTime.Enabled = !isRunning;
            numUpDownBearEatTime.Enabled = !isRunning;

            panelStatsManagement.Enabled = !isRunning;

            if (isRunning)
            {
                progressBarPotCapacity.Maximum = _potCapacity;
                progressBarPotCapacity.Value = 0;
                listBoxLogs.Items.Clear();
            }
            else
            {
                progressBarPotCapacity.Value = 0;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartSimulation();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopSimulation();
        }

        private void btnShowStats_Click(object sender, EventArgs e)
        {
            if (_simulation == null || !_simulation.IsStopped())
            {
                FormHelpers.ShowWarningMsg("First, start and stop the simulation.");
                return;
            }

            _simulation.GetStatistics.PrintSummary(msg =>
            {
                listBoxLogs.Items.Add(msg);
            });

            listBoxLogs.TopIndex = listBoxLogs.Items.Count - 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxLogs.Items.Clear();
        }

        private void LoadSimulationList()
        {
            comboBoxSimulations.Items.Clear();
            var files = SimulationResultManager.GetResultFilenames();
            foreach (var file in files)
            {
                comboBoxSimulations.Items.Add(file);
            }

            if (files.Count > 0)
                comboBoxSimulations.SelectedIndex = 0;

            var results = SimulationResultManager.LoadAll();
            LoadFilterSets(results);
        }

        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            if (comboBoxSimulations.SelectedItem == null || comboBoxChartType.SelectedItem == null)
            {
                FormHelpers.ShowWarningMsg("Select the chart type and simulation.");
                return;
            }

            var path = comboBoxSimulations.SelectedItem.ToString();
            var result = SimulationResultManager.Load(path);
            var chartType = comboBoxChartType.SelectedItem.ToString();

            BuildChart(chartType, result);
        }

        private void BuildChart(string chartType, SimulationResult result)
        {
            _ui.ClearChart();

            switch (chartType)
            {
                case "Deliveries":
                    CreateBeeChart("Deliveries", result.Bees, b => b.Deliveries);
                    _ui.SetChartAxis("Bee ID", "Deliveries");
                    break;

                case "AvgTime":
                    CreateBeeChart("AvgTime", result.Bees, b => b.AvgTime);
                    _ui.SetChartAxis("Bee ID", "Avg Collection Time (ms)");
                    break;

                case "FillTime":
                    var fillSeries = new Series("FillTime") { ChartType = SeriesChartType.Column };
                    for (int i = 0; i < result.PotFillTimes.Count; i++)
                        fillSeries.Points.AddXY($"Cycle {i + 1}", result.PotFillTimes[i].TotalMilliseconds);
                    chartResult.Series.Add(fillSeries);
                    _ui.SetChartAxis(string.Empty, "Fill Time (ms)");
                    break;

                case "Boxplot":
                    var minSeries = new Series("Min") { ChartType = SeriesChartType.Column, Color = Color.Green };
                    var avgSeries = new Series("Avg") { ChartType = SeriesChartType.Column, Color = Color.Orange };
                    var maxSeries = new Series("Max") { ChartType = SeriesChartType.Column, Color = Color.Red };

                    foreach (var bee in result.Bees.OrderBy(b => b.BeeId))
                    {
                        minSeries.Points.AddXY(bee.BeeId, bee.MinTime);
                        avgSeries.Points.AddXY(bee.BeeId, bee.AvgTime);
                        maxSeries.Points.AddXY(bee.BeeId, bee.MaxTime);
                    }

                    chartResult.Series.Add(minSeries);
                    chartResult.Series.Add(avgSeries);
                    chartResult.Series.Add(maxSeries);

                    _ui.SetChartAxis(string.Empty, string.Empty);
                    break;
            }

            chartResult.ChartAreas[0].RecalculateAxesScale();
        }

        private void CreateBeeChart(string name, List<BeeStats> bees, Func<BeeStats, double> selector)
        {
            var series = new Series(name) { ChartType = SeriesChartType.Column };
            foreach (var bee in bees.OrderBy(b => b.BeeId))
                series.Points.AddXY(bee.BeeId, selector(bee));
            chartResult.Series.Add(series);
        }

        private void btnLoadStats_Click(object sender, EventArgs e)
        {
            if (comboBoxSimulations.SelectedItem == null)
            {
                FormHelpers.ShowWarningMsg("Select a simulation.");
                return;
            }

            var path = comboBoxSimulations.SelectedItem.ToString();
            var result = SimulationResultManager.Load(path);

            listBoxLogs.Items.Clear();

            SimulationSummaryFormatter.FormatFromResult(result, msg => listBoxLogs.Items.Add(msg));

            listBoxLogs.TopIndex = listBoxLogs.Items.Count - 1;
        }

        private void LoadFilterSets(List<SimulationResult> all)
        {
            var filterSets = all
                .Select(r => new SimulationFilterSet
                {
                    PotCapacity = r.PotCapacity,
                    MinTime = r.MinCollectTime,
                    MaxTime = r.MaxCollectTime
                })
                .GroupBy(f => $"{f.PotCapacity}-{f.MinTime}-{f.MaxTime}")
                .Select(g => g.First())
                .ToList();

            comboBoxFilterSet.Items.Clear();
            foreach (var filter in filterSets)
                comboBoxFilterSet.Items.Add(filter);

            if (comboBoxFilterSet.Items.Count > 0)
                comboBoxFilterSet.SelectedIndex = 0;
        }

        private void btnCompareBeeVsTime_Click(object sender, EventArgs e)
        {
            var selectedFilter = comboBoxFilterSet.SelectedItem as SimulationFilterSet;
            if (selectedFilter == null)
            {
                FormHelpers.ShowWarningMsg("Select a set of parameters.");
                return;
            }

            var allResults = SimulationResultManager.LoadAll();

            var filtered = allResults.Where(r =>
                r.MinCollectTime == selectedFilter.MinTime &&
                r.MaxCollectTime == selectedFilter.MaxTime &&
                r.PotCapacity == selectedFilter.PotCapacity).ToList();

            if (filtered.Count < 2)
            {
                FormHelpers.ShowWarningMsg("There aren't enough simulations with such parameters.");
                return;
            }

            _ui.ClearChart();
            _ui.SetChartAxis("Number of bees", "Avg pot filling time (ms)");

            var series = new Series("Bees vs FillTime")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                MarkerStyle = MarkerStyle.Circle,
                Color = Color.DarkCyan
            };

            foreach (var res in filtered.OrderBy(r => r.BeeCount))
            {
                double avg = res.PotFillTimes.Count > 0
                    ? res.PotFillTimes.Average(p => p.TotalMilliseconds)
                    : 0;

                series.Points.AddXY(res.BeeCount, avg);
            }

            chartResult.Series.Add(series);
        }

        private void chartResult_DoubleClick(object sender, EventArgs e)
        {
            var form = new ChartForm(chartResult);
            form.Text = "Zoom Chart";
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void btnDeleteSim_Click(object sender, EventArgs e)
        {
            if (comboBoxSimulations.SelectedItem == null)
            {
                FormHelpers.ShowWarningMsg("Select the simulation to delete.");
                return;
            }

            string path = comboBoxSimulations.SelectedItem.ToString();

            if (FormHelpers.Confirm($"Are you sure you want to delete the simulation?\n{Path.GetFileName(path)}"))
            {
                try
                {
                    File.Delete(path);
                    FormHelpers.ShowInfoMsg("Simulation deleted.");
                    LoadSimulationList();
                    ResetUIStatsManagement();
                }
                catch (Exception ex)
                {
                    FormHelpers.ShowErrorMsg($"Error: {ex.Message}");
                }
            }
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            ResetUIStatsManagement();
        }

        private void ResetUIStatsManagement()
        {
            comboBoxFilterSet.SelectedIndex = -1;
            comboBoxSimulations.SelectedIndex = -1;
            comboBoxChartType.SelectedIndex = -1;

            _ui.ClearChart();
            listBoxLogs.Items.Clear();
        }

    }
}
