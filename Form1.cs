using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using MetroFramework;
using DevExpress.XtraEditors;

namespace OneChat
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private delegate void InvokeDelegate();
        public MainForm()
        {
            InitializeComponent();
        }
        //全局变量
        Thread t = null;        //接收进程、接收显示进程
        string RecvData = null;    //接收的数据
        static Socket TcpClient = null;

        EndPoint edpTcpRemote;
        EndPoint edpTcpLocal;

        /// <summary>
        /// 获取本机IP地址
        /// </summary>
        public string GetLocalIp()
        {
            ///获取本地的IP地址
            string AddressIP = string.Empty;
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    AddressIP = _IPAddress.ToString();
                }
            }
            return AddressIP;
        }
 
        private void btn_SendMsg_Click(object sender, EventArgs e)
        {
            if (null != TcpClient)
            {
                if (true == TcpClient.Connected)
                {
                    try
                    {
                        TcpClient.Send(System.Text.Encoding.Default.GetBytes(rtB_SendMsg.Text + "\r\n"));
                        RecvData = RecvData + "【自己:】" + rtB_SendMsg.Text + "\r\n";
                        this.rtB_RecvMsg.Text = RecvData;
                        //让富文本框自动滑到最底行
                        //让文本框获取焦点 
                        this.rtB_RecvMsg.Focus();
                        //设置光标的位置到文本尾 
                        this.rtB_RecvMsg.Select(this.rtB_RecvMsg.TextLength - 1, 0);
                        //滚动到控件光标处 
                        this.rtB_RecvMsg.ScrollToCaret();

                    }
                    catch {

                        MessageBox.Show("发送失败");
                    }

                }
            }
        }
        private void DisPlayRecvData()
        {
            this.rtB_RecvMsg.Text = RecvData;
            //让富文本框自动滑到最底行
            //让文本框获取焦点 
            this.rtB_RecvMsg.Focus();
            //设置光标的位置到文本尾 
            this.rtB_RecvMsg.Select(this.rtB_RecvMsg.TextLength-1, 0);
            //滚动到控件光标处 
            this.rtB_RecvMsg.ScrollToCaret();

        }
        private void ReciveMsg()
        {
            byte[] TcpRecvBuf = new byte[1024];
            int length;
            while (true)
            {
                Thread.sleep(10);//线程添加sleep休眠函数，解决占用sleep过高的问题
                if (null != TcpClient)
                {
                    try
                    {
                        if (true == TcpClient.Connected)
                        {
                            if (TcpClient.Poll(-1, SelectMode.SelectRead))
                            {
                                length = TcpClient.Receive(TcpRecvBuf);//接收数据报
                                //MessageBox.Show(Convert.ToString(length));
                                if (0 != length)
                                {
                                    // length = TcpClient.Receive(TcpRecvBuf);//接收数据报    
                                    //RecvData += "【from " + edpTcpRemote + "】:" + Encoding.Default.GetString(TcpRecvBuf, 0, length);//Encoding.UTF8.GetString方法不能支持中文
                                    RecvData += "【对方:】:" + Encoding.Default.GetString(TcpRecvBuf, 0, length);//Encoding.UTF8.GetString方法不能支持中文
                                    RecvData += "\r\n";//接收完换行   
                                    this.Invoke(new InvokeDelegate(DisPlayRecvData));

                                }
                                else
                                    break;

                            }

                        }
                    }
                    catch { 
                    }
                    
                }

            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.tB_LocalIp.Text = GetLocalIp();
            this.tB_RemoteIp.Text = this.tB_LocalIp.Text;
            t = new Thread(ReciveMsg);
            t.Start();
        }
       
        string eee;
        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            eee = e.Button.ToString().Substring(e.Button.ToString().LastIndexOf("=") + 1).Trim();
            switch (e.Button.ToString().Substring(e.Button.ToString().LastIndexOf("=") + 1).Trim())
            {
                case "'清除发送'":
                    rtB_SendMsg.Text = "";
                    break;
                case "'清除接收'":
                    RecvData = "";
                    rtB_RecvMsg.Text = "";
                    break;
                case "'连接'":
                    TcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    edpTcpLocal = new IPEndPoint(IPAddress.Parse(this.tB_LocalIp.Text), Convert.ToInt32(this.tB_LocalPort.Text));
                    edpTcpRemote = new IPEndPoint(IPAddress.Parse(this.tB_RemoteIp.Text), Convert.ToInt32(this.tB_RemotePort.Text));

                    if (false == TcpClient.Connected)
                    {
                        lb_Statu.BackColor = Color.Red;
                        lb_Statu.Text = "UnConnected";
                        try
                        {
                            TcpClient.Bind(edpTcpLocal);
                            TcpClient.Connect(edpTcpRemote);
                            if (true == TcpClient.Connected)
                            {
                                lb_Statu.BackColor = Color.Green;
                                lb_Statu.Text = "Connected";
                                MessageBox.Show("连接成功");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("端口被占用,连接失败");
                        }
                    }

                    break;
                default:
                    break;



            }
        }
    }
}
