namespace _Thread_Task_async_await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //菜没做完不能动，主线程block了
            Thread.Sleep(3000);
            MessageBox.Show("素菜1做好了", "友情提示");
            Thread.Sleep(5000);
            MessageBox.Show("荤菜1做好了", "友情提示");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //lambda 表达式
            Thread t = new Thread(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜2做好了", "友情提示");
                Thread.Sleep(5000);
                MessageBox.Show("荤菜2做好了", "友情提示");
            });
            t.Start(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //底层也是Thread实现，更扩展，推荐
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜2做好了", "友情提示");
                Thread.Sleep(5000);
                MessageBox.Show("荤菜2做好了", "友情提示");
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜2做好了", "友情提示");
            });
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                MessageBox.Show("荤菜2做好了", "友情提示");
            });
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            //await就是等待，没await直接就菜好了。。。
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜2做好了", "友情提示");
            });
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                MessageBox.Show("荤菜2做好了", "友情提示");
            });
            MessageBox.Show("菜都做好了，大家来吃", "友情提示");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Task> ts = new List<Task>();
            ts.Add(Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜2做好了", "友情提示");
            }));

            ts.Add(Task.Run(() =>
            {
                Thread.Sleep(5000);
                MessageBox.Show("荤菜2做好了", "友情提示");
            }));
            Task.WhenAll(ts).ContinueWith(t =>
            {
                MessageBox.Show($"菜都做好了，大家来吃", "友情提示");

            });
        }
    }
}