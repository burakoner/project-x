using ProjectX.Data.Database;
using ProjectX.Data.Enums;
using System;
using System.Linq;

namespace ProjectX.Sandbox;

internal class Program
{
    static void Main(string[] args)
    {

        var db = new ProjectXDbContext();

        /** /
        var yeniMusteri = new Client();
        yeniMusteri.Adi = "Muhammed";
        yeniMusteri.Soyadi = "Yılmaz";
        yeniMusteri.Sehir = "Sakarya";
        yeniMusteri.TcKimlikNo = "11111111";
        yeniMusteri.Ehliyet = EhliyetSinifi.B;
        yeniMusteri.Not = "iyi bir çocuktu";

        db.Clients.Add(yeniMusteri);
        db.SaveChanges();
        /* */

        var yeniMusteri2 = new Client
        {
            Adi = "Ahmet",
            Soyadi = "Savaş",
            Sehir = "Ürgüp",
            TcKimlikNo = "33333333333",
            Ehliyet = EhliyetSinifi.E,
            Not = "Batuhan düşkünü DAYI"
        };


        //db.Clients.Add(yeniMusteri2);
        //db.SaveChanges();











        var musteriler01 = db.Clients.ToList();
        var musteriler02 = db.Clients.Where(x => x.Adi == "Ahmet").ToList();
        var musteri03 = db.Clients.FirstOrDefault(x => x.Id == 5);
        var musteri04 = db.Clients.FirstOrDefault(x => x.TcKimlikNo == "11111111111");
        var musteri05 = db.Clients.FirstOrDefault(x => x.TcKimlikNo == "33333333333");

        musteri05.Adi = "Mehmet";
        db.Clients.Remove(musteri05);
        db.SaveChanges();





        Console.ReadLine();
    }
}
