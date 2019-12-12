using EShop41.ApplicationCore.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop41.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
//EShop41.web in içindeki data=> applicationdbcontext i kopyaladık burdaki oluşturduğumuz class'ı silip applicationdbcontext'in clasını buraya kopyaladık yapıştırdık.

// altı cizili öğeler vardı bunun için install-package yaptık install-package microsoft.entityframeworkcore.sqlserver -version 2.2.0

//install package yaparken dikkat edilmesi gereken hangi katmandaki projeye yapıldığı.Default projeyi değiştirmek gerekir.

//bunları yaptıktan sonra EShop41.web in içindeki data'yı siliyoruz.
//startup'da altı cizili alanlar olcak olanları ctrl. yapınca datamız değişmiş olacak. ve kullanılmayan bir using olacak onu silelim.
//appsettings.jsona connettion stringimizi ayarladık. ve add-migration Identity dedik. Default projeyi Infrastructure seçilecek. sonra update-database dedik.
//startup.cs de 42. satırda  'services.AddDefaultIdentity<IdentityUser>()' Identityi sildik ve Onu ApplicationUser yaptık. yanına IdentityRole ekledik ve default'u sildik. son hali o satırın   services.AddIdentity<ApplicationUser, IdentityRole>() oldu
//sonra bir hatayla karşılaştık çalıştırınca bunun çözümü için startap.cs ye girdik
