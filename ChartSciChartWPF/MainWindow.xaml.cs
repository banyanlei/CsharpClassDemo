using System.Windows;
using SciChart.Charting.Visuals;
using SciChart.Charting.Visuals.Axes;
using SciChart.Charting.Visuals.RenderableSeries;
using SciChart.Charting.Model.DataSeries;

namespace ChartSciChartWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            // 创建 X 轴和 Y 轴
            var xAxis = new NumericAxis { AxisTitle = "X Axis" };
            var yAxis = new NumericAxis { AxisTitle = "Y Axis" };

            // 将 X 轴和 Y 轴 添加到 SciChartSurface 中
            sciChartSurface.XAxis = xAxis;
            sciChartSurface.YAxis = yAxis;

            // 创建数据系列
            var dataSeries = new XyDataSeries<double, double>();

            // 向数据系列中添加数据点
            dataSeries.Append(0, 10);
            dataSeries.Append(1, 30);
            dataSeries.Append(2, 20);
            dataSeries.Append(3, 40);
            dataSeries.Append(4, 35);

            // 创建折线图序列
            var lineSeries = new FastLineRenderableSeries
            {
                DataSeries = dataSeries,
                Stroke = System.Windows.Media.Colors.Blue,
                StrokeThickness = 2
            };

            // 将折线图序列添加到 SciChartSurface 中
            sciChartSurface.RenderableSeries.Add(lineSeries);

            // 调整图表视图范围
            sciChartSurface.ZoomExtents();
        }
    }
}
