using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeslandShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShoeslandShopDbContext dbContext;

        public ShoeslandShopDbContext Init()
        {
            return dbContext ?? (dbContext = new ShoeslandShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
