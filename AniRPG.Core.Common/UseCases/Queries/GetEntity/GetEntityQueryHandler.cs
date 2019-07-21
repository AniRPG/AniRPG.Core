using System.Threading;
using System.Threading.Tasks;
using AniRPG.Core.Common.Exceptions;
using AniRPG.Core.Common.Repositories;
using AniRPG.Core.Domain;
using MediatR;

namespace AniRPG.Core.Common.UseCases.Queries.GetEntity
{
    public class GetEntityQueryHandler<T> : IRequestHandler<GetEntityQuery<T>, T>
        where T : IEntity
    {
        private readonly IEntityRepository<T> _entityRepository;

        public GetEntityQueryHandler(IEntityRepository<T> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public async Task<T> Handle(GetEntityQuery<T> request, CancellationToken cancellationToken)
        {
            var entity = await _entityRepository.GetEntity(request.EntityId);

            if (entity == null)
                throw new EntityNotFoundException<T>(request.EntityId);

            return entity;
        }
    }
}