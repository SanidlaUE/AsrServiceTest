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
        public int Pay(ITool chosenTool)
        {
            inputCash = _consoleOutputResService.PaymentOutputStart(chosenTool);

            for (int i = chosenTool.Price; i > inputCash;)
            {
                int insufficientFunds = chosenTool.Price - inputCash;
                inputCash += _consoleOutputResService.PaymentOutputUnderpayment(insufficientFunds);
            }
            if (inputCash == chosenTool.Price)
            {
                _consoleOutputResService.PaymentOutputPaid(chosenTool, overpayment);
                return overpayment;
            }
            else
            {
                overpayment = inputCash - chosenTool.Price;
                _consoleOutputResService.PaymentOutputPaid(chosenTool, overpayment);
                return overpayment;
            }
        }

    }
}
