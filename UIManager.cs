using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace BeeBearGUI
{
    public class UIManager
    {
        private readonly Chart _chart;
        private readonly ListBox _logList;

        public UIManager(Chart chart, ListBox logList)
        {
            _chart = chart;
            _logList = logList;
        }

        public void Log(string message, bool enableLogging)
        {
            if (!enableLogging) return;

            FormHelpers.SafeInvoke(_logList, () =>
            {
                _logList.Items.Add(message);
                _logList.TopIndex = _logList.Items.Count - 1;
            });
        }

        public void ClearChart()
        {
            FormHelpers.SafeInvoke(_chart, () =>
            {
                _chart.Series.Clear();
                _chart.ChartAreas[0].AxisX.Title = string.Empty;
                _chart.ChartAreas[0].AxisY.Title = string.Empty;
            });
        }

        public void SetChartAxis(string x, string y)
        {
            FormHelpers.SafeInvoke(_chart, () =>
            {
                _chart.ChartAreas[0].AxisX.Title = x;
                _chart.ChartAreas[0].AxisY.Title = y;
            });
        }

    }
}
