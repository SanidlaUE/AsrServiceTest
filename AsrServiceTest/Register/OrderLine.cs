using AsrServiceTest.Register.IRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Register
{
    internal class OrderLine : IOrderLine
    {
        private string _serviceName;
        //public string ServiceName
        //{
        //    get { return _serviceName; }
        //    set { _serviceName = value; }
        //}
        private int _serviceCost;
        //public int ServiceCost
        //{
        //    get { return _serviceCost; }
        //    set { _serviceCost = value; }
        //}
        private int _overpaymentValue;
        //public int OverpaymentValue
        //{
        //    get { return _overpaymentValue; }
        //    set { _overpaymentValue = value; }
        //}
        public OrderLine(string serviceName, int serviceCost, int overpaymentValue)
        {
            _serviceName = serviceName;
            _serviceCost = serviceCost;
            _overpaymentValue = overpaymentValue;
        }

        public override bool Equals(object? obj)
        {
            return obj is OrderLine check &&
                   _serviceName == check._serviceName &&
                   _serviceCost == check._serviceCost &&
                   _overpaymentValue == check._overpaymentValue;
        }

        public override string ToString()
        {
            return "OrderLine:" + "\t1. Tool name: " + _serviceName + "\t2.Price of tool: " + _serviceCost + "\t3. Overpayment(optional): " + _overpaymentValue;
        }
    }
}



