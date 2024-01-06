using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProjectX.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectX.Data.Models.Requests
{
    public class TakeACarRequest
    {
        public int SaleId { get; set; }
        public string Notlar { get; set; }
        
    }
}