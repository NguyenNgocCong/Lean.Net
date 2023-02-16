using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private DBContext dbContext;
        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public DBContext DBContext { 
            get { return dbContext ??(dbContext=dbFactory.Init()); } 
        }
        public void Commit()
        {
            DBContext.SaveChanges();
        }
    }
}
