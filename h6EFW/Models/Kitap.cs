namespace h6EFW.Models
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }

        public Yazar Yazar { get; set; }
    }
}
