using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TEMPLATE.Models
{
  public class TEMPLATEContextFactory : IDesignTimeDbContextFactory<TEMPLATEContext>
  {
    TEMPLATEContext IDesignTimeDbContextFactory<TEMPLATEContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();
      
      var builder = new DbContextOptionsBuilder<TEMPLATEContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new TEMPLATEContext(builder.Options);
    }
  }
}