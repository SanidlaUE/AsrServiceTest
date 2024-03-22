using AsrServiceTest.Services.IServices;
using AsrServiceTest.UserConsoleView.IMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Services
{
    internal class TransactionsManager : ITransactionManager
    {
        private readonly ITransactionsOverview _transactionsOverview;         
        public TransactionsManager(ITransactionsOverview transactionsOverview)
        {
            _transactionsOverview = transactionsOverview;            
        }
        
        public string ManageTransactions(int chosenItemMainMenu)
        {
            switch (chosenItemMainMenu)
            {
                case 1:
                    return _transactionsOverview.PrintAllData();
                case 2:
                    return _transactionsOverview.PrintDataByName();
                case 3:
                    return _transactionsOverview.PrintDataById();
                case 4:
                    return _transactionsOverview.RemoveById();
                case 0: return "confirm exit by 0"; 
                default: return "Pls push 1 or 2 or 3 or 4";
            }
        }
    }
}
