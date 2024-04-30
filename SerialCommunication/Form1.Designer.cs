namespace SerialCommunication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Connect = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.ComInput = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(75, 72);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(95, 40);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(75, 215);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(95, 40);
            this.Send.TabIndex = 1;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // ComInput
            // 
            this.ComInput.Location = new System.Drawing.Point(75, 28);
            this.ComInput.Name = "ComInput";
            this.ComInput.Size = new System.Drawing.Size(100, 28);
            this.ComInput.TabIndex = 2;
            this.ComInput.Text = "COM3";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(75, 160);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(487, 28);
            this.txtSend.TabIndex = 3;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(205, 72);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(95, 40);
            this.Close.TabIndex = 4;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(642, 28);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(496, 424);
            this.txtReceived.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 545);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.ComInput);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox ComInput;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox txtReceived;
    }
}

