using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectX.Data.Database;

public class Sale 
{
    [Key]
    public int Id { get; set; }
    public int VehicleId { get; set; }
    public int ClientId { get; set; }
    public int OperatorId { get; set; }
    public DateTime KiraBaslangic { get; set; }
    public DateTime KiraBitis { get; set; }

    [Precision(10,2)]
    public decimal GunlukKiraBedeli { get; set; }
    [Precision(10,2)]
    public decimal ToplamKiraBedeli { get; set; }
    [Precision(3,2)]
    public decimal YakitMiktari { get; set; } // 1: FULL, 0.5 Yarım Depo, 0.25 Çeyrek 
    public string Notlar { get; set; }
    public bool TeslimAlindi { get; set; }
}

// Domates biber patlıcan, bütün dünyam karardı !
