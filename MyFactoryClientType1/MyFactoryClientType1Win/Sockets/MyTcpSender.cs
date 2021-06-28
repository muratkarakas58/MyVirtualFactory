using MyFactoryClientType1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFactoryClientType1.Sockets
{
    public class MyTcpSender
    {
        public static Result<string> Connect(String server, String message, int portAdress)
        {
            TextBox textBoxSender = Application.OpenForms["FormMyFactoryClientType1"].Controls["textBoxSender"] as TextBox;

            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer
                // connected to the same address as specified by the server, port
                // combination.
                Int32 port = portAdress;
                TcpClient client = new TcpClient(server, port);

                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();

                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer.
                stream.Write(data, 0, data.Length);

                Console.WriteLine("Sent: {0}", message);

                textBoxSender.AppendText($"Sent:{Environment.NewLine}{message}{Environment.NewLine}");

                // Receive the TcpServer.response.

                // Buffer to store the response bytes.
                data = new Byte[1024];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                Console.WriteLine("Received: {0}", responseData);

                textBoxSender.AppendText($"Received:{Environment.NewLine} {responseData}{Environment.NewLine}");

                // Close everything.
                stream.Close();
                client.Close();


                return new Result<string>(true, $"Başarılı", responseData);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine("ArgumentNullException: {0}", exception);
                textBoxSender.AppendText($"ArgumentNullException:{Environment.NewLine} {exception}{Environment.NewLine}");

                return new Result<string>(false, $"{exception}", null);
            }
            catch (SocketException exception)
            {
                Console.WriteLine("SocketException: {0}", exception);
                textBoxSender.AppendText($"SocketException:{Environment.NewLine} {exception}{Environment.NewLine}");

                return new Result<string>(false, $"{exception}", null);
            }
            finally
            {

            }

            //Console.WriteLine("\n Press Enter to continue...");
            // Console.Read();
        }
    }
}
