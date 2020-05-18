using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace fantasy_app.EntityFramework
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = @"Server = (localdb)\MSSQLLocalDB; Database = fantasy_app_Dev; Trusted_Connection = True; MultipleActiveResultSets = true";

            options.UseSqlServer(connectionString);

            return new ApplicationDbContext(options.Options);
        }
    }
}
