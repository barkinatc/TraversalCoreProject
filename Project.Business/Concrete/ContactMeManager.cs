using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;

namespace Project.Business.Concrete
{
    public class ContactMeManager : BaseManager<ContactMe>,IContactMeService
    {
        IContactMeDal _contactMeDal;
        public ContactMeManager(IContactMeDal contactMeDal):base(contactMeDal)
        {
            _contactMeDal = contactMeDal;
        }
    }
}
