using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient("127.0.0.1", 7000);
            Console.WriteLine("=========CLIENT=========");
            Console.WriteLine("Client started");

            NetworkStream ns = clientSocket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            
            sw.AutoFlush = true;

            while (true)
            {
                string message = Console.ReadLine();
                string message2 = Console.ReadLine();
                sw.WriteLine(message);
                sw.WriteLine(message2); 
                string serverAnswer = sr.ReadLine();
                Console.WriteLine("Afgiften er: " + serverAnswer);
            }
            Console.ReadLine();

            clientSocket.Close();
        }
    }
}

