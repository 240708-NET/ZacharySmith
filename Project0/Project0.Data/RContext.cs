using System;
using Microsoft.EntityFrameworkCore;
using Project0.RecieptModel;

namespace Project0.Data
{
    public class RContext : DbContext
    {
        public DbSet<Reciept> Reciepts => Set<Reciept>();
        public RContext(){}

        public RContext(DbContextOptions options) : base(options){}
        public RContext(DbContextOptions<RContext> options) : base(options){}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string ConnectionString = File.ReadAllText("./..connectionstring");
            optionsBuilder.UseSqlServer("");
        }
        
    }
}