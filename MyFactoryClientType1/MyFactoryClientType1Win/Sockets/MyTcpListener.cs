using MyFactoryClientType1;
using MyFactoryClientType1.Business;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace MyFactoryClientType1.Sockets
{
    public class MyTcpListener
    {
        public static void Listen()
        {
            TextBox textBoxListen = Application.OpenForms["FormMyFactoryClientType1"].Controls["textBoxListen"] as TextBox;

            TcpListener server = null;
            try
            {
                TextBox textBoxMyIp = Application.OpenForms["FormMyFactoryClientType1"].Controls["textBoxMyIp"] as TextBox;               

                TextBox textBoxMyPort = Application.OpenForms["FormMyFactoryClientType1"].Controls["textBoxMyPort"] as TextBox;

                string myIp = textBoxMyIp.Text.Trim();
                // Set the TcpListener on port 13000.
                Int32 port = int.Parse(textBoxMyPort.Text.Trim()); //14000;
                IPAddress localAddr = IPAddress.Parse(myIp);

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[1024];
                String data = null;

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    textBoxListen.Invoke((Action)delegate
                    {
                        textBoxListen.AppendText($"Waiting for a connection...{Environment.NewLine}");
                    });

                    // Perform a blocking call to accept requests.
                    // You could also use server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    textBoxListen.Invoke((Action)delegate
                    {
                        textBoxListen.AppendText($"Connected{Environment.NewLine}");
                    });

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", data);

                        textBoxListen.Invoke((Action)delegate
                        {
                            textBoxListen.AppendText($"Received:{Environment.NewLine}{data}{Environment.NewLine}");
                        });

                        MachineProcessService machineProcessService = new MachineProcessService();
                        var result = machineProcessService.MachinerModelProcess(data);

                        data = result.Data;
                        // Process the data sent by the client.
                        data = data.ToUpper();

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        // Send back a response.
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Sent: {0}", data);

                        textBoxListen.Invoke((Action)delegate
                        {
                            textBoxListen.AppendText($"Sent:{Environment.NewLine}{data}{Environment.NewLine}");
                        });

                    }

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);

                textBoxListen.Invoke((Action)delegate
                {
                    textBoxListen.AppendText($"SocketException:{Environment.NewLine}{e}{Environment.NewLine}");
                });

            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

            //Console.WriteLine("\nHit enter to continue...");


            //Console.Read();
        }


    }
}





