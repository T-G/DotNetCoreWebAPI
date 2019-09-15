using Microsoft.EntityFrameworkCore;
using System;

namespace OrgDAL
{
    public class OrganizationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=THINKPADX220\SQLEXPRESS;Database=OrgAPIDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
