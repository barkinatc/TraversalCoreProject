using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;

namespace Project.Business.Concrete
{
    public class NewsletterManager : BaseManager<Newsletter>, INewsletterService
    {
        INewsletterDal _newsletterDal;
        public NewsletterManager(INewsletterDal newsletterDal) : base(newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

    }
}
