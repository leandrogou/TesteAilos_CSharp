using MediatR;
using Questao5.Infrastructure.Database.CommandStore.Requests;

namespace Questao5
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureService(IServiceCollection services)
        {

            services.AddSingleton<IAPIBanco, APIBanco>();
            services.AddMediatR(typeof(Startup));
        }

        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
