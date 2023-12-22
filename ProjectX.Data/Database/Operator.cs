using System.ComponentModel.DataAnnotations;

namespace ProjectX.Data.Database;

// Araç Kiralama Şirketinin Operatörleri
public class Operator
{
    [Key]
    public int Id { get; set; } 

    public string KullaniciAdi;
    public string KullaniciSifresi { get; set; }
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public string Email { get; set; }
}