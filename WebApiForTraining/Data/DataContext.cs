using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiForTraining.Model;

namespace WebApiForTraining.Data
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext>opt):base(opt)
        {
        }
      

        public DbSet<User> USERDB1 { get; set; }
    }
}
