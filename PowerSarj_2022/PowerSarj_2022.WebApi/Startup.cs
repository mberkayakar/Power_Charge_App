using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PowerSarj_2022.Business.Abstract;
using PowerSarj_2022.Business.Concrete;
using PowerSarj_2022.Core.DataAccess.Abstract;
using PowerSarj_2022.Core.DataAccess.Concrete;
using PowerSarj_2022.DataAccess.Abstract;
using PowerSarj_2022.DataAccess.Concrete.Context.EfContext;
using PowerSarj_2022.DataAccess.Concrete.Repository;

namespace PowerSarj_2022.WebApi
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

            // lazy loading i aktif etmek i?in 

            //.UseLazyLoadingProxies() 
            services.AddDbContext<MyDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));

            services.AddScoped<DbContext, MyDbContext>();

            services.AddScoped<IAdminService, AdminManager>();
            services.AddScoped<IAdminRepository, AdminRepository>();

            services.AddScoped<IDeviceService, DeviceManager>();
            services.AddScoped<IDeviceRepository, DeviceRepository>();

            services.AddScoped<IFillService, FillManager>();
            services.AddScoped<IFillRepository, FillRepository>();

            services.AddScoped<IOperationService, OperationManager>();
            services.AddScoped<IOperationRepository, OperationRepository>();

            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

             

            services.AddScoped<IUserService, UserManager>();


            services.AddControllers().AddNewtonsoftJson(options =>
              options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);


            //services.AddMvc()
            //    .AddJsonOptions(
            //        options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            //    );




            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PowerSarj_2022.WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env , MyDbContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PowerSarj_2022.WebApi v1"));
            }


            db.Database.Migrate();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
