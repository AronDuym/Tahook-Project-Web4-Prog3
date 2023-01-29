using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahook.Infrastructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("C:\\Users\\gebruiker\\Desktop\\Tahook\\Tahook\\TahookInfrastructure\\appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();

            TahookContext dbContext = new TahookContext(new DbContextOptions<TahookContext>(), configuration);

            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            new TahookDataInitialiser(dbContext).InitializeData();
            Console.WriteLine("Database completed");

        }
    }
}
