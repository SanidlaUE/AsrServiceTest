using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Services.IServices
{
    internal interface ITransactionManager
    {
        public string ManageTransactions(int chosenItemMainMenu);
    }
}
