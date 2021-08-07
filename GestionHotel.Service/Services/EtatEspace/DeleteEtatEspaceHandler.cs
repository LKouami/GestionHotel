using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.EtatEspace;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.EtatEspace;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace GestionHotel.Service.Services
{
    public class DeleteEtatEspacevueHandler : IRequestHandler<DeleteEtatEspaceCommand, DeleteResult>
    {
        private readonly IEtatEspaceRepository _etatEspaceRepository;
        private readonly IEspaceRepository _espaceRepository;
        private readonly IMediator _mediator;

        public DeleteEtatEspacevueHandler(IEtatEspaceRepository etatEspaceRepository, IEspaceRepository espaceRepository,
            IMediator mediator)
        {
            _etatEspaceRepository = etatEspaceRepository ?? throw new ArgumentNullException(nameof(etatEspaceRepository));
            _espaceRepository = espaceRepository ?? throw new ArgumentNullException(nameof(espaceRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }


        public async Task<DeleteResult> Handle(DeleteEtatEspaceCommand request, CancellationToken cancellationToken)
        {
            var etatEspaceModel = await _etatEspaceRepository.GetAsync(e => e.Id == request.Id);

            if (etatEspaceModel != null)
            {
                bool usedInEspace = _espaceRepository.Queryable(l => l.EtatEspaceId == request.Id).Any();

                if (!usedInEspace)
                {
                    _etatEspaceRepository.Remove(etatEspaceModel);

                    if (await _etatEspaceRepository.SaveChangesAsync() == 0)
                    {
                        throw new ApplicationException("Deletion Failed");
                    }

                    await _mediator.Publish(new EtatEspaceDeletedEvent(etatEspaceModel.Id), cancellationToken);

                    return new DeleteResult(true);

                }
                else
                {
                    throw new ApplicationException("EtatEspace cannot been deleted because it is used by Espace");
                }
            }
            else
            {
                throw new ApplicationException("EtatEspace does no longer exist");
            }


        }
    }
}