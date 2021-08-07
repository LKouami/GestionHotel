using GestionHotel.Domain.Commands.Espace;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Espace;
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

    public class EspaceController : ApiV1ControllerBase
    {
        private readonly ILogger<EspaceController> _logger;

        public EspaceController(ILogger<EspaceController> logger, IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get Espace by id
        /// </summary>
        /// <param name="id">Id of Espace</param>
        /// <returns>Espace information</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(EspaceDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<EspaceDto>> GetEspaceAsync(Int64 id)
        {
            return Single(await QueryAsync(new GetEspaceQuery(id)));
        }

        /// <summary>
        /// Get all Espaces
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(PagedResults<EspaceDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PagedResults<EspaceDto>>> GetEspacesAsync([FromQuery] GetEspacesQuery query)
        {
            return await QueryAsync<PagedResults<EspaceDto>>(query);
        }

        /// <summary>
        /// Create new Espace
        /// </summary>
        /// <param name="command">Info of Espace</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateEspaceAsync([FromBody] CreateEspaceCommand command)
        {
            return StatusCode(200, await CommandAsync(command));
        }

        /// <summary>
        /// Create new Espace
        /// </summary>
        /// <param name="command">Info of Espace</param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> UpdateEspaceAsync([FromBody] UpdateEspaceCommand command)
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
        public async Task<ActionResult<EspaceDto>> DeleteEspaceAsync([FromBody] DeleteEspaceCommand command)
        {
            return StatusCode(204, await CommandAsync(command));
        }

    }
}