using GestionHotel.Domain.Commands.OrganismePayeur;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.OrganismePayeur;
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

    public class OrganismePayeurController : ApiV1ControllerBase
    {
        private readonly ILogger<OrganismePayeurController> _logger;

        public OrganismePayeurController(ILogger<OrganismePayeurController> logger, IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get OrganismePayeur by id
        /// </summary>
        /// <param name="id">Id of OrganismePayeur</param>
        /// <returns>OrganismePayeur information</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(OrganismePayeurDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<OrganismePayeurDto>> GetOrganismePayeurAsync(Int64 id)
        {
            return Single(await QueryAsync(new GetOrganismePayeurQuery(id)));
        }

        /// <summary>
        /// Get all OrganismePayeurs
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(PagedResults<OrganismePayeurDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PagedResults<OrganismePayeurDto>>> GetOrganismePayeursAsync([FromQuery] GetOrganismePayeursQuery query)
        {
            return await QueryAsync<PagedResults<OrganismePayeurDto>>(query);
        }

        /// <summary>
        /// Create new OrganismePayeur
        /// </summary>
        /// <param name="command">Info of OrganismePayeur</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateOrganismePayeurAsync([FromBody] CreateOrganismePayeurCommand command)
        {
            return StatusCode(200, await CommandAsync(command));
        }

        /// <summary>
        /// Create new OrganismePayeur
        /// </summary>
        /// <param name="command">Info of OrganismePayeur</param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> UpdateOrganismePayeurAsync([FromBody] UpdateOrganismePayeurCommand command)
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
        public async Task<ActionResult<OrganismePayeurDto>> DeleteOrganismePayeurAsync([FromBody] DeleteOrganismePayeurCommand command)
        {
            return StatusCode(204, await CommandAsync(command));
        }

    }
}