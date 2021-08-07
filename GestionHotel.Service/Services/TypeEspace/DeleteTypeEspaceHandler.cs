using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.TypeEspace;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.TypeEspace;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace GestionHotel.Service.Services
{
    public class DeleteTypeEspacevueHandler : IRequestHandler<DeleteTypeEspaceCommand, DeleteResult>
    {
        private readonly ITypeEspaceRepository _typeEspaceRepository;
        private readonly IEspaceRepository _espaceRepository;
        private readonly IMediator _mediator;

        public DeleteTypeEspacevueHandler(ITypeEspaceRepository typeEspaceRepository, IEspaceRepository espaceRepository,
            IMediator mediator)
        {
            _typeEspaceRepository = typeEspaceRepository ?? throw new ArgumentNullException(nameof(typeEspaceRepository));
            _espaceRepository = espaceRepository ?? throw new ArgumentNullException(nameof(espaceRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }


        public async Task<DeleteResult> Handle(DeleteTypeEspaceCommand request, CancellationToken cancellationToken)
        {
            var typeEspaceModel = await _typeEspaceRepository.GetAsync(e => e.Id == request.Id);

            if (typeEspaceModel != null)
            {
                bool usedInEspace = _espaceRepository.Queryable(l => l.TypeEspaceId == request.Id).Any();

                if (!usedInEspace)
                {
                    _typeEspaceRepository.Remove(typeEspaceModel);

                    if (await _typeEspaceRepository.SaveChangesAsync() == 0)
                    {
                        throw new ApplicationException("Deletion Failed");
                    }

                    await _mediator.Publish(new TypeEspaceDeletedEvent(typeEspaceModel.Id), cancellationToken);

                    return new DeleteResult(true);

                }
                else
                {
                    throw new ApplicationException("TypeEspace cannot been deleted because it is used by Espace");
                }
            }
            else
            {
                throw new ApplicationException("TypeEspace does no longer exist");
            }


        }
    }
}