using AsrServiceTest.Data.IData;
using AsrServiceTest.Register;
using AsrServiceTest.Register.IRegister;
using AsrServiceTest.Services.IServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Services
{
    internal class ConsoleOutputResService : IConsoleOutputResService
    {
        public string DiagnosOutput(ITool chosenTool)
        {
            if (chosenTool.State == 0)
            {
                return ((chosenTool.Name).ToString() + " u need replace ");
            }
            if (chosenTool.State == 1)
            {
                return ((chosenTool.Name).ToString() + " is ok");
            }
            return "";
        }
        public int ToolSelectionOutput()
        {
            Console.WriteLine("1 - oil,2 - wheels");
            return int.Parse(Console.ReadLine());
        }
        public string ReplaceOutput(ITool chosenTool)
        {
            return chosenTool.Name.ToString() + " replaced";
        }
        public int PaymentOutputStart(ITool chosenTool)
        {
            Console.WriteLine("u chose {0} it cost {1} pls input ur money", chosenTool.Name, chosenTool.Price);
            return int.Parse(Console.ReadLine());
        }
        public void PaymentOutputPaid(ITool chosenTool, int overpayment)
        {
            if (overpayment > 0)
            {
                Console.WriteLine("ur overpayment : {0}", overpayment);
            }
            Console.WriteLine("{0} paid", chosenTool.Name);
        }
        public int PaymentOutputUnderpayment(int insufficientFunds)
        {
            Console.WriteLine("not enough {0},input more money pls", insufficientFunds);
            return int.Parse(Console.ReadLine());
        }
        public string PrintList(IPaymentData data)
        {
            if (data.Mylist.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.WriteLine("List of cash receipts :");
                foreach (OrderLine check in data.Mylist)
                {
                    Console.WriteLine("" + check);
                }
            }
            return "";
        }
    }
}
