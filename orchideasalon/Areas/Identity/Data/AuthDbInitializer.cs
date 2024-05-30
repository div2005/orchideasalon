using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using orchideasalon.Data;
using orchideasalon.Models;

namespace orchideasalon.Areas.Identity.Data;

public class AuthDbInitializer
{
    private readonly ModelBuilder modelBuilder;

    public AuthDbInitializer(ModelBuilder modelBuilder)
    {
        this.modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        var roles = new IdentityRole[]
        {
            new() { Id = Guid.NewGuid().ToString(), Name = "admin", NormalizedName = "ADMIN" }, 
            new() { Id = Guid.NewGuid().ToString(), Name = "manager", NormalizedName = "MANAGER" },
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
                Id = 1, Name = "Манікюр", Description = "Класичний", Price = 300, Duration = 30,
                Image = "https://www.amberbeautysalon.ae/cdn/shop/products/FrenchM_Image4.png"
            },
            new()
            {
                Id = 2, Name = "Стрижка жіноча", Description = "+ укладка", Price = 600, Duration = 30,
                Image = "https://images.prom.ua/3804692702_w600_h600_3804692702.jpg"
            },
            new()
            {
                Id = 3, Name = "SPA", Description = "+ масаж", Price = 750, Duration = 30,
                Image =
                    "https://2.bp.blogspot.com/-2W_7I7x0dlo/UglH9g6i9rI/AAAAAAAABHc/86PYR0EBYrU/s1600/shutterstock_114182782.jpg"
            }
        };

        modelBuilder.Entity<ServiceModel>().HasData(services);

        var wDay = new WorkingDayModel[]
        {
            new()
            {
                Id = 1, Date = new DateOnly(2024, 6, 30), 
                BeginTime = new TimeOnly(10, 0), EndTime = new TimeOnly(18, 0)
            },
            new()
            {
                Id = 2, Date = new DateOnly(2024, 1, 2), 
                BeginTime = new TimeOnly(11, 30), EndTime = new TimeOnly(15, 0)
            },
            new()
            {
                Id = 3, Date = new DateOnly(2023, 10, 25), 
                BeginTime = new TimeOnly(9, 0), EndTime = new TimeOnly(18, 0)
            },
            new()
            {
                Id = 4, Date = new DateOnly(2023, 12, 3), 
                BeginTime = new TimeOnly(9, 0), EndTime = new TimeOnly(18, 0)
            },
            new()
            {
                Id = 5, Date = new DateOnly(2024, 6, 29), 
                BeginTime = new TimeOnly(9, 0), EndTime = new TimeOnly(18, 0)
            },
        };
        
        modelBuilder.Entity<WorkingDayModel>().HasData(wDay);

        var regs = new RegistrationModel[]
        {
            new()
            {
                Id = Guid.NewGuid(),
                ServiceId = services[0].Id,
                DayId = wDay[0].Id,
                FirstName = "Соломія", Phone = "0893943003", Time = new TimeOnly(16, 30),
            },
            new()
            {
                Id = Guid.NewGuid(),
                ServiceId = services[1].Id,
                DayId = wDay[1].Id,
                FirstName = "Орися", Phone = "0893943003", Time = new TimeOnly(12, 00),
            },
            new()
            {
                Id = Guid.NewGuid(),
                ServiceId = services[2].Id,
                DayId = wDay[2].Id,
                FirstName = "Леся", Phone = "0743957294", Time = new TimeOnly(9, 30),
            },
            new()
            {
                Id = Guid.NewGuid(),
                ServiceId = services[2].Id,
                DayId = wDay[3].Id,
                FirstName = "Галина", Phone = "0930943903", Time = new TimeOnly(18, 30),
            },
            new()
            {
                Id = Guid.NewGuid(),
                ServiceId = services[1].Id,
                DayId = wDay[4].Id,
                FirstName = "Катерина", Phone = "0645748392", Time = new TimeOnly(14, 30),
            },
            new()
            {
                Id = Guid.NewGuid(),
                ServiceId = services[2].Id,
                DayId = wDay[2].Id,
                FirstName = "Соломія", Phone = "0545748392", Time = new TimeOnly(13, 30),
            },
        };
        
        modelBuilder.Entity<RegistrationModel>().HasData(regs);
    }
}