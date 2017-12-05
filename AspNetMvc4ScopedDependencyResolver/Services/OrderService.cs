using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvc4ScopedDependencyResolver.Services
{
    public interface IOrderService
    {
    }

    public class OrderService : IOrderService
    {
        public OrderService(IDbContext context)
        {

        }
    }
}