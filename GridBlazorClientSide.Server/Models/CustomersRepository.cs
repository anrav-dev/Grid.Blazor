﻿using GridBlazorClientSide.Shared.Models;
using System.Linq;

namespace GridBlazorClientSide.Server.Models
{
    public class CustomersRepository : SqlRepository<Customer>
    {
        public CustomersRepository(NorthwindDbContext context)
            : base(context)
        {
        }

        public override IQueryable<Customer> GetAll()
        {
            return EfDbSet;
        }

        public override Customer GetById(object id)
        {
            return GetAll().FirstOrDefault(c => c.CustomerID == (string)id);
        }
    }
}