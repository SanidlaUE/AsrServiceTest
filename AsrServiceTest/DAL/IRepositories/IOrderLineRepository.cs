using AsrServiceTest.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.DAL.IRepositories
{
    internal interface IOrderLineRepository : IBaseRepository<OrderLine>
    {
        IEnumerable<OrderLine> GetByName(string name);
    }
}
