using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;

namespace Project.Business.Concrete
{
    public class ContactManager : BaseManager<Contact>, IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal) : base(contactDal)
        {
            _contactDal = contactDal;
        }


    }
}
