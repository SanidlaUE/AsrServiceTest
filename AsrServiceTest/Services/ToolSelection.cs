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
    internal class ToolSelection : IToolSelection
    {
        private readonly ITool _oil;
        private readonly ITool _wheels;
        private readonly IConsoleOutputResService _consoleOutputResService;

        public ToolSelection(ITool oil, ITool wheels, IConsoleOutputResService consoleOutputResService)
        {
            _oil = oil;
            _wheels = wheels;
            _consoleOutputResService = consoleOutputResService;
        }
        private ITool chosenTool;
        public ITool ChosenTool
        {
            get { return chosenTool; }
            set { chosenTool = value; }
        }
        public ITool GetInput()
        {
            int chosenToolForCheck = _consoleOutputResService.ToolSelectionOutput();
            chosenTool = GetChosenTool(chosenToolForCheck);
            return chosenTool;
        }
        public ITool GetChosenTool(int selectionIndex)
        {
            switch (selectionIndex)
            {
                case 1: return _oil; 
                case 2: return _wheels;
                default: return null;
            }
        }
    }
}
