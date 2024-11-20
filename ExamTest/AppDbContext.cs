using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;
using ExamTest.Models;

namespace ExamTest{
     
    public class AppDbContext:DbContext
    {
        public AppDbContext() : base(ConfigurationManager.AppSettings["ConnectionString"])
        {
            
        }

        public DbSet<Test> Tests { get; set; }
    }
}
