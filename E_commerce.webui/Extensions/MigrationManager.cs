using E_commerce.dataa.Concrete.EfCore;
using E_commerce.webui.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace E_commerce.webui.Extensions
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using(var scope=host.Services.CreateScope())
            {
                using (var applicationContext=scope.ServiceProvider.GetRequiredService<ApplicationContext>())
                {
                    try
                    {
                        applicationContext.Database.Migrate();
                    }
                    catch (System.Exception)
                    {         
                        throw;
                    }
                }
                 using (var shopContext=scope.ServiceProvider.GetRequiredService<ShopContext>())
                {
                    try
                    {
                        shopContext.Database.Migrate();
                    }
                    catch (System.Exception)
                    {         
                        throw;
                    }
                }
            }
         return host;
        }
    }
}