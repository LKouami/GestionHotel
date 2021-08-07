using GestionHotel.Domain.Commands.AffectationMateriel;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.AffectationMateriel;
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

    public class AffectationMaterielController : ApiV1ControllerBase
    {
        private readonly ILogger<AffectationMaterielController> _logger;

        public AffectationMaterielController(ILogger<AffectationMaterielController> logger, IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get AffectationMateriel by id
        /// </summary>
        /// <param name="id">Id of AffectationMateriel</param>
        /// <returns>AffectationMateriel information</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(AffectationMaterielDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<AffectationMaterielDto>> GetAffectationMaterielAsync(Int64 id)
        {
            return Single(await QueryAsync(new GetAffectationMaterielQuery(id)));
        }

        /// <summary>
        /// Get all AffectationMateriels
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(PagedResults<AffectationMaterielDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PagedResults<AffectationMaterielDto>>> GetAffectationMaterielsAsync([FromQuery] GetAffectationMaterielsQuery query)
        {
            return await QueryAsync<PagedResults<AffectationMaterielDto>>(query);
        }

        /// <summary>
        /// Create new AffectationMateriel
        /// </summary>
        /// <param name="command">Info of AffectationMateriel</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateAffectationMaterielAsync([FromBody] CreateAffectationMaterielCommand command)
        {
            return StatusCode(200, await CommandAsync(command));
        }

        /// <summary>
        /// Create new AffectationMateriel
        /// </summary>
        /// <param name="command">Info of AffectationMateriel</param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> UpdateAffectationMaterielAsync([FromBody] UpdateAffectationMaterielCommand command)
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
        public async Task<ActionResult<AffectationMaterielDto>> DeleteAffectationMaterielAsync([FromBody] DeleteAffectationMaterielCommand command)
        {
            return StatusCode(204, await CommandAsync(command));
        }

    }
}