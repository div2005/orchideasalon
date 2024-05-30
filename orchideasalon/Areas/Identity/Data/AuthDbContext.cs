using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using orchideasalon.Areas.Identity.Data;
using orchideasalon.Controllers;
using orchideasalon.Models;

namespace orchideasalon.Data;

public class AuthDbContext : IdentityDbContext<User>
{
    public AuthDbContext(DbContextOptions<AuthDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
    
    public AuthDbContext()
    {
    }
    
    public DbSet<ServiceModel> Services { get; set; }
    public DbSet<RegistrationModel> Registrations { get; set; }
    public DbSet<WorkingDayModel> WorkingDays { get; set; }
    

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        new AuthDbInitializer(builder).Seed();
        builder.Entity<ServiceModel>().ToTable("Services");
        builder.Entity<RegistrationModel>().ToTable("Registrations");
        builder.Entity<WorkingDayModel>().ToTable("WorkingDays");
        
    }
}
