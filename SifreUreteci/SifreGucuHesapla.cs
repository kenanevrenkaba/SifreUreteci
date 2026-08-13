namespace SifreUreteci;

public class SifreGucuHesapla
{
    public static string GucHesapla(string uretilenSifre, int sifreUzunlugu, string ozelMetin, string ozelMetinSecimi)
    {
        int puan = 0;

        puan += uretilenSifre.Length * 5;

        if (uretilenSifre.Any(Char.IsUpper))
        {
            puan += 15;
        }

        if (uretilenSifre.Any(Char.IsLower))
        {
            puan += 10;
        }

        if (uretilenSifre.Any(c => !Char.IsLetterOrDigit(c)))
        {
            puan += 25;
        }

        if (ozelMetinSecimi == "E")
        {
            int karmasikKarakter = ozelMetin.Count(c => !char.IsLetter(c));

            if (sifreUzunlugu / 2 <= ozelMetin.Length && karmasikKarakter < 2)
            {
                puan -= 30;
            }

            if (karmasikKarakter > 2)
            {
                puan += 20;
            }
        }

        if (puan >= 100)
        {
            return "Çok güçlü şifre.";
        }

        if (puan >= 80)
        {
            return "Güçlü şifre";
        }

        if (puan >= 45)
        {
            return "Orta seviye şifre";
        }

        else
        {
            return "Zayıf şifre.";
        }
    }
}