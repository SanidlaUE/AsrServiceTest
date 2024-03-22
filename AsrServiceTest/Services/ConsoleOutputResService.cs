using AsrServiceTest.DAL;
using AsrServiceTest.DAL.IRepositories;
using AsrServiceTest.DAL.Repositories;
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
        public string DiagnosOutput(IProduct chosenProduct)
        {
            if (chosenProduct.State == 0)
            {
                return ((chosenProduct.Name).ToString() + " u need replace ");
            }
            if (chosenProduct.State == 1)
            {
                return ((chosenProduct.Name).ToString() + " is ok");
            }
            return "";
        }
        public int ProductSelectionOutput()
        {
            while (true)
            {
                Console.WriteLine("1 - oil,2 - wheels");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {

                }
            }
        }
        public string ReplaceOutput(IProduct chosenProduct)
        {
            return chosenProduct.Name.ToString() + " replaced";
        }
        public int PaymentOutputStart(IProduct chosenProduct)
        {
            while (true)
            {
                Console.WriteLine("u chose {0} it cost {1} pls input ur money", chosenProduct.Name, chosenProduct.Price);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch { return 0; }
            }
        }
        public void PaymentOutputPaid(IProduct chosenProduct, int overpayment)
        {
            if (overpayment > 0)
            {
                Console.WriteLine("ur overpayment : {0}", overpayment);
            }
            Console.WriteLine("{0} paid", chosenProduct.Name);
        }
        public int PaymentOutputUnderpayment(int insufficientFunds)
        {
            while (true)
            {
                Console.WriteLine("not enough {0},input more money pls", insufficientFunds);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch { return 0; }
            }
        }
        public int IdInput()
        {            
            Console.WriteLine("input id");
            try
            {
               return int.Parse(Console.ReadLine());
            }
            catch
            {
                return 0;
            }
        }
        public void IterationByList(IEnumerable<OrderLine> items)
        {
            foreach (var item in items)
            {
                StringOutput(item);
            }
        }
        public void StringOutput(OrderLine item)
        {
            Console.WriteLine($"Id: {item.Id}, ServiceName: {item.ServiceName}, ServiceCost : {item.ServiceCost}, Overpayment : {item.OverpaymentValue}");
        }
    }
}
