using Microsoft.EntityFrameworkCore;

namespace TEMPLATE.Models
{
  public class TEMPLATEContext : DbContext
  {
    public DbSet<Template> Templatess { get; set; }
    public DbSet<TemplateTemplate> TemplateTemplates { get; set;}
    public TEMPLATEContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}