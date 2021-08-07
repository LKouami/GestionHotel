using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Locationvue;
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

    public class LocationvueController : ApiV1ControllerBase
    {
        private readonly ILogger<LocationvueController> _logger;

        public LocationvueController(ILogger<LocationvueController> logger, IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get Locationvue by id
        /// </summary>
        /// <param name="id">Id of Locationvue</param>
        /// <returns>Locationvue information</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(LocationvueDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<LocationvueDto>> GetLocationvueAsync(Int64 id)
        {
            return Single(await QueryAsync(new GetLocationvueQuery(id)));
        }

        /// <summary>
        /// Get all Locationvues
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(PagedResults<LocationvueDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PagedResults<LocationvueDto>>> GetLocationvuesAsync([FromQuery] GetLocationvuesQuery query)
        {
            return await QueryAsync<PagedResults<LocationvueDto>>(query);
        }


    }
}