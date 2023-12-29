using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RefreshDataAsyncSample.Data;

namespace RefreshDataAsyncSample.Data
{
    public class OrderContext : DbContext
    {
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\SyncfusionExamples\MultiSelectDropDown\refresh-data-async\multi1\RefreshDataAsyncSample\App_Data\NORTHWND.MDF;Integrated Security=True");
            }
        }
    }
 
}
