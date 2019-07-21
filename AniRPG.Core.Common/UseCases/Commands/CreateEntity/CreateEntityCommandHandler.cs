using System.Threading;
using System.Threading.Tasks;
using AniRPG.Core.Common.Repositories;
using AniRPG.Core.Domain;
using MediatR;

namespace AniRPG.Core.Common.UseCases.Commands.CreateEntity
{
    public class CreateEntityCommandHandler<T> : AsyncRequestHandler<CreateEntityCommand<T>>
        where T : IEntity
    {
        private readonly IEntityRepository<T> _entityRepository;

        public CreateEntityCommandHandler(IEntityRepository<T> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        protected override async Task Handle(CreateEntityCommand<T> request, CancellationToken cancellationToken)
        {
            await _entityRepository.CreateEntity(request.Entity);
        }
    }
}