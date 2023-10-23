using Project.ENTITIES.Concrete;

namespace Project.Business.Abstract
{
    public interface IGuideService : IGenericService<Guide>
    {
        void ActiveGuide(int id);
    }
}
