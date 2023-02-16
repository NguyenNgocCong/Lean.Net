using Shop.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBContext :DbContext
    {
        public DBContext() : base("ShopConnection")
        {
            this.Configuration.LazyLoadingEnabled= false;
        }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuGroup> MenuGroup { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Pages> Pages { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PostCategories> PostCategories { get; set; }
        public DbSet<PostTags> PostTags { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductTags> ProductTags { get; set; }
        public DbSet<SupportOnline> SupportOnline { get; set; }
        public DbSet<SystemConfig> SystemConfig { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<VisitorStatistics> VisitorStatistics { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
           
        }

    }
}
