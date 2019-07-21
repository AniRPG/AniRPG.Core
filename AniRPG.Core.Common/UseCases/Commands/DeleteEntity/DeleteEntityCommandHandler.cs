using System.Threading;
using System.Threading.Tasks;
using AniRPG.Core.Common.Repositories;
using AniRPG.Core.Domain;
using MediatR;

namespace AniRPG.Core.Common.UseCases.Commands.DeleteEntity
{
    public class DeleteEntityCommandHandler<T> : AsyncRequestHandler<DeleteEntityCommand<T>>
        where T : IEntity
    {
        private readonly IEntityRepository<T> _entityRepository;

        public DeleteEntityCommandHandler(IEntityRepository<T> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        protected override async Task Handle(DeleteEntityCommand<T> request, CancellationToken cancellationToken)
        {
            await _entityRepository.DeleteEntity(request.EntityId);
        }
    }
}