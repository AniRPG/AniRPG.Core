using AniRPG.Core.Domain;
using MediatR;

namespace AniRPG.Core.Common.UseCases.Commands.UpdateEntity
{
    public class UpdateEntityCommand<T> : IRequest
        where T : IEntity
    {
        public T Entity { get; set; }
    }
}