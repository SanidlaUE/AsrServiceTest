using AsrServiceTest.Register.IRegister;
using AsrServiceTest.Services.IServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Register
{
    internal class PaymentData : IPaymentData
    {
        private List<OrderLine> _myList;
        public List<OrderLine> MyList
        {
            get { return _myList; }
            set { _myList = value; }
        }
        public PaymentData()
        {
            _myList = new List<OrderLine>();
        }
    }
}