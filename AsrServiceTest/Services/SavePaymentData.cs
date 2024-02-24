using AsrServiceTest.Register;
using AsrServiceTest.Register.IRegister;
using AsrServiceTest.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Services
{
    internal class SavePaymentData : ISavePaymentData
    {
        private readonly IPaymentData _paymentData;        
        public SavePaymentData(IPaymentData paymentData)
        {
            _paymentData = paymentData;           
        }
        public void Save(string serviceName, int serviceCost, int overpayment)
        {
            _paymentData.Mylist.Add(new OrderLine(serviceName, serviceCost, overpayment));
        }
    }
}
