using System.Threading.Tasks;
using AniRPG.Core.Domain;

namespace AniRPG.Core.Common.Repositories
{
    public interface IEntityRepository<T>
        where T : IEntity
    {
        Task AddEntity(T entity);
        Task DeleteEntity(int entityId);
        Task UpdateEntity(T entityId);
        Task<T> GetEntity(int entityId);
    }
}