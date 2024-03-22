using AsrServiceTest.Services.IServices;
using AsrServiceTest.UserConsoleView;
using AsrServiceTest.UserConsoleView.IMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Services
{
    internal class Manager : IManager
    {
        private IDiagnostics _diagnostics;
        private IReplacement _replacement;       
        private ITransactionsMenu _transactionsMenu;
        public Manager(
            IDiagnostics diagnostics, 
            IReplacement replacement, 
            ITransactionsMenu transactionsMenu)
        {
            _diagnostics = diagnostics;
            _replacement = replacement;            
            _transactionsMenu = transactionsMenu;
        }
        public string ManageMain(int chosenItemMainMenu)
        {
            switch (chosenItemMainMenu)
            {
                case 1:
                    return _diagnostics.CheckState();
                case 2:
                    return _replacement.ReplaceChosenProduct();
                case 3:
                    return _transactionsMenu.OutputForTransactions();
                case 0: return "confirm exit by 0";
                default: return "Pls push 1 or 2 or 3 or 0";
            }
        }
    }
}
