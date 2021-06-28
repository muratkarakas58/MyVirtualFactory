using MyFactoryServer.Enums;
using MyFactoryServer.Models;
using MyFactoryServer.Sockets;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFactoryServer
{
    public partial class FormMyFactoryServer : Form
    {
             

        public FormMyFactoryServer()
        {
            InitializeComponent();
            
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {

            Thread thread1 = new Thread(new ThreadStart(MyTcpListener.Listen));
            thread1.Start();                      

            Console.ReadLine();
        }

        private void buttonSenderToMachine_Click(object sender, EventArgs e)
        {
            string machineIP = "127.0.0.1";
            int machinePort = 14000;

            M002 m002 = new M002();
            m002.WorkId = 1;
            m002.QuantityToBeProduced = 10;
            

            SendWorkToMachine(machineIP,machinePort,m002);

           
            //MyTcpClient.Connect("127.0.0.1", "Merhaba ben sunucu", 14000);

        }

        static string GetLocalIPAddress()
        {
            string localIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(a => a.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).FirstOrDefault().ToString();

            return localIP;
        }

        public Result<string> SendWorkToMachine(string machineIP, int machinePort, M002 m002) 
        {
            try
            {
                string serverIp = machineIP;
                int serverPort = machinePort;
                string sendMessage = ModelTypeEnum.M002.ToString();

                //M002 m002 = new M002();
                //m002.WorkId = 1;
                              

                string JsonString = JsonConvert.SerializeObject(m002);

                sendMessage += JsonString;

                var resultConnect = MyTcpSender.Connect(serverIp, sendMessage, serverPort);

                //Todo: Gönderilen iş kabul edildiyse iş ve makine durumunu güncelle.
                //var resultUpsertAtNowMachineStatuses = ClientType1ProcessDal.UpsertAtNowMachineStatuses(m001.MachineId, (int)m001.MachineStatus);
               


                return new Result<string>(true, $"Başarılı", null);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", null);
            }
        }

        private void FormMyFactoryServer_Load(object sender, EventArgs e)
        {

        }
    }
}
