using AsrServiceTest.Data.IData;
using AsrServiceTest.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Services
{
    internal class Replacement : IReplacement
    {
        private readonly IToolSelection _toolSelection;
        private readonly IConsoleOutputResService _consoleOutputResService;
        private readonly IPayment _payment;
        private readonly ISavePaymentData _savePaymentData;
        private ITool tool;
        public Replacement(IToolSelection toolSelection, IConsoleOutputResService consoleOutputResService, IPayment payment, ISavePaymentData savePaymentData)
        {
            _toolSelection = toolSelection;
            _consoleOutputResService = consoleOutputResService;
            _payment = payment;
            _savePaymentData = savePaymentData;
        }
        public string ReplaceChosenTool()
        {
            tool = _toolSelection.GetInput();
            int overpayment = _payment.Pay(tool);
            _savePaymentData.Save(tool.Name, tool.Price, overpayment);
            return _consoleOutputResService.ReplaceOutput(tool);
        }
    }
}
