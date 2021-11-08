using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.Cookies;
using WarframeProgressTrackerApi.Data;
using WarframeProgressTrackerApi.Models;
using WarframeProgressTrackerApi.Services;

namespace WarframeProgressTrackerApi {
    public class Startup {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            ConfigureIdentity(services);

            services.ConfigureApplicationCookie(cookieOptions => {
                cookieOptions.Cookie.SameSite = SameSiteMode.Lax;
                cookieOptions.Cookie.Name = "auth_cookie";

                cookieOptions.Events = new CookieAuthenticationEvents {
                    OnRedirectToLogin = redirectContext => {
                        redirectContext.HttpContext.Response.StatusCode = 401;
                        return Task.CompletedTask;
                    }
                };
            });

            services.AddCors(options =>
                options.AddPolicy(name: MyAllowSpecificOrigins, builder =>
                    builder.WithOrigins("http://localhost:4200", "https://jimmyhaglund.github.io", "http://192.168.1.8")
                    // builder.AllowAnyOrigin()
                    .AllowCredentials()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    ));

            // services.AddMvc(options => options.Filters.Add(new ValidateAntiForgeryTokenAttribute()));
            // services.AddAntiforgery(antiForgeryOptions => antiForgeryOptions.HeaderName = "X-XSRF-TOKEN");

            services.AddControllers();
            services.AddScoped<UserManager<User>>();
            services.AddScoped<SignInManager<User>>();
            services.AddSingleton<SessionUser>();
        }

        private void ConfigureIdentity(IServiceCollection services) {
            services.AddDbContext<WarframeProgressTrackerContext>(options =>
                // options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
                options.UseSqlite("Data Source=WarframeProgressTracker.db"));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<WarframeProgressTrackerContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options => {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredUniqueChars = 0;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers()
                    .RequireCors(MyAllowSpecificOrigins);
            });

            EnsureDbCreated(app);
        }

        private void EnsureDbCreated(IApplicationBuilder applicationBuilder) {
            var serviceScopeFactory = applicationBuilder.ApplicationServices.GetRequiredService<IServiceScopeFactory>();

            using (var serviceScope = serviceScopeFactory.CreateScope()) {
                var dbContext = serviceScope.ServiceProvider.GetService<WarframeProgressTrackerContext>();
                dbContext.Database.EnsureCreated();
            }
        }
    }
}
