namespace HakatonApp.Web.Extentions
{
    using System.Linq;
    using System.Reflection;
    using HakatonApp.Services;
    using Microsoft.Extensions.DependencyInjection;

    public static class IServiceCollectionExtentions
    {
        /* 
         * Services which implement IService
         * are autoregistered in transient scope
         * and binded with interface with the same name 
         */
        public static void AutoloadServices(this IServiceCollection services)
        {
            Assembly
                .GetAssembly(typeof(IService))
                .GetTypes()
                .Where(t => t.IsClass && t.GetInterfaces().Any(i => i.Name == $"I{t.Name}"))
                .Select(t => new
                {
                    Interface = t.GetInterface($"I{t.Name}"),
                    Implementation = t
                })
                .ToList()
                .ForEach(s => services.AddTransient(s.Interface, s.Implementation));
        }
    }
}
