Console.WriteLine("Hoş Geldiniz");

string yinele = "";
    
while (yinele != "N")
{
    Console.Write("Kaç karakterden oluşan bir şifre belirlemek istiyorsunuz? ");
        
    string giris = (Console.ReadLine());

    while (int.TryParse(giris, out int sifreUzunlugu) && yinele != "N")
    {
        string karakterHavuzu = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";

        string uretilenSifre = "";

        Random rnd = new Random();

        for (int i = 0; i < sifreUzunlugu; i++)
        {
            int randomIndex = rnd.Next(0, karakterHavuzu.Length);

            uretilenSifre += karakterHavuzu[randomIndex];
        }

        Console.WriteLine("Üretilen şifreniz: " + uretilenSifre);
        Console.Write("Başka şifre üretmek istiyor musunuz? Y/N: ");
        string cevap = Console.ReadLine();
        yinele = cevap.ToUpper();
    }
    
    Console.WriteLine("Lütfen sayısal bir değer giriniz!");
}

Console.WriteLine("Güle Güle...");

