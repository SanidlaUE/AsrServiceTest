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
    internal class Diagnostics : IDiagnostics
    {
        private readonly IProductSelection _productSelection;
        private readonly IConsoleOutputResService _consoleOutputResService;
        private IProduct product;
        public Diagnostics(
            IProductSelection productSelection, 
            IConsoleOutputResService consoleOutputResService)
        {
            _productSelection = productSelection;
            _consoleOutputResService = consoleOutputResService;           
        }
        public string CheckState()
        {
            product = _productSelection.GetInput();
            string outputOfOilCheckRes = _consoleOutputResService.DiagnosOutput(product);            
            return outputOfOilCheckRes;
        }
    }
}


