using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.Materiel;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.Materiel;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace GestionHotel.Service.Services
{
    public class DeleteMaterielvueHandler : IRequestHandler<DeleteMaterielCommand, DeleteResult>
    {
        private readonly IMaterielRepository _materielRepository;
        private readonly IAffectationMaterielRepository _affectationMaterielRepository;
        private readonly IMediator _mediator;

        public DeleteMaterielvueHandler(IMaterielRepository materielRepository, IAffectationMaterielRepository affectationMaterielRepository,
            IMediator mediator)
        {
            _materielRepository = materielRepository ?? throw new ArgumentNullException(nameof(materielRepository));
            _affectationMaterielRepository = affectationMaterielRepository ?? throw new ArgumentNullException(nameof(affectationMaterielRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }


        public async Task<DeleteResult> Handle(DeleteMaterielCommand request, CancellationToken cancellationToken)
        {
            var materielModel = await _materielRepository.GetAsync(e => e.Id == request.Id);

            if (materielModel != null)
            {
                bool usedInAffectationMateriel = _affectationMaterielRepository.Queryable(l => l.MaterielId == request.Id).Any();

                if (!usedInAffectationMateriel)
                {
                    _materielRepository.Remove(materielModel);

                    if (await _materielRepository.SaveChangesAsync() == 0)
                    {
                        throw new ApplicationException("Deletion Failed");
                    }

                    await _mediator.Publish(new MaterielDeletedEvent(materielModel.Id), cancellationToken);

                    return new DeleteResult(true);

                }
                else
                {
                    throw new ApplicationException("Materiel cannot been deleted because it is used by AffectationMateriel");
                }
            }
            else
            {
                throw new ApplicationException("Materiel does no longer exist");
            }


        }
    }
}