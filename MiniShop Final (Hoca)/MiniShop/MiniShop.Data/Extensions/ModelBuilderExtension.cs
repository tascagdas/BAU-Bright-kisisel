using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MiniShop.Entity.Concrete;
using MiniShop.Entity.Concrete.Identity;

namespace MiniShop.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            #region Rol Bilgileri

            List<Role> roles = new List<Role>
            {
                new Role{Name="SuperAdmin", Description="Süper Yönetici haklarını taşıyan rol", NormalizedName="SUPERADMIN"},
                new Role{Name="Admin", Description="Yönetici haklarını taşıyan rol", NormalizedName="ADMIN"},
                new Role{Name="Customer", Description="Müşteri haklarını taşıyan rol", NormalizedName="CUSTOMER"}
            };
            modelBuilder.Entity<Role>().HasData(roles);

            #endregion

            #region Kullanıcı Bilgileri

            List<User> users = new List<User>
            {
                new User
                {
                    FirstName="Deniz",
                    LastName="Foça",
                    UserName="denizfoca",
                    NormalizedUserName="DENIZFOCA",
                    Email="denizfoca@gmail.com",
                    NormalizedEmail="DENIZFOCA@GMAIL.COM",
                    Gender="Erkek",
                    DateOfBirth=new DateTime(1990,5,12),
                    Address="Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar",
                    City="İstanbul",
                    PhoneNumber="5558779966",
                    EmailConfirmed=true
                },
                new User
                {
                    FirstName="Selin",
                    LastName="Mete",
                    UserName="selinmete",
                    NormalizedUserName="SELINMETE",
                    Email="selinmete@gmail.com",
                    NormalizedEmail="SELINMETE@GMAIL.COM",
                    Gender="Kadın",
                    DateOfBirth=new DateTime(1993,7,16),
                    Address="Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar",
                    City="İstanbul",
                    PhoneNumber="5387996655",
                    EmailConfirmed=true
                },
                new User
                {
                    FirstName="Kemal",
                    LastName="Durukan",
                    UserName="kemaldurukan",
                    NormalizedUserName="KEMALDURUKAN",
                    Email="kemaldurukan@gmail.com",
                    NormalizedEmail="KEMALDURUKAN@GMAIL.COM",
                    Gender="Erkek",
                    DateOfBirth=new DateTime(1993,7,16),
                    Address="Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar",
                    City="İstanbul",
                    PhoneNumber="5387996655",
                    EmailConfirmed=true
                },
                new User
                {
                    FirstName="Ayşen Umay",
                    LastName="Ergül",
                    UserName="aysenumay",
                    NormalizedUserName="AYSENUMAY",
                    Email="aysenumay@gmail.com",
                    NormalizedEmail="AYSENUMAY@GMAIL.COM",
                    Gender="Kadın",
                    DateOfBirth=new DateTime(1993,7,16),
                    Address="Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar",
                    City="İstanbul",
                    PhoneNumber="5387996655",
                    EmailConfirmed=true
                }
            };

            modelBuilder.Entity<User>().HasData(users);
            #endregion

            #region Şifre İşlemleri

            var passwordHasher = new PasswordHasher<User>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Qwe123.");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            users[2].PasswordHash = passwordHasher.HashPassword(users[2], "Qwe123.");
            users[3].PasswordHash = passwordHasher.HashPassword(users[3], "Qwe123.");

            #endregion

            #region Rol Atama İşlemleri
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                     UserId=users[0].Id,
                     RoleId=roles[0].Id
                     //RoleId=roles.Where(x=>x.Name=="Admin").FirstOrDefault().Id,
                },
                new IdentityUserRole<string>
                {
                    UserId=users[1].Id,
                    RoleId=roles[1].Id
                }
                ,
                new IdentityUserRole<string>
                {
                    UserId=users[2].Id,
                    RoleId=roles[1].Id
                },
                new IdentityUserRole<string>
                {
                    UserId=users[3].Id,
                    RoleId=roles[2].Id
                }
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion

            #region Alışveriş Sepeti İşlemleri

            List<ShoppingCart> shoppingCarts = new List<ShoppingCart>
            {
                new ShoppingCart{ Id=1, UserId=users[0].Id } ,
                new ShoppingCart{ Id=2, UserId=users[1].Id } ,
                new ShoppingCart{ Id=3, UserId=users[2].Id } ,
                new ShoppingCart{ Id=4, UserId=users[3].Id }
            };
            modelBuilder.Entity<ShoppingCart>().HasData(shoppingCarts);

            #endregion
        }
    }
}
