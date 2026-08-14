using SifreUreteci;

List<string> gecmisSifreler = new List<string>();

Console.WriteLine("Hoş Geldiniz");

string yinele = "";

while (yinele != "H")
{
    int sifreUzunlugu = Girdiler.SayiAl("Kaç karakterden oluşan bir şifre üretmek istiyorsunuz? ");

    string karakterHavuzu = "0123456789";

    string buyukHarf = Girdiler.EvetHayirAl("Şifreniz 'Büyük Harf' içersin mi?");

    if (buyukHarf == "E")
    {
        karakterHavuzu += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    }

    string kucukHarf = Girdiler.EvetHayirAl("Şifreniz 'Küçük Harf' içersin mi?");

    if (kucukHarf == "E")
    {
        karakterHavuzu += "abcdefghijklmnopqrstuvwxyz";
    }

    string sembol = Girdiler.EvetHayirAl("Şifreniz 'Sembol' içersin mi?");

    if (sembol == "E")
    {
        karakterHavuzu += "!@#$%^&*()";
    }

    string ozelMetin = "";

    string ozelMetinSecimi = Girdiler.EvetHayirAl("Şifrenize özel bir kelime eklemek ister misiniz?");

    ozelMetin = Girdiler.OzelMetin(sifreUzunlugu, ozelMetinSecimi, ozelMetin);

    string uretilenSifre = Uret.SifreUret((sifreUzunlugu - ozelMetin.Length), karakterHavuzu, ozelMetin);

    //DosyaYöneticisi.dosyala(gecmisSifreler, uretilenSifre, ozelMetin);

    Console.Write("Üretilen şifreniz: " + uretilenSifre);

    string gucDerecesi = SifreGucuHesapla.GucHesapla(uretilenSifre, sifreUzunlugu, ozelMetin, ozelMetinSecimi);
    Console.WriteLine(" -- " + gucDerecesi);

    yinele = DosyaYoneticisi.Dosyala(gecmisSifreler, uretilenSifre);
}

Console.WriteLine("Güle Güle...");

