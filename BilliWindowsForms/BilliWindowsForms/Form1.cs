using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> strNames = new List<string>();
        List<string> musicfiles = new List<string>();


        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐";
            ofd.InitialDirectory = @"C:\CAYA\cy\c# test\BilliWindowsForms\BilliWindowsForms\music";
            ofd.Filter = "音乐文件(*.wav)|*.wav|全部文件(*.*)|*.*";
            ofd.Multiselect = true;
            ofd.ShowDialog();
            strNames.AddRange(ofd.SafeFileNames);
            musicfiles.AddRange(ofd.FileNames);
            //将文件名添加到 listbox 中
            for (int i = 0; i < strNames.Count; i++)
            {
                listBox1.Items.Add(strNames[i]);
            }
            buttonLast.Visible = true;
            buttonNext.Visible = true;
        }

            SoundPlayer sp = new SoundPlayer();
        public void SoundPlay(int index)
        {
            sp.SoundLocation = musicfiles[index];
            sp.Play();
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoundPlay(listBox1.SelectedIndex);
        }
        int NowSelected = 0;
        private void ButonLast_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                NowSelected = listBox1.SelectedIndex;
            }
            else
            {
                NowSelected = 1;
            }
            NowSelected--;
            if (NowSelected < 0)
            {
                NowSelected = musicfiles.Count - 1;
            }
            listBox1.SelectedIndex = NowSelected;
            SoundPlay(NowSelected);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                NowSelected = listBox1.SelectedIndex;
            }
            else
            {
                NowSelected = musicfiles.Count-1;
            }
            NowSelected++;
            if (NowSelected == musicfiles.Count)
            {
                NowSelected = 0;
            }
            listBox1.SelectedIndex = NowSelected;
            SoundPlay(NowSelected);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Test.form = this;
            buttonLast.Visible = false;
            buttonNext.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
