using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Clientvue;
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

    public class ClientvueController : ApiV1ControllerBase
    {
        private readonly ILogger<ClientvueController> _logger;

        public ClientvueController(ILogger<ClientvueController> logger, IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get Clientvue by id
        /// </summary>
        /// <param name="id">Id of Clientvue</param>
        /// <returns>Clientvue information</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(ClientvueDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ClientvueDto>> GetClientvueAsync(Int64 id)
        {
            return Single(await QueryAsync(new GetClientvueQuery(id)));
        }

        /// <summary>
        /// Get all Clientvues
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(PagedResults<ClientvueDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PagedResults<ClientvueDto>>> GetClientvuesAsync([FromQuery] GetClientvuesQuery query)
        {
            return await QueryAsync<PagedResults<ClientvueDto>>(query);
        }


    }
}