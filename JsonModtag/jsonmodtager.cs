using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonModtag
{
    class jsonmodtager
    {
        private readonly int PORT;


        public jsonmodtager(int _port)
        {
            this.PORT = _port;
        }


        public void start()
        {
            byte[] buffer = new byte[2048];

            using (UdpClient udpClient = new UdpClient(PORT))
            {
                IPEndPoint SenderEP = new IPEndPoint(IPAddress.Any, PORT);
                buffer = udpClient.Receive(ref SenderEP);

                string incstr = Encoding.ASCII.GetString(buffer);
                car carcopy = JsonConvert.DeserializeObject<car>(incstr);

                Console.WriteLine(carcopy.ToString());
            }

        }

    }
}
