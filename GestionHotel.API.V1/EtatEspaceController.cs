using GestionHotel.Domain.Commands.EtatEspace;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.EtatEspace;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionHotel.API.V1.Controllers
{
    [AllowAnonymous]

    public class EtatEspaceController : ApiV1ControllerBase
    {
        private readonly ILogger<EtatEspaceController> _logger;

        public EtatEspaceController(ILogger<EtatEspaceController> logger, IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get EtatEspace by id
        /// </summary>
        /// <param name="id">Id of EtatEspace</param>
        /// <returns>EtatEspace information</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(EtatEspaceDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<EtatEspaceDto>> GetEtatEspaceAsync(Int64 id)
        {
            return Single(await QueryAsync(new GetEtatEspaceQuery(id)));
        }

        /// <summary>
        /// Get all EtatEspaces
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(PagedResults<EtatEspaceDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PagedResults<EtatEspaceDto>>> GetEtatEspacesAsync([FromQuery] GetEtatEspacesQuery query)
        {
            return await QueryAsync<PagedResults<EtatEspaceDto>>(query);
        }

        /// <summary>
        /// Create new EtatEspace
        /// </summary>
        /// <param name="command">Info of EtatEspace</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateEtatEspaceAsync([FromBody] CreateEtatEspaceCommand command)
        {
            return StatusCode(200, await CommandAsync(command));
        }

        /// <summary>
        /// Create new EtatEspace
        /// </summary>
        /// <param name="command">Info of EtatEspace</param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> UpdateEtatEspaceAsync([FromBody] UpdateEtatEspaceCommand command)
        {
            return Ok(await CommandAsync(command));
        }


        /// <summary>
        /// Delete an employee with an id 
        /// </summary>
        /// <param name="command">The delete model</param>
        /// <returns></returns>
        [HttpDelete]
        [ProducesResponseType(typeof(DeleteResult), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<EtatEspaceDto>> DeleteEtatEspaceAsync([FromBody] DeleteEtatEspaceCommand command)
        {
            return StatusCode(204, await CommandAsync(command));
        }

    }
}