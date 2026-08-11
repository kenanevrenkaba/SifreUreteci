List<string> gecmisSifreler = new List<string>();

Console.WriteLine("Hoş Geldiniz");

string yinele = "";

while (yinele != "H")
{
    Console.Write("Kaç karakterden oluşan bir şifre üretmek istiyorsunuz? ");

    int sifreUzunlugu;

    while (!int.TryParse(Console.ReadLine(), out sifreUzunlugu) || sifreUzunlugu <= 0)
    {
        Console.WriteLine("Lütfen sayısal bir değer giriniz!");
        Console.Write("Kaç karakterden oluşan bir şifre belirlemek istiyorsunuz? ");
    }

    string karakterHavuzu = "0123456789";

    string buyukHarf = EvetHayirAl("Şifreniz 'Büyük Harf' içersin mi?");

    if (buyukHarf == "E")
    {
        karakterHavuzu += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    }

    string kucukHarf = EvetHayirAl("Şifreniz 'Küçük Harf' içersin mi?");

    if (kucukHarf == "E")
    {
        karakterHavuzu += "abcdefghijklmnopqrstuvwxyz";
    }

    string sembol = EvetHayirAl("Şifreniz 'Sembol' içersin mi?");

    if (sembol == "E")
    {
        karakterHavuzu += "!@#$%^&*()";
    }

    string uretilenSifre = SifreUret(sifreUzunlugu, karakterHavuzu);

    gecmisSifreler.Add(uretilenSifre);

    Console.Write("Üretilen şifreniz: " + uretilenSifre);

    if (sifreUzunlugu > 16 && buyukHarf == "E" && kucukHarf == "E" && sembol == "E")
    {
        Console.WriteLine(" -- Çok Güçlü Şifre");
    }

    else if ((sifreUzunlugu > 12 && buyukHarf == "E" && kucukHarf == "E" && sembol == "E") || sifreUzunlugu > 16)
    {
        Console.WriteLine(" -- Güçlü Şifre");
    }

    else if (sifreUzunlugu > 8)
    {
        Console.WriteLine(" -- Orta Şifre");
    }

    else
    {
        Console.WriteLine(" -- Zayıf Şifre");
    }


    yinele = EvetHayirAl("Başka şifre üretmek istiyor musunuz?");
}

Console.WriteLine("Güle Güle...");

int a = 0;
foreach (string eleman in gecmisSifreler)
{
    a++;
    Console.WriteLine(a + ". " + eleman);
}

static string EvetHayirAl(string soruMesaji)
{
    Console.Write(soruMesaji + " E/H: ");
    string cevap = Console.ReadLine().ToUpper();
    while (cevap != "E" && cevap != "H")
    {
        Console.WriteLine("Lütfen geçerli bir seçim yapınız.");
        Console.Write(soruMesaji + " E/H: ");
        cevap = Console.ReadLine().ToUpper();
    }

    return cevap; // Cevabı 'Main' metoduna geri gönderir
}

static string SifreUret(int uzunluk, string karakterHavuzu)
{
    string uretilen = "";
    Random rnd = new Random();
    for (int i = 0; i < uzunluk; i++)
    {
        int randomIndex = rnd.Next(0, karakterHavuzu.Length);
        uretilen += karakterHavuzu[randomIndex];
    }

    return uretilen; // Üretilen şifreyi geri gönderir
}