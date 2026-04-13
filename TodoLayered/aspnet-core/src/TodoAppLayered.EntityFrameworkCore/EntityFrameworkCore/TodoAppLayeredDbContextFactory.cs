using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TodoAppLayered.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class TodoAppLayeredDbContextFactory : IDesignTimeDbContextFactory<TodoAppLayeredDbContext>
{
    public TodoAppLayeredDbContext CreateDbContext(string[] args)
    {
        TodoAppLayeredEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<TodoAppLayeredDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new TodoAppLayeredDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../TodoAppLayered.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
