using Microsoft.AspNetCore.Mvc;
using ProjectX.Data.Database;
using ProjectX.Data.Models;
using ProjectX.Data.Models.Requests;
using System.Linq;

namespace ProjectX.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class OperatorController : ControllerBase
    {
        public ProjectXDbContext DbContext { get; set; }

        public OperatorController(ProjectXDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        [HttpGet("")]
        public IActionResult Get()
        {

            return this.Ok(this.DbContext.Operators);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (string.IsNullOrEmpty(request.Email))
            {
                var error = new ApiError();
                error.Code = 27;
                error.Message = "Email is required";

                var response = new ApiResponse();
                response.Error = error;

                return this.Ok(response);
            }

            if (string.IsNullOrEmpty(request.Password))
            {
                var error = new ApiError();
                error.Code = 35;
                error.Message = "Password is required";

                var response = new ApiResponse();
                response.Error = error;

                return this.Ok(response);
            }

            var user = this.DbContext.Operators.FirstOrDefault(x => x.Email == request.Email && x.KullaniciSifresi == request.Password);
            if (user == null)
            {
                return this.Ok(new ApiResponse(null, new ApiError(41, "Kullanıcı bulunamadı")));
            }

            return this.Ok(new ApiResponse(user));
        }

        [HttpGet("info")]
        public IActionResult GetOperator( int id)
        {
            var user = this.DbContext.Operators.Where(x => x.Id == id).FirstOrDefault();
            if (user == null)
            {
                return this.Ok(new ApiResponse(null, new ApiError(41, "Kullanıcı bulunamadı")));
            }

            return this.Ok(new ApiResponse(user));
        }
    }
}
