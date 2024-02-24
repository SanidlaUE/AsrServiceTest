using AsrServiceTest.Data.IData;
using AsrServiceTest.Register;
using AsrServiceTest.Register.IRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Services.IServices
{
    internal interface IConsoleOutputResService
    {
        public int ToolSelectionOutput();
        public string DiagnosOutput(ITool chosenTool);
        public string ReplaceOutput(ITool chosenTool);
        public int PaymentOutputStart(ITool chosenTool);
        public void PaymentOutputPaid(ITool chosenTool,int overpayment);
        public int PaymentOutputUnderpayment(int insufficientFunds);
        public string PrintList(IPaymentData data);
    }
}
