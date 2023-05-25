using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
namespace ConsoleApp1_PİNG_SENDER_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ping ping = new Ping();
            Console.WriteLine("IP Adresi Girin:");
            PingReply reply = ping.Send(Console.ReadLine());
            Console.WriteLine(reply.Status.ToString());
            Console.ReadKey();

        }
    }
}
