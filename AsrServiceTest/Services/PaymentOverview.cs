using AsrServiceTest.Register;
using AsrServiceTest.Register.IRegister;
using AsrServiceTest.Services.IServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Services
{
    internal class PaymentOverview : IPaymentOverview
    {
        private readonly IPaymentData _paymentData;
        private readonly IConsoleOutputResService _consoleOutputResService;       
        public PaymentOverview(IPaymentData paymentData, IConsoleOutputResService consoleOutputResService)
        {
            _paymentData = paymentData;
            _consoleOutputResService = consoleOutputResService;
        }
        public string PrintPaymentData()
        {
            _consoleOutputResService.PrintList(_paymentData);            
            return "";
        }
    }
}
