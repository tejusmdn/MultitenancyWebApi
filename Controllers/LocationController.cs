using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MultitenancyWebApi.Controllers
{
    using MultitenancyWebApi.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly LocationService _locationService;

        public LocationController(LocationService locationService)
        {
            _locationService = locationService;
        }

        /// <summary>
        /// Gets the name of the region where the service is deployed.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            string serviceRegion;

            try
            {
                serviceRegion = this._locationService.GetServiceRegion();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            

            return Ok(serviceRegion);
        }
    }
}
