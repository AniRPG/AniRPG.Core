using AniRPG.Core.Domain;
using MediatR;

namespace AniRPG.Core.Common.UseCases.Commands.DeleteEntity
{
    public class DeleteEntityCommand<T> : IRequest
        where T : IEntity
    {
        public int EntityId { get; set; }
    }
}