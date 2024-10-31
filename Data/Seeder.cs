using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ejercicio14.Migrations;
using System.Reflection.Emit;

namespace ejercicio14.Data
{
    public static class Seeder
    {
        public static PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();


        public static void SeedingDatabase(ModelBuilder modelbuilder)
        {
            List<IdentityRole> roles = new List<IdentityRole>();
            List<IdentityUser> users = new List<IdentityUser>();
            roles.Add(new IdentityRole
            {
                Name = "admin",
                NormalizedName = "ADMIN"

            });
            roles.Add(new IdentityRole
            {
                Name = "user",
                NormalizedName = "USER"
            });


            users.Add(new IdentityUser
            {
                UserName = "admin",
                Email = "admin@correo.com",
                NormalizedEmail = "ADMIN@CORREO.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = false,
                LockoutEnabled = false,
                AccessFailedCount = 0
            });
            users.Add(new IdentityUser
            {
                UserName = "user",
                Email = "user@correo.com",
                NormalizedEmail = "USER@CORREO.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = false,
                LockoutEnabled = false,
                AccessFailedCount = 0
            });

            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "A123456.");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "A123456.");
            modelbuilder.Entity<IdentityUser>().HasData(
                    users[0],
                    users[1]
                );

            modelbuilder.Entity<IdentityRole>().HasData(
                    roles[0],
                    roles[1]
                );
            modelbuilder.Entity<IdentityUserRole<string>>().HasData(
                   new IdentityUserRole<string>
                   {
                       UserId = users[0].Id,
                       RoleId = roles[0].Id
                   },
                   new IdentityUserRole<string>
                   {
                       UserId = users[1].Id,
                       RoleId = roles[1].Id
                   }
               );
        }
    }
}
