using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MultiSelect_RefreshDataAsync.Data;

namespace MultiSelect_RefreshDataAsync.Data
{
    public class OrderContext : DbContext
    {
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\grid\blazor-datagrid-data-operations-in-wep-api-service\MultiSelect_WebAPI\App_Data\NORTHWND.MDF;Integrated Security=True");
            }
        }
    }
 
}
