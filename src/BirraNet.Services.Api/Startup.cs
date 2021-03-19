using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BirraNet.Infra.Data.Repositorios;
using BirraNet.Application.Service;
using BirraNet.Services.Api.Configurations;
using BirraNet.Infra.Data.Contexto;
using BirraNet.Infra.Data.UoW;

namespace BirraNet.Services.Api
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
            services.AddControllers();
            services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("database"));
            services.AddTransient<IPerguntaRepository, PerguntaRepository>();
            services.AddTransient<IMensagemRepository, MensagemRepository>();
            services.AddTransient<ICervejaRepository, CervejaRepository>();
            services.AddTransient<IPerguntaAppService, PerguntaAppService>();
            services.AddTransient<ICervejaAppService, CervejaAppService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddAutoMapperSetup();
            services.AddCors(options =>
            {
                options.AddPolicy("allowSpecificOrigins",
                builder =>
                {
                    builder.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();

                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("allowSpecificOrigins");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
