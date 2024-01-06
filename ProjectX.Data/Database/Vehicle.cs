using ProjectX.Data.Enums;
using ProjectX.Data.Models.Requests;
using System.ComponentModel.DataAnnotations;

namespace ProjectX.Data.Database;

public class Vehicle
{
    [Key]
    public int Id {get; set;}
    public string Marka {get; set;}
    public string Model {get; set; }
    public string YakitTuru { get; set; }
    public int Yil {get; set;}
    public int KiralananGun {get; set;}
    public EhliyetSinifi Ehliyet { get; set; }
    public string Not {get; set;}
}
