using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.AffectationMateriel;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.AffectationMateriel;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class DeleteAffectationMaterielHandler : IRequestHandler<DeleteAffectationMaterielCommand, DeleteResult>
    {
        private readonly IAffectationMaterielRepository _affectationMaterielRepository;
        private readonly IMediator _mediator;

        public DeleteAffectationMaterielHandler(IAffectationMaterielRepository affectationMaterielRepository,
            IMediator mediator)
        {
            _affectationMaterielRepository = affectationMaterielRepository ?? throw new ArgumentNullException(nameof(affectationMaterielRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }


        public async Task<DeleteResult> Handle(DeleteAffectationMaterielCommand request, CancellationToken cancellationToken)
        {
            var affectationMaterielModel = await _affectationMaterielRepository.GetAsync(e => e.Id == request.Id);

            _affectationMaterielRepository.Remove(affectationMaterielModel);

            if (await _affectationMaterielRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Deletion failed");
            }

            await _mediator.Publish(new AffectationMaterielDeletedEvent(affectationMaterielModel.Id), cancellationToken);

            return new DeleteResult(true);
        }
    }
}