using MyFactoryClientType1.DataAccess;
using MyFactoryClientType1.Enums;
using MyFactoryClientType1.Models;
using MyFactoryClientType1.Sockets;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFactoryClientType1
{
    public partial class FormMyFactoryClientType1 : Form
    {
        

        public FormMyFactoryClientType1()
        {
            InitializeComponent();
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {
           
            Thread thread1 = new Thread(new ThreadStart(MyTcpListener.Listen));
            thread1.Start();
            

            Console.ReadLine();
        }

        private void buttonSenderToServer_Click(object sender, EventArgs e)
        {
           

            LoginToServer();
            

        }

        static string GetLocalIPAddress()
        {
            string localIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(a => a.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).FirstOrDefault().ToString();

            return localIP;
        }


        public Result<string> LoginToServer()
        {
            try
            {
                string serverIp = textBoxServerIp.Text.Trim();
                int serverPort = int.Parse(textBoxServerPort.Text.Trim());
                string sendMessage = ModelTypeEnum.M001.ToString();
               
                M001 m001 = new M001();
                m001.MyIPAdress = textBoxMyIp.Text.Trim();
                m001.MyPort = int.Parse(textBoxMyPort.Text.Trim());
                m001.MachineName = textBoxMachineName.Text.Trim(); 
                m001.MachineId = int.Parse(textBoxMachineId.Text.Trim()); 
                m001.MachineType = (MachineTypeEnum)comboBoxMachineType.SelectedIndex;
                m001.ProductionSpeeedOfMachine = int.Parse(textBoxProductionSpeeedOfMachine.Text.Trim());
                m001.ProductionUnitType =(ProductionUnitTypeEnum)comboBoxProductionUnitType.SelectedIndex ;
                m001.MachineStatus =MachineStatusEnum.EMPTY ;

                string JsonString = JsonConvert.SerializeObject(m001);

                sendMessage += JsonString;

                var resultConnect = MyTcpSender.Connect(serverIp, sendMessage, serverPort);

                //var resultUpsertAtNowMachineStatuses = ClientType1ProcessDal.UpsertAtNowMachineStatuses(m001.MachineId,(int)m001.MachineStatus);

                comboBoxMachineStatus.SelectedIndex = 1;


                return new Result<string>(true, $"Başarılı", null);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", null);
            }            
        }

        private void FormMyFactoryClientType1_Load(object sender, EventArgs e)
        {
            comboBoxMachineStatus.SelectedIndex = 1;
        }

        private void comboBoxMachineStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxMachineStatus.Text = comboBoxMachineStatus.SelectedIndex.ToString();
        }
    }
}
