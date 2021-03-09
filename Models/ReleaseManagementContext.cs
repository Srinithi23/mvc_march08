 using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvc_demo.Models
{
    public class ReleaseManagementContext : DbContext
    {
        public ReleaseManagementContext(): base("conRM")
        {

        }
        public DbSet<Employee> employee { get; set; }
        public DbSet<LoginDetails> loginDetails { get; set; }
    }
}