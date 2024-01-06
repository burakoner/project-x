using Microsoft.AspNetCore.Mvc;
using ProjectX.Data.Database;
using ProjectX.Data.Models;
using ProjectX.Data.Models.Requests;
using System;
using System.Linq;

namespace ProjectX.WebApi.Controllers
{
    [ApiController]
    [Route("sale")]
    public class SaleController : ControllerBase
    {
        public ProjectXDbContext DbContext { get; set; }

        public SaleController(ProjectXDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        [HttpPost("rent")]
        public IActionResult AddClient([FromBody] RentACarRequest request)
        {
            if (request == null)
            {
                return Ok(new ApiResponse(null, new ApiError(999, "Request gövdesi boş")));
            }

            if (request.VehicleId <= 0)
            {
                return Ok(new ApiResponse(null, new ApiError(27, "VehicleId Hatalı")));
            }

            if (request.ClientId <= 0)
            {
                return Ok(new ApiResponse(null, new ApiError(27, "ClientId Hatalı")));
            }

            if (request.OperatorId <= 0)
            {
                return Ok(new ApiResponse(null, new ApiError(27, "OperatorId Hatalı")));
            }

            if (request.GunSayisi <= 0)
            {
                return Ok(new ApiResponse(null, new ApiError(27, "GunSayisi Hatalı")));
            }

            if (request.GunlukKiraBedeli <= 0)
            {
                return Ok(new ApiResponse(null, new ApiError(27, "GunlukKiraBedeli Hatalı")));
            }

            var @operator = this.DbContext.Operators.FirstOrDefault(x => x.Id == request.OperatorId);
            if (@operator == null)
            {
                return Ok(new ApiResponse(null, new ApiError(27, "Operatör Bulunamadı")));
            }

            var client = this.DbContext.Clients.FirstOrDefault(x => x.Id == request.ClientId);
            if (client == null)
            {
                return Ok(new ApiResponse(null, new ApiError(27, "Müşteri Bulunamadı")));
            }

            var vehicle = this.DbContext.Vehicles.FirstOrDefault(x => x.Id == request.VehicleId);
            if (vehicle == null)
            {
                return Ok(new ApiResponse(null, new ApiError(27, "Araç Bulunamadı")));
            }

            if (vehicle.Ehliyet != client.Ehliyet)
            {
                return Ok(new ApiResponse(null, new ApiError(27, "Müşterinin ehliyeti araç ehliyeti ile uyuşmuyor")));
            }

            var count = this.DbContext.Sales.Where(x => x.VehicleId == vehicle.Id && !x.TeslimAlindi).Count();
            if (count > 0)
            {
                return Ok(new ApiResponse(null, new ApiError(27, "Bu araç şu an başka bir müşteriye kiralanmış durumda")));
            }

            var sale = new Sale
            {
                VehicleId = vehicle.Id,
                ClientId = client.Id,
                OperatorId = @operator.Id,
                KiraBaslangic = DateTime.Now,
                KiraBitis = DateTime.Now.AddDays(request.GunSayisi),

                GunlukKiraBedeli = request.GunlukKiraBedeli,
                ToplamKiraBedeli = request.GunlukKiraBedeli * request.GunSayisi,
                YakitMiktari = request.YakitMiktari,
                Notlar = request.Notlar,
                TeslimAlindi = false
            };

            this.DbContext.Sales.Add(sale);
            this.DbContext.SaveChanges();

            return this.Ok(new ApiResponse(sale));
        }

        [HttpGet("list")]
        public IActionResult GetList()
        {
            var list = this.DbContext.Sales.ToList();
            return Ok(new ApiResponse(list));
        }

        [HttpPost("take")]
        public IActionResult Update([FromBody] TakeACarRequest request)
        {
            var sale = this.DbContext.Sales.FirstOrDefault(x => x.Id == request.SaleId);
            if (sale == null)
            {
                return Ok(new ApiResponse(null, new ApiError(999, "Böyle bir satış yok")));
            }

            sale.TeslimAlindi = true;
            sale.Notlar = request.Notlar;
            this.DbContext.SaveChanges();
            return Ok(new ApiResponse(sale));
        }
    }
}

