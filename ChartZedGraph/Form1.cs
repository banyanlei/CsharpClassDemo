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

namespace ChartZedGraph
{
    public partial class Form1 : Form
    {
        private ZedGraphControl zgc;
        public Form1()
        {
            InitializeComponent();
            zgc = new ZedGraphControl
            {
                Dock = DockStyle.Fill // 填充整个窗体
            };

            // 将 ZedGraphControl 添加到窗体的控件集合中
            this.Controls.Add(zgc);

            // 设置折线图
            CreateGraph(zgc);
        }
        private void CreateGraph(ZedGraphControl zgc)
        {
            // 获取图表的 GraphPane 对象
            GraphPane myPane = zgc.GraphPane;

            // 设置标题和标签
            myPane.Title.Text = "折线图示例";
            myPane.XAxis.Title.Text = "X 轴";
            myPane.YAxis.Title.Text = "Y 轴";

            // 创建数据点列表
            PointPairList list = new PointPairList();
            list.Add(1, 10);
            list.Add(2, 20);
            list.Add(3, 15);

            // 创建曲线对象，并添加到 GraphPane 中
            LineItem myCurve = myPane.AddCurve("数据曲线", list, Color.Blue, SymbolType.Circle);

            // 调整轴的范围
            zgc.AxisChange();
            zgc.Invalidate();  // 刷新 ZedGraph 控件以显示更改
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
