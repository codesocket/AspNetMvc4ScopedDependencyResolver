using System;

namespace AspNetMvc4ScopedDependencyResolver.Services
{
    public interface IDbContext
    {

    }

    public class DbContext : IDbContext, IDisposable
    {
        public DbContext()
        {
            this.InstanceId = Guid.NewGuid();
        }

        public void Dispose()
        {

        }

        public Guid InstanceId { get; private set; }
    }
}