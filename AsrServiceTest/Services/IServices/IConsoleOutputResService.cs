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
        public int ProductSelectionOutput();
        public string DiagnosOutput(IProduct chosenProduct);
        public string ReplaceOutput(IProduct chosenProduct);
        public int PaymentOutputStart(IProduct chosenProduct);
        public void PaymentOutputPaid(IProduct chosenProduct, int overpayment);
        public int PaymentOutputUnderpayment(int insufficientFunds);
        public string PrintList(IPaymentData data);
    }
}
