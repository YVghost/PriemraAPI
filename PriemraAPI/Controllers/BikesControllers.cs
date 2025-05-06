using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PriemraAPI.Models;
using PriemraAPI.Repository;

namespace PriemraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikesControllers : ControllerBase
    {
        private BikeRepository _bikeRepository;
        public BikesControllers()
        {
            _bikeRepository = new BikeRepository();
        }

        [HttpGet]
        public IEnumerable<Bike> obtenerListaBike()
        {
            var bikes = _bikeRepository.obtenerListaBikes();
            return bikes;
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult obtenerBike(int id)
        {
            try
            {
                var bike = _bikeRepository.obtenerBike(id);
                return Ok(bike);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }
    }
}
