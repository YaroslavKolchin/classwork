using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceUser serviceUser = new ServiceUser("https://randomuser.me/api/?results=1");
            string result = serviceUser.GetJsonString();
            Console.WriteLine(result);

        }
    }
}
