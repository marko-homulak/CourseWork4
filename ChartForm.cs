using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BeeBearGUI
{
    public partial class ChartForm : Form
    {
        public ChartForm(Chart sourceChart)
        {
            InitializeComponent();

            Chart newChart = new Chart
            {
                Dock = DockStyle.Fill
            };

            foreach (var area in sourceChart.ChartAreas)
                newChart.ChartAreas.Add(CloneChartArea(area));

            foreach (var series in sourceChart.Series)
                newChart.Series.Add(CloneSeries(series));

            Controls.Add(newChart);
        }

        private ChartArea CloneChartArea(ChartArea source)
        {
            var area = new ChartArea(source.Name);
            area.AxisX.Title = source.AxisX.Title;
            area.AxisY.Title = source.AxisY.Title;
            return area;
        }

        private Series CloneSeries(Series source)
        {
            var series = new Series(source.Name)
            {
                ChartType = source.ChartType,
                Color = source.Color,
                BorderWidth = source.BorderWidth,
                MarkerStyle = source.MarkerStyle
            };

            foreach (var point in source.Points)
            {
                series.Points.AddXY(point.XValue, point.YValues[0]);
            }

            return series;
        }

    }
}
