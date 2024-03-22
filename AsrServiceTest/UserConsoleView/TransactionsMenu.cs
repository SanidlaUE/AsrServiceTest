using AsrServiceTest.Services.IServices;
using AsrServiceTest.UserConsoleView.IMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.UserConsoleView
{
    internal class TransactionsMenu : ITransactionsMenu
    {
        private readonly ITransactionManager _transactionManager;
        public TransactionsMenu(ITransactionManager transactionManager)
        {
            _transactionManager = transactionManager;
        }
        public string OutputForTransactions()
        {
            int chosenItemMainMenu = 0;
            string outputSelectionRes = "";
            do
            {
                Console.Clear();
                Console.WriteLine("1. View all");
                Console.WriteLine("2. Find by name ");
                Console.WriteLine("3. Find by ID");
                Console.WriteLine("4. Remove by ID");
                Console.WriteLine("0. Escape from transaction menu");
                try
                {
                    chosenItemMainMenu = int.Parse(Console.ReadLine());
                }
                catch
                {

                }
                outputSelectionRes = _transactionManager.ManageTransactions(chosenItemMainMenu);
                Console.WriteLine(outputSelectionRes);                
            }
            while ((Console.ReadLine() != "0"));
            return "";
        }
    }
}
