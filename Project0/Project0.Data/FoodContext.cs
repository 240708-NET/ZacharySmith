using System;
using Microsoft.EntityFrameworkCore;
using Project0.Food;
using Project0.App;

namespace Project0.Data
{
    public class FoodContext : DbContext
    {
        public DbSet<Foods> foods => Set<Foods>();
    }
}