namespace SifreUreteci;

public class Sifre
{
    public string Metin { get; set; }
    public int Uzunluk { get; set; }
    public string GucDerecesi { get; set; }
    public DateTime UretimTarihi { get; set; }
    public DateTime Tarih { get; set; }

    public Sifre(string metin, int uzunluk, string gucDerecesi)
    {
        Metin = metin;
        Uzunluk = uzunluk;
        GucDerecesi = gucDerecesi;
        UretimTarihi = DateTime.Now;
        Tarih = DateTime.Now;
    }
}