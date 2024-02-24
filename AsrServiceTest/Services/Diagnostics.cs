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
        private readonly IToolSelection _toolSelection;
        private readonly IConsoleOutputResService _consoleOutputResService;
        private ITool tool;
        public Diagnostics(IToolSelection toolSelection, IConsoleOutputResService consoleOutputResService)
        {
            _toolSelection = toolSelection;
            _consoleOutputResService = consoleOutputResService;
        }
        public string CheckState()
        {
            tool = _toolSelection.GetInput();
            string outputOfOilCheckRes = _consoleOutputResService.DiagnosOutput(tool);            
            return outputOfOilCheckRes;
        }
    }
}


