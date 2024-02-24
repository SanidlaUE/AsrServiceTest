using AsrServiceTest.Data.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Services.IServices
{
    internal interface IToolSelection
    {
        public ITool GetChosenTool(int selectionIndex);
        public ITool GetInput();
    }
}
