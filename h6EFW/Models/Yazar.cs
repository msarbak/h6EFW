namespace h6EFW.Models
{
    public class Yazar
    {
        public int YazarID { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }

        public ICollection<Kitap> Kitaplar { get; set; }
            
    }
}
