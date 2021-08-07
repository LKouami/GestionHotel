using GestionHotel.Domain.Commands.TypeClient;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.TypeClient;
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

    public class TypeClientController : ApiV1ControllerBase
    {
        private readonly ILogger<TypeClientController> _logger;

        public TypeClientController(ILogger<TypeClientController> logger, IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get TypeClient by id
        /// </summary>
        /// <param name="id">Id of TypeClient</param>
        /// <returns>TypeClient information</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(TypeClientDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<TypeClientDto>> GetTypeClientAsync(Int64 id)
        {
            return Single(await QueryAsync(new GetTypeClientQuery(id)));
        }

        /// <summary>
        /// Get all TypeClients
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(PagedResults<TypeClientDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PagedResults<TypeClientDto>>> GetTypeClientsAsync([FromQuery] GetTypeClientsQuery query)
        {
            return await QueryAsync<PagedResults<TypeClientDto>>(query);
        }

        /// <summary>
        /// Create new TypeClient
        /// </summary>
        /// <param name="command">Info of TypeClient</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateTypeClientAsync([FromBody] CreateTypeClientCommand command)
        {
            return StatusCode(200, await CommandAsync(command));
        }

        /// <summary>
        /// Create new TypeClient
        /// </summary>
        /// <param name="command">Info of TypeClient</param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> UpdateTypeClientAsync([FromBody] UpdateTypeClientCommand command)
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
        public async Task<ActionResult<TypeClientDto>> DeleteTypeClientAsync([FromBody] DeleteTypeClientCommand command)
        {
            return StatusCode(204, await CommandAsync(command));
        }

    }
}