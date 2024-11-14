using Microsoft.AspNetCore.Mvc;
using PogettoFinale.Interfaces;
using PogettoFinale.Models;

namespace PogettoFinale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IRoomRepository _roomRepository;

        public HotelController(IHotelRepository hotelRepository, IRoomRepository roomRepository)
        {
            _hotelRepository = hotelRepository;
            _roomRepository = roomRepository;
        }

        // GET: api/Hotel
        [HttpGet]
        public async Task<IActionResult> GetHotels()
        {
            var hotels = await _hotelRepository.GetAll();
            return Ok(hotels);
        }


        // GET: api/Hotel/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHotel(int id)
        {
            var hotel = await _hotelRepository.GetById(id);
            return hotel == null ? NotFound() : Ok(hotel);
        }

        // GET: api/Hotel/5/rooms
        [HttpGet("{id}/rooms")]
        public async Task<IActionResult> GetRoomsForHotel(int id)
        {
            var rooms = await _roomRepository.GetRoomsByHotelId(id);
            return Ok(rooms);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchHotels([FromQuery] string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return BadRequest("Query cannot be empty.");
            }

            var hotels = await _hotelRepository.SearchHotels(query);

            if (!hotels.Any())
            {
                return NotFound("No hotels match your search criteria.");
            }

            return Ok(hotels);
        }

    }
}

