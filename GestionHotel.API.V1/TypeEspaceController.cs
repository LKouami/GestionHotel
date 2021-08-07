using GestionHotel.Domain.Commands.TypeEspace;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.TypeEspace;
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

    public class TypeEspaceController : ApiV1ControllerBase
    {
        private readonly ILogger<TypeEspaceController> _logger;

        public TypeEspaceController(ILogger<TypeEspaceController> logger, IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get TypeEspace by id
        /// </summary>
        /// <param name="id">Id of TypeEspace</param>
        /// <returns>TypeEspace information</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(TypeEspaceDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<TypeEspaceDto>> GetTypeEspaceAsync(Int64 id)
        {
            return Single(await QueryAsync(new GetTypeEspaceQuery(id)));
        }

        /// <summary>
        /// Get all TypeEspaces
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(PagedResults<TypeEspaceDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PagedResults<TypeEspaceDto>>> GetTypeEspacesAsync([FromQuery] GetTypeEspacesQuery query)
        {
            return await QueryAsync<PagedResults<TypeEspaceDto>>(query);
        }

        /// <summary>
        /// Create new TypeEspace
        /// </summary>
        /// <param name="command">Info of TypeEspace</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateTypeEspaceAsync([FromBody] CreateTypeEspaceCommand command)
        {
            return StatusCode(200, await CommandAsync(command));
        }

        /// <summary>
        /// Create new TypeEspace
        /// </summary>
        /// <param name="command">Info of TypeEspace</param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> UpdateTypeEspaceAsync([FromBody] UpdateTypeEspaceCommand command)
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
        public async Task<ActionResult<TypeEspaceDto>> DeleteTypeEspaceAsync([FromBody] DeleteTypeEspaceCommand command)
        {
            return StatusCode(204, await CommandAsync(command));
        }

    }
}