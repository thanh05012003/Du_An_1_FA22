using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _1.BUS.Context
{
    public class DBContext:DbContext // kế thừa lớp cha
    {
        public DBContext()
        {
            
        }

        public DBContext(DbContextOptions options) : base(options)
        {

        }

        //Ghi đè phương thức của lớp cha

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Nơi cấu hình đường dẫn
            optionsBuilder.UseSqlServer(
                @"Data Source=MSI;Initial Catalog=Bug_Coffee;Persist Security Info=True;User ID=thanhnxph20424;Password=05012003");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply cac config cho cac model
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //phương thức này áp dụng cho các config hiện có
        }
    }
}
