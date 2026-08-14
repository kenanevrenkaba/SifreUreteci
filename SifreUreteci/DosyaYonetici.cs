namespace SifreUreteci;



public class DosyaYoneticisi
{
    public static string Dosyala( List<Sifre> gecmisSifreler, Sifre yeniSifre)
    {
        gecmisSifreler.Add(yeniSifre);
        string uretDevam = Girdiler.EvetHayirAl("Başka şifre üretmek istiyor musunuz?");

        if (uretDevam == "H")
        {
            Console.WriteLine("Oturum boyunca " + gecmisSifreler.Count + " şifre ürettiniz.");

            int a = 0;
            foreach (Sifre eleman in gecmisSifreler)
            {
                a++;
                Console.WriteLine(a + ". Şifre " + eleman.Metin + " | Güç Derecesi: " + eleman.GucDerecesi + " | Tarih: " + eleman.UretimTarihi);
            }

            string kaydet = Girdiler.EvetHayirAl("Şifrelerinizi sifreler.txt dosyasına kaydetmek ister misiniz?");
            
            int b = 0;
            if (kaydet == "E")
            {
                DateTime tarih = DateTime.Now;
                string oturumTarihi = tarih.ToString();
                
                List<string> kayitlar = new List<string>();
                
                kayitlar.Add("\n \nOturum Tarihi: " + oturumTarihi + "\n");
                
                foreach (Sifre s in gecmisSifreler)
                {
                    b++;
                    kayitlar.Add(b+". Şifre: " + s.Metin + " | Güç Derecesi: " + s.GucDerecesi + " | Tarih: " + s.UretimTarihi);
                }
               
                File.AppendAllLines("sifreler.txt", kayitlar);
                Console.WriteLine("Şifreleriniz 'sifreler.txt' dosyasına kaydedildi.");
            }

            string cevap = Girdiler.EvetHayirAl("Şifre geçmişini sıfırlamak ister misiniz?");

            if (cevap == "E")
            {
                gecmisSifreler.Clear();
                Console.WriteLine("Şifre geçmişini sıfırladınız.");
            }

            uretDevam = Girdiler.EvetHayirAl("Oturuma devam etmek istiyor musunuz?");
        }

        return uretDevam;
    }
}