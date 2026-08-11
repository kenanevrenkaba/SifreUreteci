Console.WriteLine("Hoş Geldiniz");

string yinele = "";

while (yinele != "H")
{
    Console.Write("Kaç karakterden oluşan bir şifre belirlemek istiyorsunuz? ");

    int sifreUzunlugu;

    while (!int.TryParse(Console.ReadLine(), out sifreUzunlugu) || sifreUzunlugu <= 0)
    {
        Console.WriteLine("Lütfen sayısal bir değer giriniz!");
        Console.Write("Kaç karakterden oluşan bir şifre belirlemek istiyorsunuz? ");
    }

    string karakterHavuzu = "0123456789";

    Console.Write("Şifreniz 'Büyük Harf' içersin mi? E/H: ");
    string buyukHarf = Console.ReadLine().ToUpper();

    while (buyukHarf != "E" && buyukHarf != "H")
    {
        Console.WriteLine("Lütfen geçerli bir seçim yapınız.");
        Console.Write("Şifreniz 'Büyük Harf' içersin mi? E/H: ");
        buyukHarf = Console.ReadLine().ToUpper();
    }

    if (buyukHarf == "E")
    {
        karakterHavuzu += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    }

    Console.Write("Şifreniz 'Küçük Harf' içersin mi? E/H: ");
    string kucukHarf = Console.ReadLine().ToUpper();

    while (kucukHarf != "E" && kucukHarf != "H")
    {
        Console.WriteLine("Lütfen geçerli bir seçim yapınız.");
        Console.Write("Şifreniz 'Küçük Harf' içersin mi? E/H: ");
        kucukHarf = Console.ReadLine().ToUpper();
    }

    if (kucukHarf == "E")
    {
        karakterHavuzu += "abcdefghijklmnopqrstuvwxyz";
    }

    Console.Write("Şifreniz 'Sembol' içersin mi? E/H: ");
    string sembol = Console.ReadLine().ToUpper();

    while (sembol != "E" && sembol != "H")
    {
        Console.WriteLine("Lütfen geçerli bir seçim yapınız.");
        Console.Write("Şifreniz 'Sembol' içersin mi? E/H: ");
        sembol = Console.ReadLine().ToUpper();
    }

    if (sembol == "E")
    {
        karakterHavuzu += "!@#$%^&*()";
    }

    string uretilenSifre = "";

    Random rnd = new Random();

    for (int i = 0; i < sifreUzunlugu; i++)
    {
        int randomIndex = rnd.Next(0, karakterHavuzu.Length);

        uretilenSifre += karakterHavuzu[randomIndex];
    }

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


    Console.Write("Başka şifre üretmek istiyor musunuz? E/H: ");
    string cevap = Console.ReadLine().ToUpper();

    while (cevap != "E" && cevap != "H")
    {
        Console.WriteLine("Lütfen geçerli bir seçim yapınız.");
        Console.Write("Başka şifre üretmek istiyor musunuz? E/H: ");
        cevap = Console.ReadLine().ToUpper();
    }

    yinele = cevap;
}

Console.WriteLine("Güle Güle...");