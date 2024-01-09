namespace ProjectX.Data.Models.Requests
{
    public class RentACarRequest
    {
        public int VehicleId { get; set; }
        public int ClientId { get; set; }
        public int OperatorId { get; set; }
        public int GunSayisi { get; set; }
        public decimal GunlukKiraBedeli { get; set; }
        public decimal YakitMiktari { get; set; }
        public string Notlar { get; set; }
    }
}