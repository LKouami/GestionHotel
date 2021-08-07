using GestionHotel.Domain.Commands.Pack;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Pack;
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

    public class PackController : ApiV1ControllerBase
    {
        private readonly ILogger<PackController> _logger;

        public PackController(ILogger<PackController> logger, IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get Pack by id
        /// </summary>
        /// <param name="id">Id of Pack</param>
        /// <returns>Pack information</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(PackDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PackDto>> GetPackAsync(Int64 id)
        {
            return Single(await QueryAsync(new GetPackQuery(id)));
        }

        /// <summary>
        /// Get all Packs
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(PagedResults<PackDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PagedResults<PackDto>>> GetPacksAsync([FromQuery] GetPacksQuery query)
        {
            return await QueryAsync<PagedResults<PackDto>>(query);
        }

        /// <summary>
        /// Create new Pack
        /// </summary>
        /// <param name="command">Info of Pack</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreatePackAsync([FromBody] CreatePackCommand command)
        {
            return StatusCode(200, await CommandAsync(command));
        }

        /// <summary>
        /// Create new Pack
        /// </summary>
        /// <param name="command">Info of Pack</param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> UpdatePackAsync([FromBody] UpdatePackCommand command)
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
        public async Task<ActionResult<PackDto>> DeletePackAsync([FromBody] DeletePackCommand command)
        {
            return StatusCode(204, await CommandAsync(command));
        }

    }
}