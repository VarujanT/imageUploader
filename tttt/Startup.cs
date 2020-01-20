using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using tttt.Models;
using tttt.App_Data;

namespace tttt
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<image>(opt =>
               opt.UseInMemoryDatabase("imageUploader"));
            NewMethod(services);
        }

        private static void NewMethod(IServiceCollection services)
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
     
        }

        public interface IWebHostEnvironment
        {
        }
    }

    public interface IApplicationBuilder
    {
    }
}