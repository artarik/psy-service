using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace auth.Models
{
    // В профиль пользователя можно добавить дополнительные данные, если указать больше свойств для класса ApplicationUser. Подробности см. на странице https://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public string Position { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
    }


    public class Service
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название услуги")]
        [StringLength(100, ErrorMessage = "Минимальная длина {0} должна быть больше {2}", MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Минимальная длина {0} должна быть больше {2}", MinimumLength = 3)]
        [Display(Name = "Категория услуги")]
        public string ServiceType { get; set; }
        [Required]
        [RegularExpression(@"[0-9]{4}", ErrorMessage ="Введите стоимость в пределах 1000-9999")]
        [Display(Name = "Стоимость услуги")]
        public int Price { get; set; }
    }



    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Service> Services { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}