using Microsoft.AspNetCore.Mvc;
using ProjectX.Data.Database;
using ProjectX.Data.Models;
using ProjectX.Data.Models.Requests;
using System.Collections.Generic;
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








        // Muhammmmeeeeeeeeeeeeeeeeeeeeeeeeeet !!!

        /*
        [HttpPost("add")]
        public IActionResult AddClient([FromBody] ClientAddRequest request)
        {
            if(request == null)
            {
                return Ok(new ApiResponse(null, new ApiError(999, "Request gövdesi boş")));
            }

            if (string.IsNullOrEmpty(request.Name))
            {
                return Ok(new ApiResponse(null, new ApiError(27, "İsim alanı boş")));
            }

            if(string.IsNullOrEmpty(request.Surname))
            {
                return Ok(new ApiResponse(null, new ApiError(35, "Soyisim alanı boş")));
            }

            var client = new Client();
            client.Adi = request.Name;
            client.Soyadi = request.Surname;
            client.Sehir = request.City;
            client.TcKimlikNo = request.Identity;
            client.Ehliyet = request.DrivingLisenceClass;
            client.Not = request.Notes;

            this.DbContext.Clients.Add(client);
            this.DbContext.SaveChanges();

            return this.Ok(new ApiResponse(client));
        }


        [HttpGet("list")]
        public IActionResult GetClients()
        {
            var list = this.DbContext.Clients.ToList();
            return this.Ok(new ApiResponse(list));
        }


        [HttpGet("get")]
        public IActionResult GetClient([FromQuery] int id)
        {
            var client = this.DbContext.Clients.FirstOrDefault(x => x.Id == id);
            if(client == null)
            {
                return this.Ok(new ApiResponse(null, new ApiError(41, "Müşteri bulunamadı")));
            }

            return this.Ok(new ApiResponse(client));
        }

        [HttpPost("update")]
        public IActionResult UpdateClient([FromBody] ClientEditRequest request)
        {
            if (request == null)
            {
                return Ok(new ApiResponse(null, new ApiError(999, "Request gövdesi boş")));
            }

            if (string.IsNullOrEmpty(request.Name))
            {
                return Ok(new ApiResponse(null, new ApiError(27, "İsim alanı boş")));
            }

            if (string.IsNullOrEmpty(request.Surname))
            {
                return Ok(new ApiResponse(null, new ApiError(35, "Soyisim alanı boş")));
            }

            var client = this.DbContext.Clients.FirstOrDefault(x => x.Id == request.Id);
            if (client == null)
            {
                return this.Ok(new ApiResponse(null, new ApiError(41, "Müşteri bulunamadı")));
            }

            client.Adi = request.Name;
            client.Soyadi = request.Surname;
            client.Sehir = request.City;
            client.TcKimlikNo = request.Identity;
            client.Ehliyet = request.DrivingLisenceClass;
            client.Not = request.Notes;

            this.DbContext.SaveChanges();

            return this.Ok(new ApiResponse(client));
        }
        */
    }
}
