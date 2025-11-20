namespace AITech.DataAccess.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();

    }
}
