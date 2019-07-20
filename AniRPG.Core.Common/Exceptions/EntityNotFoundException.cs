using System;
using AniRPG.Core.Domain;

namespace AniRPG.Core.Common.Exceptions
{
    public abstract class EntityNotFoundException : Exception
    {
        public int EntityId { get; }

        public string EntityName { get; }

        protected EntityNotFoundException(string name, int id)
            : base("Entity {name}(Id = {id}) not found.")
        {
            EntityName = name;
            EntityId = id;
        }
    }

    public class EntityNotFoundException<T> : EntityNotFoundException
        where T : IEntity
    {
        public EntityNotFoundException(int id)
            : base(nameof(T), id)
        {
        }
    }
}