using AsrServiceTest.DAL.IRepositories;
using AsrServiceTest.DAL.Repositories;
using AsrServiceTest.Register;
using AsrServiceTest.Register.IRegister;
using AsrServiceTest.Services.IServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Services
{
    internal class TransactionsOverview : ITransactionsOverview
    {        
        private readonly IConsoleOutputResService _consoleOutputResService;  
        private readonly IOrderLineRepository _orderLineRepository;
        public TransactionsOverview(
            IConsoleOutputResService consoleOutputResService, 
            IOrderLineRepository orderLineRepository)
        {
            _consoleOutputResService = consoleOutputResService;
            _orderLineRepository = orderLineRepository;
        }
        public string PrintAllData()
        {
            var items = _orderLineRepository.GetAll();
            _consoleOutputResService.IterationByList(items);
            return "";
        }
        public string PrintDataByName()
        {
            Console.WriteLine("input name");
            string serviceName = Console.ReadLine();
            var items = _orderLineRepository.GetByName(serviceName);
            _consoleOutputResService.IterationByList(items);
            return "";
        }
        public string PrintDataById()
        {            
            var item = _orderLineRepository.GetById(_consoleOutputResService.IdInput());
            _consoleOutputResService.StringOutput(item);
            return "";
        }
        public string RemoveById()
        {           
            var item = _orderLineRepository.Remove(_consoleOutputResService.IdInput());
            return "";
        }

    }
}
