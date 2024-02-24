using AsrServiceTest.Data.IData;
using AsrServiceTest.Data;
using AsrServiceTest.Services;
using AsrServiceTest.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.UserConsoleView
{
    internal class ConsoleView : IConsoleView
    {
        private IDiagnostics _diagnostics;
        private IReplacement _replacement;
        private IPaymentOverview _paymentOverview;

        public ConsoleView(IDiagnostics diagnostics, IReplacement replacement, IPaymentOverview paymentOverview)
        {
            _diagnostics = diagnostics;
            _replacement = replacement;
            _paymentOverview = paymentOverview;
        }

        public void ConsoleInterface()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Hello,what r u want?\n");
                Console.WriteLine("1. Check");
                Console.WriteLine("2. Replace ");
                Console.WriteLine("3. Overview all transactions");
                Console.WriteLine("0. Escape");

                int chosenItemMainMenu = int.Parse(Console.ReadLine());
                string outputSelectionRes = "";

                switch (chosenItemMainMenu)
                {
                    case 1:
                        outputSelectionRes = _diagnostics.CheckState(); break;
                    case 2:
                        outputSelectionRes = _replacement.ReplaceChosenTool(); break;
                    case 3:
                        outputSelectionRes = _paymentOverview.PrintPaymentData(); break;
                    default: Console.WriteLine("Pls push 1 or 2 or 3 or 0"); break;
                }
                Console.WriteLine(outputSelectionRes);

                Console.WriteLine("Escape = 0 or some else button,for console reboot");
            }
            while ((Console.ReadLine() != "0"));
        }
    }
}
