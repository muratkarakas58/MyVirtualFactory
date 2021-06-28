using MyFactoryClientType2.DataAccess;
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
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFactoryClientType2
{
    public partial class FormMyFactoryClientType2 : Form
    {
        

        public FormMyFactoryClientType2()
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
           

            SendWorkToServer();
            

        }

        static string GetLocalIPAddress()
        {
            string localIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(a => a.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).FirstOrDefault().ToString();

            return localIP;
        }


        public Result<string> SendWorkToServer() 
        {
            try
            {
                string serverIp = textBoxServerIp.Text.Trim();
                int serverPort = int.Parse(textBoxServerPort.Text.Trim());
                string sendMessage = ModelTypeEnum.M004.ToString();
               
                M004 m004 = new M004();
                m004.MyIPAdress = textBoxMyIp.Text.Trim();
                m004.MyPort = int.Parse(textBoxMyPort.Text.Trim());
                m004.UserName = textBoxUserName.Text.Trim();
                m004.MachineType = (MachineTypeEnum)comboBoxMachineType.SelectedIndex;
                m004.QuantityToBeProduced = int.Parse(textBoxQuantityToBeProduced.Text.Trim());
                m004.ProductionUnitType =(ProductionUnitTypeEnum)comboBoxProductionUnitType.SelectedIndex ;
                

                string JsonString = JsonConvert.SerializeObject(m004);

                sendMessage += JsonString;

                var resultConnect = MyTcpSender.Connect(serverIp, sendMessage, serverPort);

                //var resultUpsertAtNowMachineStatuses = ClientType1ProcessDal.UpsertAtNowMachineStatuses(m003.MachineId,(int)m003.MachineStatus);


                return new Result<string>(true, $"Başarılı", null);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", null);
            }            
        }

        private void FormMyFactoryClientType2_Load(object sender, EventArgs e)
        {

        }

        private void buttonGetMachineList_Click(object sender, EventArgs e)
        {
            GetMachineList();
        }

        public Result<string> GetMachineList()
        {
            try
            {
                string serverIp = textBoxServerIp.Text.Trim();
                int serverPort = int.Parse(textBoxServerPort.Text.Trim());
                string sendMessage = ModelTypeEnum.M005.ToString();

                M005 m005 = new M005();
                m005.MyIPAdress = textBoxMyIp.Text.Trim();
                m005.MyPort = int.Parse(textBoxMyPort.Text.Trim());
                


                string JsonString = JsonConvert.SerializeObject(m005);

                sendMessage += JsonString;

                var resultConnect = MyTcpSender.Connect(serverIp, sendMessage, serverPort);
                if (!resultConnect.Success)
                {
                    return new Result<string>(false, $"{resultConnect.Message}", null);

                }

                //var json=JsonConvert.DeserializeObject(resultConnect.Data);

                if (!resultConnect.Data.Contains("Success") || !resultConnect.Data.Contains("Message") || !resultConnect.Data.Contains("Data"))
                {
                    return new Result<string>(false, $"{resultConnect.Message}", null);
                }

                JObject jObjectData = JObject.Parse(resultConnect.Data);

                bool Success = (bool)jObjectData["Success"];
                if (!Success)
                {
                    return new Result<string>(false, $"{jObjectData["Message"]}", null);
                }
                                

                ;
                JArray jArrayData = JArray.Parse(jObjectData["Data"].ToString());

               

                foreach (JObject itemHeader in jArrayData.ToList())
                {
                    foreach (JProperty itemLines in itemHeader.Properties())
                    {

                        //var test5 = itemLines.Name;
                        //var test6 = itemLines.Value;
                        DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
                        dataGridViewTextBoxColumn.Name= itemLines.Name;
                        
                        
                        dataGridViewGetMachineList.Columns.Add(dataGridViewTextBoxColumn);
                    }
                    break;
                }

                
                int rowCount = 0;
                foreach (JObject itemHeader in jArrayData.ToList())
                {

                    dataGridViewGetMachineList.Rows.Add();
                    int cellCount = 0;                   

                    foreach (JProperty itemLines in itemHeader.Properties())
                    {                                     
                       
                        //var test5 = itemLines.Name;
                        //var test6 = itemLines.Value;
                        if (itemLines.Value!=null)
                        {
                            dataGridViewGetMachineList.Rows[rowCount].Cells[cellCount].Value= itemLines.Value;
                           
                        }
                        else
                        {
                            dataGridViewGetMachineList.Rows[rowCount].Cells[cellCount].Value = "";
                            
                        }

                        cellCount++;
                    }
                                       

                    rowCount++;
                }




                return new Result<string>(true, $"Başarılı", null);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", null);
            }
        }

        private void buttonGetMachineWorksList_Click(object sender, EventArgs e)
        {
            GetMachineWorksList();
        }

        public Result<string> GetMachineWorksList()
        {
            try
            {
                string serverIp = textBoxServerIp.Text.Trim();
                int serverPort = int.Parse(textBoxServerPort.Text.Trim());
                string sendMessage = ModelTypeEnum.M006.ToString(); 

                M006 m006 = new M006();
                m006.MyIPAdress = textBoxMyIp.Text.Trim();
                m006.MyPort = int.Parse(textBoxMyPort.Text.Trim());
                m006.MachineId = int.Parse(textBoxMachineId.Text.Trim());


                string JsonString = JsonConvert.SerializeObject(m006);

                sendMessage += JsonString;

                var resultConnect = MyTcpSender.Connect(serverIp, sendMessage, serverPort);
                if (!resultConnect.Success)
                {
                    return new Result<string>(false, $"{resultConnect.Message}", null);

                }

                //var json=JsonConvert.DeserializeObject(resultConnect.Data);

                if (!resultConnect.Data.Contains("Success") || !resultConnect.Data.Contains("Message") || !resultConnect.Data.Contains("Data"))
                {
                    return new Result<string>(false, $"{resultConnect.Message}", null);
                }

                JObject jObjectData = JObject.Parse(resultConnect.Data);

                bool Success = (bool)jObjectData["Success"];
                if (!Success)
                {
                    return new Result<string>(false, $"{jObjectData["Message"]}", null);
                }


                ;
                JArray jArrayData = JArray.Parse(jObjectData["Data"].ToString());



                foreach (JObject itemHeader in jArrayData.ToList())
                {
                    foreach (JProperty itemLines in itemHeader.Properties())
                    {

                        //var test5 = itemLines.Name;
                        //var test6 = itemLines.Value;
                        DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
                        dataGridViewTextBoxColumn.Name = itemLines.Name;


                        dataGridViewGetMachineWorksList.Columns.Add(dataGridViewTextBoxColumn);
                    }
                    break;
                }


                int rowCount = 0;
                foreach (JObject itemHeader in jArrayData.ToList())
                {

                    dataGridViewGetMachineWorksList.Rows.Add();
                    int cellCount = 0;

                    foreach (JProperty itemLines in itemHeader.Properties())
                    {

                        //var test5 = itemLines.Name;
                        //var test6 = itemLines.Value;
                        if (itemLines.Value != null)
                        {
                            dataGridViewGetMachineWorksList.Rows[rowCount].Cells[cellCount].Value = itemLines.Value;

                        }
                        else
                        {
                            dataGridViewGetMachineWorksList.Rows[rowCount].Cells[cellCount].Value = "";

                        }

                        cellCount++;
                    }


                    rowCount++;
                }




                return new Result<string>(true, $"Başarılı", null);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", null);
            }
        }

        private void buttonGetWaitingWorksList_Click(object sender, EventArgs e)
        {
            GetWaitingWorksList();
        }

        public Result<string> GetWaitingWorksList() 
        {
            try
            {
                string serverIp = textBoxServerIp.Text.Trim();
                int serverPort = int.Parse(textBoxServerPort.Text.Trim());
                string sendMessage = ModelTypeEnum.M007.ToString();

                M007 m007 = new M007();
                m007.MyIPAdress = textBoxMyIp.Text.Trim();
                m007.MyPort = int.Parse(textBoxMyPort.Text.Trim());
                


                string JsonString = JsonConvert.SerializeObject(m007);

                sendMessage += JsonString;

                var resultConnect = MyTcpSender.Connect(serverIp, sendMessage, serverPort);
                if (!resultConnect.Success)
                {
                    return new Result<string>(false, $"{resultConnect.Message}", null);

                }

                //var json=JsonConvert.DeserializeObject(resultConnect.Data);

                if (!resultConnect.Data.Contains("Success") || !resultConnect.Data.Contains("Message") || !resultConnect.Data.Contains("Data"))
                {
                    return new Result<string>(false, $"{resultConnect.Message}", null);
                }

                JObject jObjectData = JObject.Parse(resultConnect.Data);

                bool Success = (bool)jObjectData["Success"];
                if (!Success)
                {
                    return new Result<string>(false, $"{jObjectData["Message"]}", null);
                }


                ;
                JArray jArrayData = JArray.Parse(jObjectData["Data"].ToString());



                foreach (JObject itemHeader in jArrayData.ToList())
                {
                    foreach (JProperty itemLines in itemHeader.Properties())
                    {

                        //var test5 = itemLines.Name;
                        //var test6 = itemLines.Value;
                        DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
                        dataGridViewTextBoxColumn.Name = itemLines.Name;


                        dataGridViewGetWaitingWorksList.Columns.Add(dataGridViewTextBoxColumn);
                    }
                    break;
                }


                int rowCount = 0;
                foreach (JObject itemHeader in jArrayData.ToList())
                {

                    dataGridViewGetWaitingWorksList.Rows.Add();
                    int cellCount = 0;

                    foreach (JProperty itemLines in itemHeader.Properties())
                    {

                        //var test5 = itemLines.Name;
                        //var test6 = itemLines.Value;
                        if (itemLines.Value != null)
                        {
                            dataGridViewGetWaitingWorksList.Rows[rowCount].Cells[cellCount].Value = itemLines.Value;

                        }
                        else
                        {
                            dataGridViewGetWaitingWorksList.Rows[rowCount].Cells[cellCount].Value = "";

                        }

                        cellCount++;
                    }


                    rowCount++;
                }




                return new Result<string>(true, $"Başarılı", null);
            }
            catch (Exception exception)
            {
                return new Result<string>(false, $"{exception}", null);
            }
        }

    }
}
