namespace SifreUreteci;



public class DosyaYoneticisi
{
    public static string Dosyala( List<string> gecmisSifreler, string uretilenSifre)
    {
        gecmisSifreler.Add(uretilenSifre);
        
        string uretDevam = Girdiler.EvetHayirAl("Başka şifre üretmek istiyor musunuz?");

        if (uretDevam == "H")
        {
            Console.WriteLine("Oturum boyunca " + gecmisSifreler.Count + " şifre ürettiniz.");

            int a = 0;
            foreach (string eleman in gecmisSifreler)
            {
                a++;
                Console.WriteLine(a + ". " + eleman);
            }

            string kaydet = Girdiler.EvetHayirAl("Şifrelerinizi sifreler.txt dosyasına kaydetmek ister misiniz?");

            if (kaydet == "E")
            {
                File.AppendAllLines("sifreler.txt", gecmisSifreler);
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