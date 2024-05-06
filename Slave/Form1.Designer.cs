namespace Slave
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Creat = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.IpAddressTextBox = new System.Windows.Forms.TextBox();
            this.IpAddress = new System.Windows.Forms.Label();
            this.PortNum = new System.Windows.Forms.Label();
            this.PortNumTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Creat
            // 
            this.Creat.Location = new System.Drawing.Point(518, 57);
            this.Creat.Name = "Creat";
            this.Creat.Size = new System.Drawing.Size(75, 23);
            this.Creat.TabIndex = 0;
            this.Creat.Text = "Creat";
            this.Creat.UseVisualStyleBackColor = true;
            this.Creat.Click += new System.EventHandler(this.Creat_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(53, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(670, 319);
            this.listBox1.TabIndex = 1;
            // 
            // IpAddressTextBox
            // 
            this.IpAddressTextBox.Location = new System.Drawing.Point(110, 55);
            this.IpAddressTextBox.Name = "IpAddressTextBox";
            this.IpAddressTextBox.Size = new System.Drawing.Size(156, 25);
            this.IpAddressTextBox.TabIndex = 2;
            this.IpAddressTextBox.Text = "127.0.0.1";
            // 
            // IpAddress
            // 
            this.IpAddress.AutoSize = true;
            this.IpAddress.Location = new System.Drawing.Point(40, 58);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.Size = new System.Drawing.Size(68, 15);
            this.IpAddress.TabIndex = 3;
            this.IpAddress.Text = "Ip地址：";
            // 
            // PortNum
            // 
            this.PortNum.AutoSize = true;
            this.PortNum.Location = new System.Drawing.Point(297, 58);
            this.PortNum.Name = "PortNum";
            this.PortNum.Size = new System.Drawing.Size(52, 15);
            this.PortNum.TabIndex = 5;
            this.PortNum.Text = "端口：";
            // 
            // PortNumTextBox
            // 
            this.PortNumTextBox.Location = new System.Drawing.Point(355, 55);
            this.PortNumTextBox.Name = "PortNumTextBox";
            this.PortNumTextBox.Size = new System.Drawing.Size(100, 25);
            this.PortNumTextBox.TabIndex = 4;
            this.PortNumTextBox.Text = "502";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PortNum);
            this.Controls.Add(this.PortNumTextBox);
            this.Controls.Add(this.IpAddress);
            this.Controls.Add(this.IpAddressTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Creat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Creat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox IpAddressTextBox;
        private System.Windows.Forms.Label IpAddress;
        private System.Windows.Forms.Label PortNum;
        private System.Windows.Forms.TextBox PortNumTextBox;
        private System.Windows.Forms.Button button1;
    }
}

