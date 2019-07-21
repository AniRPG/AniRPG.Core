using AniRPG.Core.Domain;
using MediatR;

namespace AniRPG.Core.Common.UseCases.Queries.GetEntity
{
    public class GetEntityQuery<T> : IRequest<T>
        where T : IEntity
    {
        public int EntityId { get; set; }
    }
}