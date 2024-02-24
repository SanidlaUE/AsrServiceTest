using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Register.IRegister
{
    internal interface IPaymentData
    {
        public List<OrderLine> Mylist { get; set; }
    }
}
