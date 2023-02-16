using System;

namespace Shop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        DBContext Init();
    }
}