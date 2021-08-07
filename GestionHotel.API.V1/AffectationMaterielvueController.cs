using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.AffectationMaterielvue;
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

    public class AffectationMaterielvueController : ApiV1ControllerBase
    {
        private readonly ILogger<AffectationMaterielvueController> _logger;

        public AffectationMaterielvueController(ILogger<AffectationMaterielvueController> logger, IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get AffectationMaterielvue by id
        /// </summary>
        /// <param name="id">Id of AffectationMaterielvue</param>
        /// <returns>AffectationMaterielvue information</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(AffectationMaterielvueDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<AffectationMaterielvueDto>> GetAffectationMaterielvueAsync(Int64 id)
        {
            return Single(await QueryAsync(new GetAffectationMaterielvueQuery(id)));
        }

        /// <summary>
        /// Get all AffectationMaterielvues
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(PagedResults<AffectationMaterielvueDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<PagedResults<AffectationMaterielvueDto>>> GetAffectationMaterielvuesAsync([FromQuery] GetAffectationMaterielvuesQuery query)
        {
            return await QueryAsync<PagedResults<AffectationMaterielvueDto>>(query);
        }


    }
}