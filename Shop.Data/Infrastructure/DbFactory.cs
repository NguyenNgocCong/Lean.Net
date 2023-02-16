using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Infrastructure
{
    class DbFactory : Disposeable, IDbFactory
    {
        private DBContext dbContext;
        public DBContext Init()
        {
            return dbContext ?? (dbContext = new DBContext());
        }
        protected override void DisposeCore()
        {
            if(dbContext != null) dbContext.Dispose();
        }
    }
}
