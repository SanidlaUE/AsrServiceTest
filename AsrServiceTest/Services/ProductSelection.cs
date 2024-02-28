using AsrServiceTest.Data;
using AsrServiceTest.Data.IData;
using AsrServiceTest.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Services
{
    internal class ProductSelection : IProductSelection
    {
        private readonly IEnumerable<IProduct> _products;
        private readonly IConsoleOutputResService _consoleOutputResService;

        public ProductSelection(IEnumerable<IProduct> products, IConsoleOutputResService consoleOutputResService)
        {
            _products = products;
            _consoleOutputResService = consoleOutputResService;
        }
        private IProduct chosenProduct;

        public IProduct GetInput()
        {
            int chosenProductForCheck = _consoleOutputResService.ProductSelectionOutput();
            chosenProduct = GetChosenProduct(chosenProductForCheck);
            chosenProduct.Id = Guid.NewGuid();
            return chosenProduct;
        }
        public IProduct GetChosenProduct(int selectionIndex)
        {
            switch (selectionIndex)
            {
                case 1: return _products.FirstOrDefault(t => t is Oil);
                case 2: return _products.FirstOrDefault(t => t is Wheels);
                default: return null;
            }
        }
    }
}
