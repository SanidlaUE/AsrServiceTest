using AsrServiceTest.Data.IData;
using AsrServiceTest.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Services
{
    internal class Payment : IPayment
    {
        private readonly IConsoleOutputResService _consoleOutputResService;
        public Payment(IConsoleOutputResService consoleOutputResService)
        {
            _consoleOutputResService = consoleOutputResService;
        }
        private int inputCash;
        private int overpayment;
        public int Pay(IProduct chosenProduct)
        {
            inputCash = _consoleOutputResService.PaymentOutputStart(chosenProduct);

            for (int i = chosenProduct.Price; i > inputCash;)
            {
                int insufficientFunds = chosenProduct.Price - inputCash;
                inputCash += _consoleOutputResService.PaymentOutputUnderpayment(insufficientFunds);
            }
            if (inputCash == chosenProduct.Price)
            {
                _consoleOutputResService.PaymentOutputPaid(chosenProduct, overpayment);
                return overpayment;
            }
            else
            {
                overpayment = inputCash - chosenProduct.Price;
                _consoleOutputResService.PaymentOutputPaid(chosenProduct, overpayment);
                return overpayment;
            }
        }

    }
}
