namespace _Thread_Task_async_await
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(149, 134);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(171, 44);
            button1.TabIndex = 0;
            button1.Text = "单线程做菜";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(149, 222);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(171, 44);
            button2.TabIndex = 1;
            button2.Text = "Thread做菜";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(149, 306);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(171, 44);
            button3.TabIndex = 2;
            button3.Text = "Task做菜";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(469, 134);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(171, 44);
            button4.TabIndex = 3;
            button4.Text = "同时做多道菜";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(469, 222);
            button5.Margin = new Padding(4, 4, 4, 4);
            button5.Name = "button5";
            button5.Size = new Size(171, 44);
            button5.TabIndex = 4;
            button5.Text = "等待菜都做好了";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(469, 306);
            button6.Margin = new Padding(4, 4, 4, 4);
            button6.Name = "button6";
            button6.Size = new Size(171, 44);
            button6.TabIndex = 5;
            button6.Text = "并行等待菜都做好了";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(776, 134);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(171, 44);
            button7.TabIndex = 6;
            button7.Text = "死锁测试";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 662);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}