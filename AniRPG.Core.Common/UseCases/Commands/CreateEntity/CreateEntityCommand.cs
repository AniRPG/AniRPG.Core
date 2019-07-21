using AniRPG.Core.Domain;
using MediatR;

namespace AniRPG.Core.Common.UseCases.Commands.CreateEntity
{
    public class CreateEntityCommand<T> : IRequest
        where T : IEntity
    {
        public T Entity { get; set; }
    }
}