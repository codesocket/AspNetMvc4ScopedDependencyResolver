using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvc4ScopedDependencyResolver.Services
{
    public interface IProductService
    {

    }

    public class ProductService : IProductService, IDisposable
    {
        public void Dispose()
        {

        }
    }
}