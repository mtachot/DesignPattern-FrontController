using FrontControllerPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontControllerPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            FrontController frontController = new FrontController();
            frontController.DispatchRequest("home");
            frontController.DispatchRequest("student");

            Console.ReadLine();
        }
    }
}
