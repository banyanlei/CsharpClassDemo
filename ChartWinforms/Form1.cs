using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace ChartWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;
            this.Controls.Add(chart);

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.Points.AddXY(1, 10);
            series.Points.AddXY(2, 20);
            series.Points.AddXY(3, 15);
            chart.Series.Add(series);


        }
    }
}
