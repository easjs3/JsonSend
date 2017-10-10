using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonModtag
{
    class Program
    {
        static void Main(string[] args)
        {
            jsonmodtager jsonmodtager = new jsonmodtager(888);
            jsonmodtager.start();

            Console.ReadLine();

        }
    }
}
