using Project.ENTITIES.Concrete;

namespace Project.Business.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
    {
        byte[] GetDestinationsReportAsExcel();
    }
}
