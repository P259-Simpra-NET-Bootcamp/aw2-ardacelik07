using SimApi.Data.Domain;
using SimApi.Data.Repository;

namespace DataLayer.IConfiguration;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<staff> staffRepository { get; }


    void Complete();
}
