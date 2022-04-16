using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EAD_CA_PROJECT_INVEST.Model;

namespace EAD_CA_PROJECT_INVEST.Data
{
    public class INVESTContext : DbContext
    {
        public INVESTContext (DbContextOptions<INVESTContext> options)
            : base(options)
        {
        }

        public DbSet<EAD_CA_PROJECT_INVEST.Model.User> User { get; set; }
    }
}
