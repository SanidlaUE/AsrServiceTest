using AsrServiceTest.DAL.IRepositories;
using AsrServiceTest.DAL.Repositories;
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
        private readonly IOrderLineRepository _orderLineRepository;
        public SavePaymentData(IOrderLineRepository orderLineRepository)
        {           
            _orderLineRepository = orderLineRepository;
        }
        public void Save(int id, string serviceName, int serviceCost, int overpayment)
        {            
            _orderLineRepository.Add(new OrderLine(id, serviceName, serviceCost, overpayment));
        }
    }
}
