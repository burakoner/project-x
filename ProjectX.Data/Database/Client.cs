using ProjectX.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjectX.Data.Database;

public class Client
{
    [Key]
    public int Id { get; set; }

    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public string Sehir { get; set; }
    public string TcKimlikNo { get; set; }
    public EhliyetSinifi Ehliyet { get; set; }
    public string Not {get; set;}
}