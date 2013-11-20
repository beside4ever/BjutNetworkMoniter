using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
using Microsoft.Win32;

namespace BjutNetworkMoniter
{
    public partial class Form1 : Form
    {
        private NetworkInterface[] networkInterfaces = null;
        private NetworkInterface currentInterface = null;
        private ArrayList Nics = new ArrayList();
        private long lastBytesSent = 0;
        private long lastBytesReceived = 0;
        private bool isNicLoged = false;

        public Form1()
        {
            InitializeComponent();
            this.Visible = false;
            //判断网卡是否可用
            if (isNicActive())
            {
                //调取程序设置，更改控件状态或内容
                checkBoxSavePw.Checked = Properties.Settings.Default.SavePw;
                checkBoxAutorun.Checked = Properties.Settings.Default.Autorun;
                int lastAccIndex = Properties.Settings.Default.lastAccIndex;
                //初始化网卡列表、更新网卡状态、启动计时器、刷新校园网状态
                InitComboBoxNic();
                UpdateNicStats();
                StartNicStatusTmr();
                UpdateBjutStatus();
                //如果保存过密码则填充文本框内容
                if (checkBoxSavePw.Checked && Properties.Settings.Default.Username.Count > 0)
                {
                    textBoxUsername.Text = Properties.Settings.Default.Username[lastAccIndex];
                    textBoxPassword.Text = Properties.Settings.Default.Password[lastAccIndex];
                }
                //如果当前未登陆，尝试自动登录
                if (!this.isNicLoged)
                {
                    this.LogIn(textBoxUsername.Text, textBoxPassword.Text);
                    UpdateBjutStatus();
                }
                else
                {
                    this.autoCompletefromSetting();
                    this.setInterface(true);
                    this.showNotifyTip();
                }
                //登陆成功后自动隐藏界面
                if (this.isNicLoged)
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.Hide();
                    this.ShowInTaskbar = false;
                }
            }
            else
            {
                if (MessageBox.Show("没有可用的网卡！") == DialogResult.OK) Application.Exit();
            }
        }

        //判断是否有可用的网卡，并初始化networkInterfaces
        private bool isNicActive()
        {
            networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            if (networkInterfaces == null || networkInterfaces.Length < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //初始化计时器启动刷新网络状态的函数
        private void StartNicStatusTmr()
        {
            //启动计时器刷新页面
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer(new System.ComponentModel.Container());
            t.Tick += new System.EventHandler(tmrUpdate);
            t.Enabled = true;
            t.Interval = 1000;
            t.Start();
        }

        //初始化网卡列表的控件
        private void InitComboBoxNic()
        {
            //清空下拉表
            comboBoxNetworkInterfaces.Items.Clear();
            this.Nics.Clear();
            //循环添加所有网卡（排除loopback和标记不为up的
            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                if (networkInterface.OperationalStatus.ToString() == "Up" && networkInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    comboBoxNetworkInterfaces.Items.Add(networkInterface.Name);
                    this.Nics.Add(networkInterface);
                }
            }
            currentInterface = networkInterfaces[0];
            //将下拉列表设定为第一个
            comboBoxNetworkInterfaces.SelectedIndex = 0;
        }

        //计时器委托
        private void tmrUpdate(object sender, EventArgs e)
        {
            UpdateNicStats();
            UpdateBjutStatus();
        }

        //更新网络状态
        private void UpdateNicStats()
        {
            if (currentInterface == null) InitComboBoxNic();
            // Get the IPv4	statistics for the currently selected interface.
            IPv4InterfaceStatistics ipv4Stats = currentInterface.GetIPv4Statistics();

            double bytesReceivedInMB = Math.Round(ipv4Stats.BytesReceived / (1024 * 1024.0), 2);
            double bytesSentInMB = Math.Round(ipv4Stats.BytesSent / (1024 * 1024.0), 2);
            double kbytesReceivedSpeed = Math.Round((ipv4Stats.BytesReceived - lastBytesReceived) / 1024.0, 2);
            double kbytesSentSpeed = Math.Round((ipv4Stats.BytesSent - lastBytesSent) / 1024.0, 2);

            this.labelBytesReceived.Text = bytesReceivedInMB.ToString() + " MB";
            this.labelBytesSent.Text = bytesSentInMB.ToString() + " MB";
            this.labelBytesReceivedSpeed.Text = lastBytesReceived == 0 ? "0KB/s" : kbytesReceivedSpeed.ToString() + "KB/s";
            this.labelBytesSentSpeed.Text = lastBytesSent == 0 ? "0KB/s" : kbytesSentSpeed.ToString() + "KB/s";

            lastBytesReceived = ipv4Stats.BytesReceived;
            lastBytesSent = ipv4Stats.BytesSent;
        }

        //网卡变化
        private void SelectedNicChanged(object sender, EventArgs e)
        {
            currentInterface = (NetworkInterface)Nics[comboBoxNetworkInterfaces.SelectedIndex];
            lastBytesSent = 0;
            lastBytesReceived = 0;
        }

        //抓取校园网登录后的状态页面更改界面显示状态
        private void UpdateBjutStatus()
        {
            //如果界面是隐藏的，则不更新（降低消耗）
            if (this.WindowState == FormWindowState.Minimized) {
                return;
            }
            try
            {
                WebRequest request = WebRequest.Create("http://nic.bjut.edu.cn/");
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("gb2312"));
                string stream = @reader.ReadToEnd();
                Regex r = new Regex(@"flow='(.*)';fsele=1;fee='(.*)';x");
                reader.Close();
                response.Close();
                if (r.IsMatch(stream))
                {
                    int flow = Convert.ToInt32(r.Match(stream).Groups[1].Value);
                    int fee = Convert.ToInt32(r.Match(stream).Groups[2].Value);
                    double flow1 = Math.Round(flow / 1024.0, 2);
                    double fee1 = Math.Round(fee / 10000.0, 2);
                    int daysFlowed = DateTime.Now.Day;
                    double flowPerDay = Math.Round(flow / daysFlowed / 1024.0, 2);

                    labelFlow.Text = string.Format("{0} MB", flow1);
                    labelFee.Text = string.Format("{0} 元", fee1);
                    labelFlowPerDay.Text = string.Format("{0} MB", flowPerDay);
                    toolTip1.SetToolTip(labelFlowPerDay, string.Format("本月已过去了{0}天，\n平均每天您使用了{1}MB流量。", daysFlowed, flowPerDay));
                    this.isNicLoged = true;
                }
                else
                {
                    this.isNicLoged = false;
                }
            }
            catch (WebException e)
            {
                notifyIcon1.BalloonTipText = e.Message;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        //点击登陆按钮的代码
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //已经登陆，则注销
            if (this.isNicLoged)
            {
                WebRequest request = WebRequest.Create("http://nic.bjut.edu.cn/F.htm");
                WebResponse response = request.GetResponse();
                response.Close();
                this.isNicLoged = false;
                this.setInterface(false);
                this.showNotifyTip();
            }
            //没登陆就登陆
            else
            {
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                this.LogIn(username, password);
            }
        }

        //从设置项中把已保存的账号密码填入textbox的自动完成序列里
        private void autoCompletefromSetting()
        {
            System.Collections.Specialized.StringCollection users = Properties.Settings.Default.Username;
            textBoxUsername.AutoCompleteCustomSource.Clear();
            for (int n = 0; n < users.Count; n++)
            {
                textBoxUsername.AutoCompleteCustomSource.Add(users[n]);
            }
        }

        //登陆主函数
        private void LogIn(string username, string password)
        {
            string postString = string.Format("DDDDD={0}&upass={1}&0MKKey=%C1%AC%BD%D3%CD%F8%C2%E7", username, password);
            byte[] postData = Encoding.GetEncoding("GB2312").GetBytes(postString);//编码，尤其是汉字，事先要看下抓取网页的编码方式  
            string url = "http://nic.bjut.edu.cn/";//地址  
            WebClient webClient = new WebClient();
            webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");//采取POST方式必须加的header，如果改为GET方式的话就去掉这句话即可  
            byte[] responseData = null;
            try
            {
                responseData = webClient.UploadData(url, "POST", postData);//得到返回字符流 
            }
            catch {
                return;
            }
            string srcString = Encoding.GetEncoding("GB2312").GetString(responseData);//解码  

            //登录成功
            if (srcString.IndexOf("您已经成功登录") > 0)
            {
                if (checkBoxSavePw.Checked)
                {
                    //如果选中保存密码，则保存字符串
                    int existId = Properties.Settings.Default.Username.IndexOf(username);
                    //如果已存在此账号则删除之前的内容
                    if (existId > 0)
                    {
                        Properties.Settings.Default.Username.RemoveAt(existId);
                        Properties.Settings.Default.Password.RemoveAt(existId);
                    }
                    Properties.Settings.Default.Username.Add(username);
                    Properties.Settings.Default.Password.Add(password);
                    Properties.Settings.Default.lastAccIndex = Properties.Settings.Default.Username.IndexOf(username);
                    Properties.Settings.Default.Save();
                    //根据设置保存的用户名集合填充到文本框的自动完成序列
                    this.autoCompletefromSetting();
                }
                this.setInterface(true);
                this.showNotifyTip();
            }
            //失败情况下解析出错误代码
            else
            {
                Regex r = new Regex(@"Msg=(.*);t");
                string msg = "登录失败";
                if (r.IsMatch(srcString))
                {
                    int msgCode = Convert.ToInt32(r.Match(srcString).Groups[1].Value);
                    switch (msgCode)
                    {
                        case 0:
                        case 1:
                            msg = "账号或密码不对，请重新输入";
                            break;
                        case 2:
                            msg = "本账号正在使用中！";
                            break;
                        case 3:
                            msg = "本账号只能在指定地址使用";
                            break;
                        case 4:
                            msg = "本账号余额为零";
                            break;
                    }
                }
                this.setInterface(false);
                this.showNotifyTip(msg);
            }
        }

        //根据登陆成功与否更改界面控件状态
        private void setInterface(bool logged)
        {
            if (logged)
            {
                textBoxUsername.Enabled = false;
                textBoxPassword.Enabled = false;
                buttonLogin.Text = "注销";
                contextMenuStrip1.Items[0].Text = "注销";
            }
            else
            {
                textBoxUsername.Enabled = true;
                textBoxPassword.Enabled = true;
                buttonLogin.Text = "登录";
                contextMenuStrip1.Items[0].Text = "登录";
                labelFlow.Text = "请先登录";
                labelFee.Text = "请先登录";
                labelFlowPerDay.Text = "请先登录"; 
            }
            this.isNicLoged = logged;
        }

        //显示通知区域消息，根据登陆状态决定显示登陆或断开，如果参数有附加信息则显示附加信息（失败的消息）
        private void showNotifyTip(string msg = "")
        {
            if (msg != "")
            {
                notifyIcon1.BalloonTipText = msg;
            }
            else
            {
                if (this.isNicLoged)
                {
                    string curUser = textBoxUsername.Text == "" ? "" : string.Format("\n当前账号：{0}", textBoxUsername.Text);
                    notifyIcon1.BalloonTipText = "校园网已登录" + curUser;
                }
                else
                {
                    notifyIcon1.BalloonTipText = "校园网未登录";
                }
            }
            notifyIcon1.ShowBalloonTip(1000);
        }

        //保存密码选项变动时，更改设置内容
        private void checkBoxSavePw_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SavePw = checkBoxSavePw.Checked;
            Properties.Settings.Default.Save();
        }

        //更改开机启动选项，设置注册表
        private void checkBoxAutorun_CheckedChanged(object sender, EventArgs e)
        {
            string R_startPath = Application.ExecutablePath;
            try
            {
                RegistryKey R_local = Registry.CurrentUser;
                RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                if (checkBoxAutorun.Checked)
                {
                    R_run.SetValue("BjutNetworkMoniter", R_startPath);
                }
                else
                {
                    R_run.DeleteValue("BjutNetworkMoniter", false);
                }
                R_run.Close();
                R_local.Close();
            }
            catch
            {
                MessageBox.Show("注册表修改失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            Properties.Settings.Default.Autorun = checkBoxAutorun.Checked;
            Properties.Settings.Default.Save();
        }

        //密码输入框按下回车直接尝试登陆
        private void textBoxPw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter) buttonLogin_Click(sender, e);
        }

        //打开关于窗口
        private void button1_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout(new Point(this.Location.X + this.Size.Width, this.Location.Y));
            if (formAbout.ShowDialog(this) == DialogResult.Abort)
            {
                formAbout.Dispose();
            }
        }

        //右键菜单程序退出
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //右键菜单弹出主界面
        private void MainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        //右键菜单进行登陆
        private void LogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainToolStripMenuItem_Click(sender, e);
            buttonLogin_Click(sender, e);
        }

        //双击通知区域小图标
        private void notifyIcon1_MDC(object sender, MouseEventArgs e)
        {
            MainToolStripMenuItem_Click(sender, e);
        }

        //窗口最小化时隐藏界面
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
            }
        }

        //根据账号框的内容变化确定是否自动填充密码
        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            //如果设置里保存的用户名集合中包含了当前输入框的用户名的话
            if (Properties.Settings.Default.Username.Count > 0)
            {
                int index = Properties.Settings.Default.Username.IndexOf(textBoxUsername.Text);
                if (index >= 0)
                {
                    //则自动填充对应的密码
                    textBoxPassword.Text = Properties.Settings.Default.Password[index];
                }
            }
        }
    }
}
