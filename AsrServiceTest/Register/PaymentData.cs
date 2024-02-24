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
        private List<OrderLine> myList;
        public List<OrderLine> Mylist
        {
            get { return myList; }
            set { myList = value; }
        }
        public PaymentData()
        {
            myList = new List<OrderLine>();
        }
    }
}