using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Espacevue;
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

    public class EspacevueController : ApiV1ControllerBase
    {
        private readonly ILogger<EspacevueController> _logger;

        public EspacevueController(ILogger<EspacevueController> logger, IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get Espacevue by id
        /// </summary>
        /// <param name="id">Id of Espacevue</param>
        /// <returns>Espacevue information</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(EspacevueDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<EspacevueDto>> GetEspacevueAsync(Int64 id)
        {
            return Single(await QueryAsync(new GetEspacevueQuery(id)));
        }

        /// <summary>
        /// Get all Espacevues
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(PagedResults<EspacevueDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PagedResults<EspacevueDto>>> GetEspacevuesAsync([FromQuery] GetEspacevuesQuery query)
        {
            return await QueryAsync<PagedResults<EspacevueDto>>(query);
        }


    }
}