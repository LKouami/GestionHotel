using GestionHotel.Domain.Commands.Materiel;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Materiel;
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

    public class MaterielController : ApiV1ControllerBase
    {
        private readonly ILogger<MaterielController> _logger;

        public MaterielController(ILogger<MaterielController> logger, IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get Materiel by id
        /// </summary>
        /// <param name="id">Id of Materiel</param>
        /// <returns>Materiel information</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(MaterielDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<MaterielDto>> GetMaterielAsync(Int64 id)
        {
            return Single(await QueryAsync(new GetMaterielQuery(id)));
        }

        /// <summary>
        /// Get all Materiels
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(PagedResults<MaterielDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PagedResults<MaterielDto>>> GetMaterielsAsync([FromQuery] GetMaterielsQuery query)
        {
            return await QueryAsync<PagedResults<MaterielDto>>(query);
        }

        /// <summary>
        /// Create new Materiel
        /// </summary>
        /// <param name="command">Info of Materiel</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateMaterielAsync([FromBody] CreateMaterielCommand command)
        {
            return StatusCode(200, await CommandAsync(command));
        }

        /// <summary>
        /// Create new Materiel
        /// </summary>
        /// <param name="command">Info of Materiel</param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> UpdateMaterielAsync([FromBody] UpdateMaterielCommand command)
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
        public async Task<ActionResult<MaterielDto>> DeleteMaterielAsync([FromBody] DeleteMaterielCommand command)
        {
            return StatusCode(204, await CommandAsync(command));
        }

    }
}