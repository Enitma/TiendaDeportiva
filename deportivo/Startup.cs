using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using deportivo.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace deportivo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DeporteDbContext>(options=>options.UseNpgsql("Host=ec2-75-101-147-226.compute-1.amazonaws.com;"
            +"Database=d43l8j3aepn5vn;"
            +"Username=hqbdpxrhysbzvm;"
            +"Password=370e89ae4e47263d98c241aec70ebc12e683bfb50f7ecbc307c6a6d61191b6b0;"
            +"Port=5432;"
            +"SSL Mode=Require;Trust Server Certificate=true"));
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();  
            app.UseStaticFiles();
            
        }
    }
}
