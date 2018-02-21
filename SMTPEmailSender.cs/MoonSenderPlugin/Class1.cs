using IndieGoat.UniversalServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MoonSenderPlugin
{
    public class MoonSender : IServerPlugin
    {
        public string Name
        {
            get
            {
                return "Moonsender";
            }
        }

        public void onLoad(string ServerDirectory)
        {

        }

        public void Invoke(TcpListener _serverSocket, TcpClient _clientSocket, int port, List<string> Args, string ServerDirectory)
        {
            
        }

        /// <summary>
        /// Sends a message to the client
        /// </summary>
        /// <param name="client">TCP client to send the value to</param>
        /// <param name="value">String of text</param>
        private void SendMessage(TcpClient client, string value)
        {
            //Sends a string to a client using UTF8
            client.Client.Send(Encoding.UTF8.GetBytes(value));
        }
    }
}
