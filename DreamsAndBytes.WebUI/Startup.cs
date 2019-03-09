using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DreamsAndBytes.Business.Abstract;
using DreamsAndBytes.Business.Concrete;
using DreamsAndBytes.DataAccess.Abstract;
using DreamsAndBytes.DataAccess.Concrete.EntityFramework;
using DreamsAndBytes.WebUI.Middlewares;
using DreamsAndBytes.WebUI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection; 

namespace DreamsAndBytes.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DreamsAndBytesContext>(optionsBuilder=>optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                x=>x.MigrationsAssembly("DreamsAndBytes.WebUI")));
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddSingleton<ICartSessionService, CartSessionManager>();
            services.AddSingleton<ICartService, CartManager>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSession();
            services.AddDistributedMemoryCache();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseFileServer();
            app.UseSession();
            app.UseNodeModules(env.ContentRootPath);
            app.UseMvcWithDefaultRoute(); 
        }
    }
}