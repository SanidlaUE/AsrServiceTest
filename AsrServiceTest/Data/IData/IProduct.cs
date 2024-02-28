using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Data.IData
{
    internal interface IProduct
    {
        Guid Id { get; set; }
        string Name { get; }
        int Price { get; }
        int State { get; }
    }
}
