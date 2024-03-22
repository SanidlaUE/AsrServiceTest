using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.DAL.IRepositories
{
    internal interface IBaseRepository<TEntity>
    {       
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();        
        bool Add(TEntity entity);
        bool Remove(int id);
        bool Update(TEntity entity);
    }
}
