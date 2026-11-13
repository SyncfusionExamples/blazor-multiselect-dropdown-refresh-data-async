using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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
                optionsBuilder.UseSqlServer($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={GetNorthwindDbPath()};Integrated Security=True");
            }
        }

        private static string GetNorthwindDbPath()
        {
            // Walk up from the executable location to locate the App_Data folder in the project's content root,
            // so the sample works from any checkout location.
            var directory = new DirectoryInfo(AppContext.BaseDirectory);
            while (directory != null && !Directory.Exists(Path.Combine(directory.FullName, "App_Data")))
            {
                directory = directory.Parent;
            }
            var appDataPath = directory == null
                ? Path.Combine(AppContext.BaseDirectory, "App_Data")
                : Path.Combine(directory.FullName, "App_Data");
            return Path.Combine(appDataPath, "NORTHWND.MDF");
        }
    }

}
