using Microsoft.EntityFrameworkCore;
using ProjectX.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.Desktop.Models;

public class SatisDetayi : Sale
{
    public string ClientName { get; set; }
    public string ClientSurname { get; set; }

    public string AracMarka { get; set; }
    public string AracModel { get; set; }
    public int AracYil { get; set; }

    public SatisDetayi() { }
    public SatisDetayi(Sale sale)
    {
        this.Id = sale.Id;
        this.VehicleId = sale.VehicleId;
        this.ClientId = sale.ClientId;
        this.OperatorId = sale.OperatorId;
        this.KiraBaslangic = sale.KiraBaslangic;
        this.KiraBitis = sale.KiraBitis;
        this.GunlukKiraBedeli = sale.GunlukKiraBedeli;
        this.ToplamKiraBedeli = sale.ToplamKiraBedeli;
        this.YakitMiktari = sale.YakitMiktari;
        this.Notlar = sale.Notlar;
        this.TeslimAlindi = sale.TeslimAlindi;
    }
}