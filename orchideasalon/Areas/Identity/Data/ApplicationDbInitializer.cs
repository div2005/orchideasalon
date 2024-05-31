using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using orchideasalon.Constants;
using orchideasalon.Models;

namespace orchideasalon.Areas.Identity.Data;

public class ApplicationDbInitializer
{
    private readonly ModelBuilder modelBuilder;

    public ApplicationDbInitializer(ModelBuilder modelBuilder)
    {
        this.modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        var roles = new IdentityRole[]
        {
            new() { Id = Guid.NewGuid().ToString(), Name = AuthorizationConstants.Roles.Admin, NormalizedName = AuthorizationConstants.Roles.Admin }, 
            new() { Id = Guid.NewGuid().ToString(), Name = AuthorizationConstants.Roles.Manager, NormalizedName = AuthorizationConstants.Roles.Manager },
        };
        
        modelBuilder.Entity<IdentityRole>().HasData(roles);
        
        var hasher = new PasswordHasher<User>();
        var admin = new User
        {
            Id = Guid.NewGuid().ToString(), 
            UserName = "admin@admin.com",
            NormalizedUserName = "ADMIN@ADMIN.COM",
            Email = "admin@admin.com",
            NormalizedEmail = "ADMIN@ADMIN.COM",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true
        };

        admin.PasswordHash = hasher.HashPassword(admin, "Admin_123");

        modelBuilder.Entity<User>().HasData(admin);

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = roles[0].Id,
                UserId = admin.Id
            });

        var services = new ServiceModel[]
        {
            new()
            {
                Id = 1, Name = "Манікюр", Description = "Класичний", Price = 300,
            },
            new()
            {
                Id = 2, Name = "Стрижка жіноча", Description = "+ укладка", Price = 600,
            },
            new()
            {
                Id = 3, Name = "SPA", Description = "+ масаж", Price = 750,
            }
        };
        
        modelBuilder.Entity<ServiceModel>().HasData(services);

        var regs = new RegistrationModel[]
        {
            new()
            {
                Id = Guid.NewGuid(),
                ServiceId = services[0].Id,
                Date = new DateTime(2024, 6, 30, 16, 30, 0),
                FirstName = "Соломія", Phone = "0893943003", Notes = "Червоний манікюр", Approved = true
            },
            new()
            {
                Id = Guid.NewGuid(),
                ServiceId = services[1].Id,
                Date = new DateTime(2024, 2, 1, 12, 00, 0),
                FirstName = "Орися", Phone = "0893943003", Approved = true
            },
            new()
            {
                Id = Guid.NewGuid(),
                ServiceId = services[2].Id,
                Date = new DateTime(2024, 2, 1, 13, 45, 0),
                FirstName = "Леся", Phone = "0743957294", Approved = true
            },
            new()
            {
                Id = Guid.NewGuid(),
                ServiceId = services[2].Id,
                Date = new DateTime(2024, 6, 30, 11, 45, 0),
                FirstName = "Галина", Phone = "0930943903", Approved = true
            },
            new()
            {
                Id = Guid.NewGuid(),
                ServiceId = services[1].Id,
                Date = new DateTime(2024, 5, 25, 12, 40, 0),
                FirstName = "Катерина", Phone = "0645748392", Approved = true
            },
            new()
            {
                Id = Guid.NewGuid(),
                ServiceId = services[2].Id,
                Date = new DateTime(2023, 12, 27, 18, 30, 0),
                FirstName = "Соломія", Phone = "0735748392", Approved = true
            },
            new()
            {
                Id = Guid.NewGuid(), FirstName = "Антоніна", Phone = "0453243545"
            },
            new()
            {
                Id = Guid.NewGuid(), FirstName = "Соломія", Phone = "0735748392"
            },
            new()
            {
                Id = Guid.NewGuid(), FirstName = "Тетяна", Phone = "0973932904"
            }
        };
        
        modelBuilder.Entity<RegistrationModel>().HasData(regs);
    }
}