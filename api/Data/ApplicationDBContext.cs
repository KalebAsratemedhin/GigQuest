using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext: DbContext
    {

        public ApplicationDBContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Job> Jobs {get; set; }
        public DbSet<Company> Companies {get; set; }

    }
}