using Microsoft.Extensions.DependencyInjection;
using Project.Business.Abstract;
using Project.Business.Concrete;
using Project.DAL.Abstract;
using Project.DAL.EF;
using Project.DAL.Repository;

namespace Project.Business.ServiceInjections
{
    public static class RepManService
    {
        public static void AddRepManServices(this IServiceCollection services)
        {
            //Addscoped
            services.AddScoped(typeof(IGenericService<>), typeof(BaseManager<>));
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IAbout2Service, About2Manager>();
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactMeService, ContactMeManager>();
            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<INewsletterService, NewsletterManager>();
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<ISideFeatureService, SideFeatureManager>();
            services.AddScoped<ISubAboutService, SubAboutManager>();
            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<IAppUserService, AppUserManager>();
            //AddScopedEf

            services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));

            services.AddScoped<IDestinationDal, EFDestinationDal>();
            services.AddScoped<IAbout2Dal, EFAbout2Dal>();
            services.AddScoped<IAboutDal, EFAboutDal>();
            services.AddScoped<ICommentDal, EFCommentDal>();
            services.AddScoped<IContactDal, EFContactDal>();
            services.AddScoped<IContactMeDal, EFContactMeDal>();
            services.AddScoped<IFeatureDal, EFFeatureDal>();
            services.AddScoped<IGuideDal, EFGuideDal>();
            services.AddScoped<INewsletterDal, EFNewsletterDal>();
            services.AddScoped<IReservationDal, EFReservationDal>();
            services.AddScoped<ISideFeatureDal, EFSideFeatureDal>();
            services.AddScoped<ITestimonialDal, EFTestimonialDal>();
            services.AddScoped<ISubAboutDal, EFSubAboutDal>();
            services.AddScoped<IAppUserDal, EFAppUserDal>();


        }
    }
}
