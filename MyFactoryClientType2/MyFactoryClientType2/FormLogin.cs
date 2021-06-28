using MyFactoryClientType2.Enums;
using MyFactoryClientType2.Models;
using MyFactoryClientType2.Sockets;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFactoryClientType2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            var resultLoginToServer = LoginToServer();
            if (resultLoginToServer.Success)
            {
                this.Hide();
                FormMyFactoryClientType2 frm = new FormMyFactoryClientType2();
                frm.Closed += (s, args) => this.Close();
                frm.textBoxMyIp.Text = textBoxMyIp.Text.Trim();
                frm.textBoxMyPort.Text = textBoxMyPort.Text.Trim();
                frm.textBoxServerIp.Text = textBoxServerIp.Text.Trim();
                frm.textBoxServerPort.Text = textBoxServerPort.Text.Trim();
                frm.textBoxUserName.Text = textBoxUserName.Text.Trim();
                frm.Show();
            }
            else
            {
                MessageBox.Show(resultLoginToServer.Message);
            }


            
            
        }

        public Result<string> LoginToServer()
        {
            try
            {
                string serverIp = textBoxServerIp.Text.Trim();
                int serverPort = int.Parse(textBoxServerPort.Text.Trim());
                string sendMessage = ModelTypeEnum.M003.ToString();

                M003 m003 = new M003(); 
                m003.MyIPAdress = textBoxMyIp.Text.Trim();
                m003.MyPort = int.Parse(textBoxMyPort.Text.Trim());
                m003.UserName = textBoxUserName.Text.Trim();
                m003.Password = textBoxPassword.Text.Trim();
                

                string JsonString = JsonConvert.SerializeObject(m003);

                sendMessage += JsonString;

                var resultConnect = MyTcpSender.Connect(serverIp, sendMessage, serverPort);

                if (!resultConnect.Success)
                {
                    return new Result<string>(false, $"{resultConnect.Message}", null);

                }

                //var json=JsonConvert.DeserializeObject(resultConnect.Data);

                if (!resultConnect.Data.Contains("Success")|| !resultConnect.Data.Contains("Message") || !resultConnect.Data.Contains("Data"))
                {
                    return new Result<string>(false, $"{resultConnect.Message}", null);
                }

                JObject jObjectData = JObject.Parse(resultConnect.Data);

                bool Success = (bool)jObjectData["Success"];
                if (!Success)
                {
                    return new Result<string>(false, $"{jObjectData["Message"]}", null);
                }

                //var resultUpsertAtNowMachineStatuses = ClientType1ProcessDal.UpsertAtNowMachineStatuses(m001.MachineId, (int)m001.MachineStatus);


                return new Result<string>(true, $"Başarılı", null);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", null);
            }
        }

    }
}
