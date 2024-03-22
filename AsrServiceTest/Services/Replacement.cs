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
        private readonly IProductSelection _productSelection;
        private readonly IConsoleOutputResService _consoleOutputResService;
        private readonly IPayment _payment;
        private readonly ISavePaymentData _savePaymentData;
        private IProduct product;
        public Replacement(
            IProductSelection productSelection, 
            IConsoleOutputResService consoleOutputResService, 
            IPayment payment, 
            ISavePaymentData savePaymentData)
        {
            _productSelection = productSelection;
            _consoleOutputResService = consoleOutputResService;
            _payment = payment;
            _savePaymentData = savePaymentData;
        }
        public string ReplaceChosenProduct()
        {
            product = _productSelection.GetInput();
            int overpayment = _payment.Pay(product);
            _savePaymentData.Save(product.Id, product.Name, product.Price, overpayment);
            return _consoleOutputResService.ReplaceOutput(product);
        }
    }
}
