//19010155 - Nabeel Jadwat
//ICE 4 - LAC 4
//Hotel API

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelApi.Models;
using HotelApi.Utilities;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HotelController : ControllerBase
    {
        List<Hotel> hotels = HotelListUtil.hotels;

        public HotelController() {
            if (hotels.Count == 0) {
                Hotel h1 = new Hotel(1, "Hilton Umhlanga", "https://www.hilton.com/en/hotels/durgigi-garden-inn-umhlanga-arch/", "Durban", 4, "https://www.hilton.com/im/en/DURGIGI/15377038/durgi-external-4.jpg?impolicy=crop&cw=4503&ch=3335&gravity=NorthWest&xposition=248&yposition=0&rw=424&rh=314");
                Hotel h2 = new Hotel(2, "Coastlands", "https://www.coastlands.co.za/", "Durban", 4, "https://www.coastlands.co.za/img/homepage-slider/slider-11.jpg");
                Hotel h3 = new Hotel(3, "Hilton Sandton", "https://www.hilton.com/en/hotels/jnbsatw-hilton-sandton/", "Johannesburg", 4, "https://www.hilton.com/im/en/JNBSATW/3064754/96662.jpg?impolicy=crop&cw=4752&ch=2184&gravity=NorthWest&xposition=0&yposition=491&rw=1240&rh=570");
                Hotel h4 = new Hotel(4, "Radisson Blu Hotel Waterfront", "https://www.radissonhotels.com/en-us/hotels/radisson-blu-cape-town-waterfront", "Cape Town", 4, "https://media.radissonhotels.net/image/radisson-blu-hotel-waterfront/exteriorview/16256-113963-f62721056_3xl.jpg?impolicy=HomeHero");

                hotels.Add(h1);
                hotels.Add(h2);
                hotels.Add(h3);
                hotels.Add(h4);
            }
        }

        [HttpGet]
        public List<Hotel> GetHotels() {
            return hotels;
        }

        [HttpGet]
        public Hotel GetHotel(string s) {
            return hotels.Where(h => h.Name.Contains(s)).FirstOrDefault();
        }

        [HttpPost]
        public void PostHotel(Hotel h) {
            hotels.Add(h);
        }











        /*

        // GET: api/Hotel
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Hotel>>> GetHotels()
        //{
        //    return await _context.Hotels.ToListAsync();
        //}

        // GET: api/Hotel/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hotel>> GetHotel(int id)
        {
            var hotel = await _context.Hotels.FindAsync(id);

            if (hotel == null)
            {
                return NotFound();
            }

            return hotel;
        }

        // PUT: api/Hotel/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotel(int id, Hotel hotel)
        {
            if (id != hotel.Id)
            {
                return BadRequest();
            }

            _context.Entry(hotel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Hotel
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Hotel>> PostHotel(Hotel hotel)
        //{
        //    _context.Hotels.Add(hotel);
        //    await _context.SaveChangesAsync();
//
        //    return CreatedAtAction("GetHotel", new { id = hotel.Id }, hotel);
        //}

        // DELETE: api/Hotel/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            var hotel = await _context.Hotels.FindAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }

            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HotelExists(int id)
        {
            return _context.Hotels.Any(e => e.Id == id);
        }

        */
    }
}
