using MyFactoryServer.Business;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace MyFactoryServer.Sockets
{
    public class MyTcpListener
    {
        public static void Listen() 
        {

            TextBox textBoxListen = Application.OpenForms["FormMyFactoryServer"].Controls["textBoxListen"] as TextBox;


            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 13000.
                Int32 port = 13000;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[1024];
                String data = null;
                string inputData = null;                

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");
                    
                    textBoxListen.Invoke((Action)delegate
                    {
                        textBoxListen.AppendText( $"Waiting for a connection...{Environment.NewLine}");
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
                    
                    inputData = null;
                    

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;
                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        inputData = System.Text.Encoding.ASCII.GetString(bytes, 0, i);                        
                        Console.WriteLine("Received: {0}", inputData);

                        textBoxListen.Invoke((Action)delegate
                        {
                            textBoxListen.AppendText($"Received:{Environment.NewLine}{inputData}{Environment.NewLine}");
                        });

                        ServerProcessService serverProcessService = new ServerProcessService();
                        var result = serverProcessService.ServerModelProcess(inputData);


                        // Process the data sent by the client.
                        //data = data.ToUpper();
                        //string tempString = result.Data.Replace("\n", "").Replace("\r", "").Replace("]\"","]");
                        result.Data = result.Data.Replace("]\"", "]").Replace("\"[", "[");

                        byte[] outputDataByte = System.Text.Encoding.ASCII.GetBytes(result.Data);

                        // Send back a response.
                        stream.Write(outputDataByte, 0, outputDataByte.Length);
                        Console.WriteLine("Sent: {0}", result.Data);
                        
                        textBoxListen.Invoke((Action)delegate
                        {
                            textBoxListen.AppendText($"Sent:{Environment.NewLine}{result.Data}{Environment.NewLine}");
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

            // Console.Read();
        }


    }
}





