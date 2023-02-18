using HotelList.Core.DTO.Countries;
using HotelList.Core.DTO.Hotels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelListing.API.Controllers.Hotels
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        public HotelsController()
        {
        }

        // GET: api/hotels/GetAll
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<IEnumerable<HotelResponse>>> GetAllHotels()
        {
            throw new NotImplementedException();
        }

        // GET: api/hotels/id
        [HttpGet("{HotelId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<HotelResponse>> GetHotelById(Guid HotelId)
        {
            throw new NotImplementedException();
        }

        // POST: api/hotels/
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<HotelResponse>> AddHotel(HotelAddRequest hotel)
        {
            throw new NotImplementedException();
        }

        // PUT: api/hotels/id
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<HotelResponse>> UpdateHotel(Guid HotelId)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/hotels/id
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<IActionResult> DeleteHotel(Guid HotelId)
        {
            throw new NotImplementedException();
        }
    }
}
