using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JsonSend_og_modtag
{
    class JsonSender
    {
        private readonly int PORT;


        public JsonSender(int _port)
        {
            this.PORT = _port;
        }


        public void start()
        {


            //opretter bil
            car car = new car();
            car.model = "json hurtig";
            string jsonstring = JsonConvert.SerializeObject(car);

            using (UdpClient udpClient = new UdpClient())
            {
                

                byte[] buffer = Encoding.ASCII.GetBytes(jsonstring);
                IPEndPoint OtherEP = new IPEndPoint(IPAddress.Broadcast, PORT);
                udpClient.Send(buffer, buffer.Length, OtherEP);

             
            }



        }


    }
}
