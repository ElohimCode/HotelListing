using HotelList.Core.DTO.Countries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelListing.API.Controllers.Countries
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        public CountriesController()
        {
        }

        // GET: api/countries/GetAll
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<IEnumerable<CountryResponse>>> GetAllCounries()
        {
            throw new NotImplementedException();
        }

        // GET: api/countries/id
        [HttpGet("{CountryId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<CountryResponse>> GetCountryById(Guid CountryId)
        {
            throw new NotImplementedException();
        }

        // POST: api/countries/
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<CountryResponse>> AddCounry(CountryAddRequest country)
        {
            throw new NotImplementedException();
        }

        // PUT: api/countries/id
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<CountryResponse>> UpdateCounry(Guid CountryId)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/countries/id
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<IActionResult> DeleteCounry(Guid CountryId)
        {
            throw new NotImplementedException();
        }
    }
}
