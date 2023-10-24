using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Concrete;
using Project.MAP.Configurations;

namespace Project.DAL.Context
{
    public class MyContext : IdentityDbContext<AppUser, AppRole, int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=TraversalCoreDB3; integrated security = true;");
        }
        //private readonly Context _context;
        //public Context(Context context)
        //{
        //    _context = context;
        //}
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new About2Configuration());
            builder.ApplyConfiguration(new AboutConfiguration());
            builder.ApplyConfiguration(new AnnouncementConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new ContactConfiguration());
            builder.ApplyConfiguration(new ContactMeConfiguration());
            builder.ApplyConfiguration(new DestinationConfiguration());
            builder.ApplyConfiguration(new FeatureConfiguration());
            builder.ApplyConfiguration(new SideFeatureConfiguration());
            builder.ApplyConfiguration(new NewsLetterConfiguration());
            builder.ApplyConfiguration(new GuideConfiguration());
            builder.ApplyConfiguration(new ReservationConfiguration());
            builder.ApplyConfiguration(new SubAboutConfiguration());
            builder.ApplyConfiguration(new TestimonialConfiguration());
           

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> Abouts2 { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<ContactMe> ContactMes { get; set; }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<SideFeatures> SideFeatures { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
