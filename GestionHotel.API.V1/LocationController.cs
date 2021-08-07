using GestionHotel.Domain.Commands.Location;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Location;
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

    public class LocationController : ApiV1ControllerBase
    {
        private readonly ILogger<LocationController> _logger;

        public LocationController(ILogger<LocationController> logger, IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get Location by id
        /// </summary>
        /// <param name="id">Id of Location</param>
        /// <returns>Location information</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(LocationDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<LocationDto>> GetLocationAsync(Int64 id)
        {
            return Single(await QueryAsync(new GetLocationQuery(id)));
        }

        /// <summary>
        /// Get all Locations
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(PagedResults<LocationDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PagedResults<LocationDto>>> GetLocationsAsync([FromQuery] GetLocationsQuery query)
        {
            return await QueryAsync<PagedResults<LocationDto>>(query);
        }

        /// <summary>
        /// Create new Location
        /// </summary>
        /// <param name="command">Info of Location</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateLocationAsync([FromBody] CreateLocationCommand command)
        {
            return StatusCode(200, await CommandAsync(command));
        }

        /// <summary>
        /// Create new Location
        /// </summary>
        /// <param name="command">Info of Location</param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> UpdateLocationAsync([FromBody] UpdateLocationCommand command)
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
        public async Task<ActionResult<LocationDto>> DeleteLocationAsync([FromBody] DeleteLocationCommand command)
        {
            return StatusCode(204, await CommandAsync(command));
        }

    }
}