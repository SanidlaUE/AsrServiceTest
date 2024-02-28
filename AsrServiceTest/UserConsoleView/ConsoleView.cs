using AsrServiceTest.Data.IData;
using AsrServiceTest.Data;
using AsrServiceTest.Services;
using AsrServiceTest.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AsrServiceTest.UserConsoleView
{
    internal class ConsoleView : IConsoleView
    {
        private IManager _manager;
        public ConsoleView(IManager manager)
        {
            _manager = manager;
        }
        public void ConsoleInterface()
        {
            int chosenItemMainMenu = 0;
            string outputSelectionRes = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Hello,what r u want?\n");
                Console.WriteLine("1. Check");
                Console.WriteLine("2. Replace ");
                Console.WriteLine("3. Overview all transactions");
                Console.WriteLine("0. Escape");
                try
                {
                    chosenItemMainMenu = int.Parse(Console.ReadLine());
                }
                catch
                {

                }
                outputSelectionRes = _manager.Manage(chosenItemMainMenu);
                Console.WriteLine(outputSelectionRes);
                Console.WriteLine("Escape = 0 or some else button,for console reboot");
            }
            while ((Console.ReadLine() != "0"));
        }
    }
}
