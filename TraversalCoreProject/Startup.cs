using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project.Business.Abstract;
using Project.Business.Concrete;
using Project.DAL.Abstract;
using Project.DAL.Concrete;
using Project.DAL.EF;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.Custom;

namespace TraversalCoreProject
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
            services.AddDbContext<Context>();

            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>();
            services.AddControllersWithViews();

            //Addscoped
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IAbout2Service, About2Manager>();
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IGuideService,GuideManager>();
            services.AddScoped<INewsletterService, NewsletterManager>();
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<ISideFeatureService, SideFeatureManager>();
            services.AddScoped<ISubAboutService, SubAboutManager>();
            services.AddScoped<ITestimonialService, TestimonialManager>();
            //AddScopedEf
            services.AddScoped<IDestinationDal, EFDestinationDal>();
            services.AddScoped<IAbout2Dal, EFAbout2Dal>();
            services.AddScoped<IAboutDal, EFAboutDal>();
            services.AddScoped<ICommentDal, EFCommentDal>();
            services.AddScoped<IContactDal, EFContactDal>();
            services.AddScoped<IFeatureDal, EFFeatureDal>();
            services.AddScoped<IGuideDal, EFGuideDal>();
            services.AddScoped<INewsletterDal, EFNewsletterDal>();
            services.AddScoped<IReservationDal, EFReservationDal>();
            services.AddScoped<ISideFeatureDal, EFSideFeatureDal>();
            services.AddScoped<ITestimonialDal, EFTestimonialDal>();
            services.AddScoped<ISubAboutDal, EFSubAboutDal>();
            services.AddMvc(Configuration =>
            {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
                Configuration.Filters.Add(new AuthorizeFilter(policy));
            });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Default}/{action=Index}/{id?}");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                );

            });
        }
    }
}