using DataLayer.Concrete;
using DataLayer.Concrete.EfCore.Identity;
using EntityLayer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StockTrackingApp.AutoMappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackingApp
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
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MsSqlConnection")).EnableSensitiveDataLogging());
            services.AddDbContext<Context>(options => options.UseSqlServer(Configuration.GetConnectionString("MsSqlConnection")), ServiceLifetime.Transient);
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();


            services.Configure<IdentityOptions>(options =>
            {
                // password
                options.Password.RequireDigit = false; // say�sal de�er gire zorunlulu�u
                options.Password.RequireLowercase = false; // k���k harf zorunlulu�u
                options.Password.RequireUppercase = false; // b�y�k harf zorunlulu�u
                options.Password.RequiredLength = 5;
                options.Password.RequireNonAlphanumeric = false;

                // Lockout
                options.Lockout.MaxFailedAccessAttempts = 5;//kullan�c� hesab�na 5 kere yanl�� oturum hakk�na sahip sonra hesab� kilitlenir.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // 5dk sonra kullan�c� giri� yapabilir.
                options.Lockout.AllowedForNewUsers = true;

                //options.User.AllowedUserNameCharacters=""
                options.User.RequireUniqueEmail = true; // her kullan�c�n�n farkl� maili olmas� gerekiyor
                options.SignIn.RequireConfirmedEmail = false; // kullan�c�n�n mailine onay kodu gider
                options.SignIn.RequireConfirmedPhoneNumber = false;

            });

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;//cookie s�resi varsay�lan 20 dk . 20 dk sonras�nda taray�c� login i�lemini bize g�nderir.
                options.ExpireTimeSpan = TimeSpan.FromDays(1); // login olma s�resi yukar�daki maddede varsay�lan 20 dk burada ben ayarlayabiliyorum mesela 1 g�n ayarlad�m 
                options.Cookie.IsEssential = true;
            });

            services.AddAutoMapper(typeof(Mapping));

            services.AddScoped<DataLayer.Abstract.IUnitOfWork, DataLayer.Concrete.EfCore.UnitOfWork>();
            services.AddScoped<BusinessLayer.Abstract.IUnitOfWork, BusinessLayer.Concrete.UnitOfWork>();


            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            SeedIdentity.SeedAsync(Configuration, userManager, roleManager).Wait();
        }
    }
}
