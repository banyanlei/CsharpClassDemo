using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace ChartLiveCharts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZedGraphControl zgc = new ZedGraphControl();
            GraphPane myPane = zgc.GraphPane;
            PointPairList list = new PointPairList();
            list.Add(1, 10);
            list.Add(2, 20);
            list.Add(3, 15);
            LineItem myCurve = myPane.AddCurve("Line", list, Color.Blue, SymbolType.None);
            zgc.AxisChange();
        }
    }
}
