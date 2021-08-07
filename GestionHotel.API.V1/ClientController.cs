using GestionHotel.Domain.Commands.Client;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Client;
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

    public class ClientController : ApiV1ControllerBase
    {
        private readonly ILogger<ClientController> _logger;

        public ClientController(ILogger<ClientController> logger, IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get Client by id
        /// </summary>
        /// <param name="id">Id of Client</param>
        /// <returns>Client information</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(ClientDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ClientDto>> GetClientAsync(Int64 id)
        {
            return Single(await QueryAsync(new GetClientQuery(id)));
        }

        /// <summary>
        /// Get all Clients
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(PagedResults<ClientDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PagedResults<ClientDto>>> GetClientsAsync([FromQuery] GetClientsQuery query)
        {
            return await QueryAsync<PagedResults<ClientDto>>(query);
        }

        /// <summary>
        /// Create new Client
        /// </summary>
        /// <param name="command">Info of Client</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateClientAsync([FromBody] CreateClientCommand command)
        {
            return StatusCode(200, await CommandAsync(command));
        }

        /// <summary>
        /// Create new Client
        /// </summary>
        /// <param name="command">Info of Client</param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> UpdateClientAsync([FromBody] UpdateClientCommand command)
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
        public async Task<ActionResult<ClientDto>> DeleteClientAsync([FromBody] DeleteClientCommand command)
        {
            return StatusCode(204, await CommandAsync(command));
        }

    }
}