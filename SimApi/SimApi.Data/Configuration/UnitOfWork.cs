using DataLayer.IConfiguration;
using DataLayer.Repository.Repositories;
using SimApi.Data.Context;
using SimApi.Data.Domain;
using SimApi.Data.Repository;

namespace DataLayer.Configuration;

public class UnitOfWork : IUnitOfWork
{
    public IGenericRepository<staff> staffRepository { get; private set; }


    private readonly SimDbContext dbContext;

    public UnitOfWork(SimDbContext dbContext)
    {
        this.dbContext = dbContext;


        staffRepository = new GenericRepository<staff>(dbContext);

    }
    public void Complete()

    {

        dbContext.SaveChanges();
    }

    public void CompleteWithTransaction()
    {
        using (var dbDcontextTransaction = dbContext.Database.BeginTransaction())
        {
            try
            {
                dbContext.SaveChanges();
                dbDcontextTransaction.Commit();

            }
            catch (Exception ex)
            {
                dbDcontextTransaction.Rollback();
                throw;
            }
        }
    }


    private void Clean(bool disposing)
    {
        if (!disposing)
        {
            dbContext.Dispose();
        }

        disposing = true;
        GC.SuppressFinalize(this);
    }

    public void Dispose()
    {
        Clean(true);
    }
}
