namespace OneChat
{
    partial class MainForm
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions19 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions20 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions21 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_LocalPort = new System.Windows.Forms.TextBox();
            this.tB_LocalIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tB_RemotePort = new System.Windows.Forms.TextBox();
            this.tB_RemoteIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtB_RecvMsg = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtB_SendMsg = new System.Windows.Forms.RichTextBox();
            this.btn_SendMsg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lb_Statu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_LocalPort);
            this.groupBox1.Controls.Add(this.tB_LocalIp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "本机信息";
            // 
            // tB_LocalPort
            // 
            this.tB_LocalPort.Location = new System.Drawing.Point(68, 60);
            this.tB_LocalPort.Name = "tB_LocalPort";
            this.tB_LocalPort.Size = new System.Drawing.Size(56, 30);
            this.tB_LocalPort.TabIndex = 3;
            this.tB_LocalPort.Text = "10000";
            // 
            // tB_LocalIp
            // 
            this.tB_LocalIp.Location = new System.Drawing.Point(68, 26);
            this.tB_LocalIp.Name = "tB_LocalIp";
            this.tB_LocalIp.Size = new System.Drawing.Size(112, 30);
            this.tB_LocalIp.TabIndex = 1;
            this.tB_LocalIp.Text = "192.168.0.110";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tB_RemotePort);
            this.groupBox2.Controls.Add(this.tB_RemoteIp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(39, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "对方信息";
            // 
            // tB_RemotePort
            // 
            this.tB_RemotePort.Location = new System.Drawing.Point(68, 63);
            this.tB_RemotePort.Name = "tB_RemotePort";
            this.tB_RemotePort.Size = new System.Drawing.Size(54, 30);
            this.tB_RemotePort.TabIndex = 3;
            this.tB_RemotePort.Text = "20000";
            // 
            // tB_RemoteIp
            // 
            this.tB_RemoteIp.Location = new System.Drawing.Point(68, 30);
            this.tB_RemoteIp.Name = "tB_RemoteIp";
            this.tB_RemoteIp.Size = new System.Drawing.Size(116, 30);
            this.tB_RemoteIp.TabIndex = 1;
            this.tB_RemoteIp.Text = "192.168.0.110";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtB_RecvMsg);
            this.groupBox3.Location = new System.Drawing.Point(290, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 279);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RecvMessage";
            // 
            // rtB_RecvMsg
            // 
            this.rtB_RecvMsg.Location = new System.Drawing.Point(6, 24);
            this.rtB_RecvMsg.Name = "rtB_RecvMsg";
            this.rtB_RecvMsg.ReadOnly = true;
            this.rtB_RecvMsg.Size = new System.Drawing.Size(440, 249);
            this.rtB_RecvMsg.TabIndex = 0;
            this.rtB_RecvMsg.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtB_SendMsg);
            this.groupBox4.Controls.Add(this.btn_SendMsg);
            this.groupBox4.Location = new System.Drawing.Point(290, 375);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(452, 162);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SendMessage";
            // 
            // rtB_SendMsg
            // 
            this.rtB_SendMsg.Location = new System.Drawing.Point(6, 24);
            this.rtB_SendMsg.Name = "rtB_SendMsg";
            this.rtB_SendMsg.Size = new System.Drawing.Size(372, 132);
            this.rtB_SendMsg.TabIndex = 0;
            this.rtB_SendMsg.Text = "";
            // 
            // btn_SendMsg
            // 
            this.btn_SendMsg.Location = new System.Drawing.Point(384, 24);
            this.btn_SendMsg.Name = "btn_SendMsg";
            this.btn_SendMsg.Size = new System.Drawing.Size(62, 132);
            this.btn_SendMsg.TabIndex = 6;
            this.btn_SendMsg.Text = "Send";
            this.btn_SendMsg.UseVisualStyleBackColor = true;
            this.btn_SendMsg.Click += new System.EventHandler(this.btn_SendMsg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Statu:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lb_Statu);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(39, 337);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(221, 100);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mode";
            // 
            // lb_Statu
            // 
            this.lb_Statu.AutoSize = true;
            this.lb_Statu.BackColor = System.Drawing.Color.Red;
            this.lb_Statu.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Statu.Location = new System.Drawing.Point(73, 62);
            this.lb_Statu.Name = "lb_Statu";
            this.lb_Statu.Size = new System.Drawing.Size(138, 25);
            this.lb_Statu.TabIndex = 9;
            this.lb_Statu.Text = "UnConnected";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tcp Client";
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.ButtonInterval = 25;
            windowsUIButtonImageOptions19.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions19.SvgImage")));
            windowsUIButtonImageOptions20.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions20.SvgImage")));
            windowsUIButtonImageOptions21.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions21.SvgImage")));
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("清除发送", true, windowsUIButtonImageOptions19, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("清除接收", true, windowsUIButtonImageOptions20, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("连接", true, windowsUIButtonImageOptions21, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(23, 458);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(242, 79);
            this.windowsUIButtonPanel1.TabIndex = 13;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(765, 568);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "OneChat";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtB_RecvMsg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtB_SendMsg;
        private System.Windows.Forms.Button btn_SendMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tB_LocalPort;
        public System.Windows.Forms.TextBox tB_LocalIp;
        public System.Windows.Forms.TextBox tB_RemotePort;
        public System.Windows.Forms.TextBox tB_RemoteIp;
        private System.Windows.Forms.Label lb_Statu;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
    }
}

