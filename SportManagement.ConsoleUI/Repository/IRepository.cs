

using SportManagement.ConsoleUI.Models;

namespace SportManagement.ConsoleUI.Repository;

public interface IRepository <TEntity , TId>
                 where TEntity: Entity<TId>, new()
{
    List<TEntity> GetAll ();
    public TEntity? GetById (TId id);
    public TEntity Add (TEntity entity);
    public TEntity? Update (TId id,TEntity entity);
    public TEntity? Delete (TId id );
}
