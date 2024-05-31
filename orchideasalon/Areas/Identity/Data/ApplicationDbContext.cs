using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using orchideasalon.Areas.Identity.Data;
using orchideasalon.Models;

namespace orchideasalon.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
    
    public ApplicationDbContext()
    {
    }
    
    public DbSet<ServiceModel> Services { get; set; }
    public DbSet<RegistrationModel> Registrations { get; set; }
    

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        new ApplicationDbInitializer(builder).Seed();
        
        builder.Entity<ServiceModel>().ToTable("Services");
        
        builder.Entity<RegistrationModel>()
            .ToTable("Registrations")
            .HasOne(r => r.Service)
            .WithMany()
            .HasForeignKey(r => r.ServiceId)
            .IsRequired(false);
        
    }
}
