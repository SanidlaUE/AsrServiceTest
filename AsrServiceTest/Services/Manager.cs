using AsrServiceTest.Services.IServices;
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
        private IPaymentOverview _paymentOverview;
        public Manager(IDiagnostics diagnostics, IReplacement replacement, IPaymentOverview paymentOverview)
        {
            _diagnostics = diagnostics;
            _replacement = replacement;
            _paymentOverview = paymentOverview;
        }
        public string Manage(int chosenItemMainMenu)
        {
            switch (chosenItemMainMenu)
            {
                case 1:
                    return _diagnostics.CheckState(); break;
                case 2:
                    return _replacement.ReplaceChosenProduct(); break;
                case 3:
                    return _paymentOverview.PrintPaymentData(); break;
                default: return "Pls push 1 or 2 or 3 or 0"; break;
            }
        }
    }
}
