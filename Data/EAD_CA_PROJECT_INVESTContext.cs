using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EAD_CA_PROJECT_INVEST.Model;

namespace EAD_CA_PROJECT_INVEST.Data
{
    public class EAD_CA_PROJECT_INVESTContext : DbContext
    {
        public EAD_CA_PROJECT_INVESTContext (DbContextOptions<EAD_CA_PROJECT_INVESTContext> options)
            : base(options)
        {
        }

        public DbSet<EAD_CA_PROJECT_INVEST.Model.User> User { get; set; }
    }
}
