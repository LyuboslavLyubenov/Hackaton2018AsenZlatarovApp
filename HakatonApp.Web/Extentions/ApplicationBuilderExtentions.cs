namespace HakatonApp.Web.Extentions
{
    using HakatonApp.Data.Models;
    using HakatonApp.Web.Data.Data;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System.Threading.Tasks;

    using static HakatonApp.Common.GlobalConstants;

    public static class ApplicationBuilderExtentions
    {
        public static void AutoMigrations(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                var userManager = serviceScope.ServiceProvider.GetService<UserManager<User>>();
                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

                context.Database.Migrate();

                Task.Run(async () =>
                {
                    var isAnyThereUsers = await context.UserRoles.AnyAsync();

                    if (!isAnyThereUsers)
                    {
                        await roleManager.CreateAsync(new IdentityRole()
                        {
                            Name = RoleAdmin
                        });

                        await roleManager.CreateAsync(new IdentityRole
                        {
                            Name = RoleEditor
                        });

                        var admin = new User
                        {
                            Email = AdminEmail,
                            UserName = AdminUsernameAndPass,
                            FullName = AdminFullName
                        };

                        await userManager.CreateAsync(admin, AdminUsernameAndPass);

                        await userManager.AddToRoleAsync(admin, RoleAdmin);

                        context.SaveChanges();
                    }
                })
                .Wait();
            }
        }
    }
}
