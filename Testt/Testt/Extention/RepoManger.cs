using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testt.Properties.Repositories;

namespace Testt.SharedFile
{
    public static class RepoManger
    {
        public static void addServices(this IServiceCollection service)
        {
            service.AddScoped<IUserRepo, UserRepo>();
            service.AddScoped<IPostRepo, PostRepo>();
            service.AddControllers();
            service.AddSwaggerGen();
            service.AddAutoMapper(typeof(Startup));
          
        }
        public static void AddDbContext(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<AppDbContext>(optionsAction: options => options.UseSqlServer(configuration.GetConnectionString(name: "DefaultConnectionString")));
        }
    }
}
