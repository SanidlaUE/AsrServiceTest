using AsrServiceTest.Register.IRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Services.IServices
{
    internal interface ITransactionsOverview
    {
        public string PrintAllData();
        public string PrintDataByName();
        public string PrintDataById();
        public string RemoveById();
    }
}
