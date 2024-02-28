using AsrServiceTest.Data.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Services.IServices
{
    internal interface IPayment
    {        
        public int Pay(IProduct hosenProduct);
    }
}
