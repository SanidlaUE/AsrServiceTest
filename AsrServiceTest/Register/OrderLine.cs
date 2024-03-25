using AsrServiceTest.Register.IRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AsrServiceTest.Register
{
    internal class OrderLine : IOrderLine
    {
        private int _id;

        private string _serviceName;

        private int _serviceCost;

        private int _overpaymentValue;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string ServiceName
        {
            get { return _serviceName; }
            set { _serviceName = value; }
        }
        public int ServiceCost
        {
            get { return _serviceCost; }
            set { _serviceCost = value; }
        }
        public int OverpaymentValue
        {
            get { return _overpaymentValue; }
            set { _overpaymentValue = value; }
        }
        public OrderLine(int id, string serviceName, int serviceCost, int overpaymentValue)
        {
            _id = id;
            _serviceName = serviceName;
            _serviceCost = serviceCost;
            _overpaymentValue = overpaymentValue;
        }

        public override bool Equals(object? obj)
        {
            return obj is OrderLine check &&
              _id == check._id &&
              _serviceName == check._serviceName &&
              _serviceCost == check._serviceCost &&
              _overpaymentValue == check._overpaymentValue;
        }
        public override int GetHashCode()
        {
            return _id.GetHashCode() ^ _serviceName.GetHashCode() ^ _serviceCost.GetHashCode() ^ _overpaymentValue.GetHashCode();
        }

        public override string ToString()
        {
            return "OrderLine:" + "  " + _id + "\nTool name: " + _serviceName + "\tPrice of tool: " + _serviceCost + "\t Overpayment(optional): " + _overpaymentValue;
        }
    }
}



