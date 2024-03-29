﻿using AsrServiceTest.DAL.IRepositories;
using AsrServiceTest.Register;
using AsrServiceTest.Register.IRegister;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.DAL.Repositories
{
    internal class OrderLineRepository : IOrderLineRepository
    {
        private readonly AppDbContext _appDbContext;
        public OrderLineRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public OrderLine GetById(int id)
        {
            return _appDbContext.OrderLines.FirstOrDefault(n => n.Id == id);
        }

        public IQueryable<OrderLine> GetAll()
        {
            return _appDbContext.OrderLines;
        }

        public IEnumerable<OrderLine> GetByName(string name)
        {
            return _appDbContext.OrderLines.Where(n => n.ServiceName == name);
        }
        public bool Add(OrderLine entity)
        {
            try
            {
                _appDbContext.OrderLines.Add(entity);
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(OrderLine entity)
        {
            try
            {
                var existingService = _appDbContext.OrderLines.Find(entity.Id);
                if (existingService == null)
                    return false;

                existingService.ServiceName = entity.ServiceName;
                existingService.ServiceCost = entity.ServiceCost;
                existingService.OverpaymentValue = entity.OverpaymentValue;

                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Remove(int id)
        {
            var service = GetById(id);
            if (service == null) return false;

            _appDbContext.Remove(service);
            _appDbContext.SaveChanges();
            return true;
        }

    }
}
