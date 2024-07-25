using System;

using Microsoft.EntityFrameworkCore;

using Project0.RecieptModel;

namespace Project0.Data
{
    public class EFCore : IRepository
    {
        static readonly string connectionstring = "Server=localhost;Database=MyDatabase;User=sa;Password=asw_G_08;TrustServerCertificate=true;";
        RContext context;

        public EFCore()
        {
            DbContextOptions<RContext> options;
            options = new DbContextOptionsBuilder<RContext>().UseSqlServer(connectionstring).Options;
            context = new RContext(options);
        }

        public void SaveReciept(Reciept newReciept)
        {
            context.Reciepts.Add(newReciept);
            context.SaveChanges();
        }
    }
}
