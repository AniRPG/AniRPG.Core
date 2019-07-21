using System.Threading;
using System.Threading.Tasks;
using AniRPG.Core.Common.Repositories;
using AniRPG.Core.Domain;
using MediatR;

namespace AniRPG.Core.Common.UseCases.Commands.UpdateEntity
{
    public class UpdateEntityCommandHandler<T> : AsyncRequestHandler<UpdateEntityCommand<T>>
        where T : IEntity
    {
        private readonly IEntityRepository<T> _entityRepository;

        public UpdateEntityCommandHandler(IEntityRepository<T> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        protected override async Task Handle(UpdateEntityCommand<T> request, CancellationToken cancellationToken)
        {
            await _entityRepository.UpdateEntity(request.Entity);
        }
    }
}