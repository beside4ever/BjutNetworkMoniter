namespace BjutNetworkMoniter
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxNetworkInterfaces = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBytesSent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBytesReceived = new System.Windows.Forms.Label();
            this.labelBytesSentSpeed = new System.Windows.Forms.Label();
            this.labelBytesReceivedSpeed = new System.Windows.Forms.Label();
            this.labelTip1 = new System.Windows.Forms.Label();
            this.labelTip2 = new System.Windows.Forms.Label();
            this.labelFee = new System.Windows.Forms.Label();
            this.labelFlow = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxAutorun = new System.Windows.Forms.CheckBox();
            this.checkBoxSavePw = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFlowPerDay = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxNetworkInterfaces
            // 
            this.comboBoxNetworkInterfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNetworkInterfaces.FormattingEnabled = true;
            this.comboBoxNetworkInterfaces.Location = new System.Drawing.Point(8, 20);
            this.comboBoxNetworkInterfaces.Name = "comboBoxNetworkInterfaces";
            this.comboBoxNetworkInterfaces.Size = new System.Drawing.Size(190, 20);
            this.comboBoxNetworkInterfaces.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBoxNetworkInterfaces, "请选择您正在使用的网络连接");
            this.comboBoxNetworkInterfaces.SelectedIndexChanged += new System.EventHandler(this.SelectedNicChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "上传流量";
            // 
            // labelBytesSent
            // 
            this.labelBytesSent.Location = new System.Drawing.Point(128, 45);
            this.labelBytesSent.Name = "labelBytesSent";
            this.labelBytesSent.Size = new System.Drawing.Size(70, 12);
            this.labelBytesSent.TabIndex = 0;
            this.labelBytesSent.Text = "0";
            this.labelBytesSent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "下载流量";
            // 
            // labelBytesReceived
            // 
            this.labelBytesReceived.Location = new System.Drawing.Point(128, 66);
            this.labelBytesReceived.Name = "labelBytesReceived";
            this.labelBytesReceived.Size = new System.Drawing.Size(70, 12);
            this.labelBytesReceived.TabIndex = 0;
            this.labelBytesReceived.Text = "0";
            this.labelBytesReceived.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelBytesSentSpeed
            // 
            this.labelBytesSentSpeed.AutoSize = true;
            this.labelBytesSentSpeed.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBytesSentSpeed.Location = new System.Drawing.Point(38, 17);
            this.labelBytesSentSpeed.Name = "labelBytesSentSpeed";
            this.labelBytesSentSpeed.Size = new System.Drawing.Size(93, 35);
            this.labelBytesSentSpeed.TabIndex = 0;
            this.labelBytesSentSpeed.Text = "0KB/S";
            // 
            // labelBytesReceivedSpeed
            // 
            this.labelBytesReceivedSpeed.AutoSize = true;
            this.labelBytesReceivedSpeed.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBytesReceivedSpeed.Location = new System.Drawing.Point(38, 54);
            this.labelBytesReceivedSpeed.Name = "labelBytesReceivedSpeed";
            this.labelBytesReceivedSpeed.Size = new System.Drawing.Size(93, 35);
            this.labelBytesReceivedSpeed.TabIndex = 0;
            this.labelBytesReceivedSpeed.Text = "0KB/S";
            // 
            // labelTip1
            // 
            this.labelTip1.AutoSize = true;
            this.labelTip1.Location = new System.Drawing.Point(4, 102);
            this.labelTip1.Name = "labelTip1";
            this.labelTip1.Size = new System.Drawing.Size(89, 12);
            this.labelTip1.TabIndex = 0;
            this.labelTip1.Text = "本月已使用流量";
            // 
            // labelTip2
            // 
            this.labelTip2.AutoSize = true;
            this.labelTip2.Location = new System.Drawing.Point(6, 47);
            this.labelTip2.Name = "labelTip2";
            this.labelTip2.Size = new System.Drawing.Size(29, 12);
            this.labelTip2.TabIndex = 0;
            this.labelTip2.Text = "密码";
            // 
            // labelFee
            // 
            this.labelFee.Location = new System.Drawing.Point(99, 141);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(84, 12);
            this.labelFee.TabIndex = 0;
            this.labelFee.Text = "请先登录";
            this.labelFee.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFlow
            // 
            this.labelFlow.Location = new System.Drawing.Point(99, 102);
            this.labelFlow.Name = "labelFlow";
            this.labelFlow.Size = new System.Drawing.Size(84, 12);
            this.labelFlow.TabIndex = 0;
            this.labelFlow.Text = "请先登录";
            this.labelFlow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(116, 71);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(69, 23);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxUsername.Location = new System.Drawing.Point(71, 17);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(114, 21);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(71, 44);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(114, 21);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPw_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBoxAutorun);
            this.groupBox1.Controls.Add(this.checkBoxSavePw);
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelTip1);
            this.groupBox1.Controls.Add(this.labelFee);
            this.groupBox1.Controls.Add(this.labelFlowPerDay);
            this.groupBox1.Controls.Add(this.labelFlow);
            this.groupBox1.Controls.Add(this.labelTip2);
            this.groupBox1.Location = new System.Drawing.Point(220, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "校园网状态";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "关于";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxAutorun
            // 
            this.checkBoxAutorun.AutoSize = true;
            this.checkBoxAutorun.Location = new System.Drawing.Point(6, 164);
            this.checkBoxAutorun.Name = "checkBoxAutorun";
            this.checkBoxAutorun.Size = new System.Drawing.Size(96, 16);
            this.checkBoxAutorun.TabIndex = 7;
            this.checkBoxAutorun.Text = "开机自动运行";
            this.checkBoxAutorun.UseVisualStyleBackColor = true;
            this.checkBoxAutorun.CheckedChanged += new System.EventHandler(this.checkBoxAutorun_CheckedChanged);
            // 
            // checkBoxSavePw
            // 
            this.checkBoxSavePw.AutoSize = true;
            this.checkBoxSavePw.Location = new System.Drawing.Point(8, 75);
            this.checkBoxSavePw.Name = "checkBoxSavePw";
            this.checkBoxSavePw.Size = new System.Drawing.Size(72, 16);
            this.checkBoxSavePw.TabIndex = 7;
            this.checkBoxSavePw.Text = "保存密码";
            this.checkBoxSavePw.UseVisualStyleBackColor = true;
            this.checkBoxSavePw.CheckedChanged += new System.EventHandler(this.checkBoxSavePw_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "账号余额";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "日均已使用流量";
            // 
            // labelFlowPerDay
            // 
            this.labelFlowPerDay.Location = new System.Drawing.Point(99, 122);
            this.labelFlowPerDay.Name = "labelFlowPerDay";
            this.labelFlowPerDay.Size = new System.Drawing.Size(84, 12);
            this.labelFlowPerDay.TabIndex = 0;
            this.labelFlowPerDay.Text = "请先登录";
            this.labelFlowPerDay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxNetworkInterfaces);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelBytesSent);
            this.groupBox2.Controls.Add(this.labelBytesReceived);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 85);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "网络状态";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.labelBytesSentSpeed);
            this.groupBox3.Controls.Add(this.labelBytesReceivedSpeed);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 96);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "即时网速";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BjutNetworkMoniter.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(8, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BjutNetworkMoniter.Properties.Resources.upload;
            this.pictureBox1.Location = new System.Drawing.Point(8, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "BjutNetworkMoniter";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "工大校园网助手";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MDC);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogToolStripMenuItem,
            this.MainToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 70);
            // 
            // LogToolStripMenuItem
            // 
            this.LogToolStripMenuItem.Name = "LogToolStripMenuItem";
            this.LogToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.LogToolStripMenuItem.Text = "登陆/注销";
            this.LogToolStripMenuItem.Click += new System.EventHandler(this.LogToolStripMenuItem_Click);
            // 
            // MainToolStripMenuItem
            // 
            this.MainToolStripMenuItem.Name = "MainToolStripMenuItem";
            this.MainToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.MainToolStripMenuItem.Text = "显示主界面";
            this.MainToolStripMenuItem.Click += new System.EventHandler(this.MainToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ExitToolStripMenuItem.Text = "关闭程序";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 209);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BjutNetworkMoniter";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNetworkInterfaces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBytesSent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBytesReceived;
        private System.Windows.Forms.Label labelBytesSentSpeed;
        private System.Windows.Forms.Label labelBytesReceivedSpeed;
        private System.Windows.Forms.Label labelTip1;
        private System.Windows.Forms.Label labelTip2;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.Label labelFlow;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxSavePw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxAutorun;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFlowPerDay;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

