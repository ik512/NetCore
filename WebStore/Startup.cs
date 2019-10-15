using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using WebStore.Infrastructure.Interfaces;
using WebStore.Services;
using Microsoft.EntityFrameworkCore;
using Webstore.DAL;
using WebStore.DomainNew.Entities;
using Microsoft.AspNetCore.Identity;
using WebStore.Infrastructure.Services;
using WebStore.Infrastructure.Intefaces;
using WebStore.Infrastructure.Implementations;
using WebStore.DAL;

namespace WebStore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //настройки сервисов------>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddScoped<IProductService, SqlProductService>();
            services.AddScoped<IOrdersService, SqlOrdersService>();
            services.AddSingleton<IEmployeeService, EmployeeService>();
            services.AddDbContext<WebStoreContext>(options=>options.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<WebStoreContext>()
                .AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(o =>
            {
                o.Password.RequiredLength = 3;
                o.Password.RequireDigit = false;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;

                o.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(o =>
            {
                o.Cookie.Expiration = System.TimeSpan.FromDays(100);
            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ICartService, CookieCartService>();
        } 

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //Настройки приложения---------->
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseWelcomePage("/welcome");

            //app.Map("/index", CustomIndexHandler);

            //app.UseMiddleware<TokenMiddleware>();

            //app.UseMvcWithDefaultRoute();
            // Производим конфигурацию инфраструктуры MVC
            app.UseMvc(routes =>
            {
                // Добавляем обработчик маршрута по умолчанию
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                // Маршрут по умолчанию состоит из трёх частей разделённых “/”
                // Первой частью указывается имя контроллера,
                // второй - имя действия (метода) в контроллере,
                // третей - опциональный параметр с именем “id”
                // Если чать не указана - используются значения по умолчанию:
                // для контроллера имя “Home”,
                // для действия - “Index”
            });

            //app.Use(async (context, next) =>
            //    {
            //        await context.Response.WriteAsync("Hello from Use middleware");
            //        //await next.Invoke();
            //    });

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello from Run middleware");
            //});

            var helloMessage = Configuration["CustomHelloWorld"];

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(helloMessage);
            });
        }
    }
}
