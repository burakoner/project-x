using Microsoft.AspNetCore.Mvc;
using ProjectX.Data.Database;
using ProjectX.Data.Models;
using ProjectX.Data.Models.Requests;
using System.Linq;

namespace ProjectX.WebApi.Controllers
{
    [ApiController]
    [Route("vehicles")] 
    public class VehicleController : ControllerBase
    {
        public ProjectXDbContext DbContext { get; set; }

        public VehicleController(ProjectXDbContext dbContext)
        {
            this.DbContext = dbContext;
        }


        [HttpPost("add")]
        public IActionResult AddVehicle([FromBody] VehicleRequest request)
        {
            var vehicle = new Vehicle();
            vehicle.Marka = request.Marka;
            vehicle.Model = request.Model;
            vehicle.YakitTuru = request.YakitTuru;
            vehicle.Yil = request.Yil;
            vehicle.KiralananGun = 0;
            vehicle.Ehliyet = request.DrivingLisenceClass;
            vehicle.Not = request.Not;

            this.DbContext.Vehicles.Add(vehicle);
            this.DbContext.SaveChanges();

            return this.Ok(new ApiResponse(vehicle)); 
        }


        [HttpGet("list")]
        public IActionResult listVehicle()
        {
            var list = this.DbContext.Vehicles.ToList();
            return Ok(new ApiResponse(list));
        }
        [HttpGet("get")]
        public IActionResult GetVehicle([FromQuery] int id)
        {
            var vehicle = this.DbContext.Vehicles.FirstOrDefault(x => x.Id == id);
            if(vehicle == null)
            {
                return this.Ok(new ApiResponse(null, new ApiError(41, "Araç bulunamadı")));
            }

            return this.Ok(new ApiResponse(vehicle));
        }


        [HttpPost("update")]
        public IActionResult UpdateVehicle([FromBody] VehicleRequest request, [FromQuery] int id)
        {

            var vehicle = this.DbContext.Vehicles.FirstOrDefault(x => x.Id == id);
            if (vehicle == null)
            {
                return this.Ok(new ApiResponse(null, new ApiError(41, "Araç bulunamadı")));
            }

            vehicle.Marka = request.Marka;
            vehicle.Model = request.Model;
            vehicle.YakitTuru = request.YakitTuru;
            vehicle.Yil = request.Yil;
            vehicle.Ehliyet = request.DrivingLisenceClass;
            vehicle.Not = request.Not;

            this.DbContext.SaveChanges();

            return this.Ok(new ApiResponse(vehicle));
        }



    }
}
