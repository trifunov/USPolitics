using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace USPolitics.Data.Models
{
    public class USPoliticsContext : IdentityDbContext<ApplicationUser>
    {
        public USPoliticsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Candidate> Candidates { get; set; }
    }
}
