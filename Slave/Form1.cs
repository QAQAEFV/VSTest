using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus.Data;

namespace Slave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 服务器的创建
        bool isServerCreated;
        bool creatServer;
        int count2;
        TcpListener listener;
        ModbusSlave slave;
        DataStore store;

        private void Creat_Click(object sender, EventArgs e)
        {

            try
            {
                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), Convert.ToInt32("502"));
                listener.Start();
                slave = ModbusTcpSlave.CreateTcp(2, listener);//创建对象
                store = DataStoreFactory.CreateDefaultDataStore();
                slave.DataStore = store;
/*                slave.DataStore = Modbus.Data.DataStoreFactory.CreateDefaultDataStore();//用于清除Modbus TCP Slave的数据存储区，寄存器区值全部写0*/
                listBox1.Items.Add("创建服务器成功！" + "线程ID：" + Thread.CurrentThread.ManagedThreadId + "\r\n");
                //订阅接收到报文请求事件，可以打印接收到的报文
                slave.ModbusSlaveRequestReceived += ModbusSlaveRequestReceivedHandle;
                //订阅接收到写入完成事件，可以打印写入完成响应
                slave.WriteComplete += WriteCompleteHandle;
                slave.Listen();
                isServerCreated = true;
                listBox1.Items.Add("服务器创建成功！" + "\r\n");
                count2 = 0;
            }
            catch (Exception ex)
            {
                count2++;
                listBox1.Items.Add("创建服务器失败！" + "失败次数:" + count2.ToString() + "\r\n");
                isServerCreated = false;
                creatServer = false;
                return;
            }
        }

        private void ModbusSlaveRequestReceivedHandle(object obj, ModbusSlaveRequestEventArgs e)
        {
            string str = "";
            foreach (var item in e.Message.MessageFrame)
            {
                str += item.ToString("x2").PadLeft(2, '0').ToUpper() + "  ";
            }
            listBox1.Items.Add("服务器收到报文:  " + str + "\r\n");
        }
        private void WriteCompleteHandle(object sender, ModbusSlaveRequestEventArgs e)
        {
            string str = "";
            foreach (var item in e.Message.MessageFrame)
            {
                str += item.ToString("x2").PadLeft(2, '0').ToUpper() + "  ";
            }
            listBox1.Items.Add("服务器写入完成:  " + str + "\r\n");
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            ushort address = 1000;
            ushort[] arry = new ushort[100];
            for(int i = 0; i < 100; i++)
            {
                arry[i] = store.HoldingRegisters[i];
            }
            string temp = "";
            for(int i = 0;i<arry.Length;i++)
            {
                temp += arry[i].ToString()+"....";
            }
            MessageBox.Show(temp);
        }

        private int Add(int x, int y)
        {
            return x + y;
        }
        private int jianfa(int x, int y)
        {
            return x - y;
        }

    }
}