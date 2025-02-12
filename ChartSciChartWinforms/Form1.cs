using System;
using System.Drawing;
using System.Windows.Forms;
using SciChart.Charting.Visuals;
using SciChart.Charting.Visuals.Axes;
using SciChart.Charting.Visuals.RenderableSeries;
using SciChart.Charting.Model.DataSeries;

namespace ChartSciChartWinforms
{
    public partial class Form1 : Form
    {
        private SciChartSurface sciChartSurface;

        public Form1()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new Size(800, 450);
            this.Name = "Form1";
            this.ResumeLayout(false);

            // 创建 SciChartSurface
            sciChartSurface = new SciChartSurface
            {
                Dock = DockStyle.Fill // 填充整个窗体
            };
            this.Controls.Add(sciChartSurface);
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
                Stroke = Color.Blue,
                StrokeThickness = 2
            };

            // 将折线图序列添加到 SciChartSurface 中
            sciChartSurface.RenderableSeries.Add(lineSeries);

            // 调整图表视图范围
            sciChartSurface.ZoomExtents();
        }
    }
}
