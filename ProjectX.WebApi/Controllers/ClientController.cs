using Microsoft.AspNetCore.Mvc;
using ProjectX.Data.Database;
using ProjectX.Data.Models;
using ProjectX.Data.Models.Requests;
using System.Linq;

namespace ProjectX.WebApi.Controllers
{
    [ApiController]
    [Route("clients")] 
    public class ClientController : ControllerBase
    {
        public ProjectXDbContext DbContext { get; set; }

        public ClientController(ProjectXDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

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
            => this.Ok(new ApiResponse(this.DbContext.Clients.ToList()));


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
    }
}
