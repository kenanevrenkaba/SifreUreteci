namespace SifreUreteci;

public class Girdiler
{
    public static string EvetHayirAl(string soruMesaji)
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

    public static int SayiAl(string soruMesaji)
    {
        int uzunluk;
        
        Console.Write(soruMesaji);
            
        while (!int.TryParse(Console.ReadLine(), out uzunluk) || uzunluk < 4)
        {
            Console.WriteLine("Şifreniz minimum 4 karakterden oluşmalıdır.");
            Console.WriteLine("Lütfen sayısal bir değer giriniz!");
            Console.Write("Kaç karakterden oluşan bir şifre belirlemek istiyorsunuz? ");
        }
        
        return uzunluk;

    }
    public static string OzelMetin (int sifreUzunlugu, string ozelMetinSecimi, string ozelMetin)
    {
        string ozelMetinDonus;
        
        if (ozelMetinSecimi == "E")
        {
            Console.WriteLine("En fazla " + (sifreUzunlugu - 1) + " haneli bir kelime girişi yapabilirsiniz.");
            Console.Write("Eklemek istediğiniz kelimeyi türkçe karakter (ç,ğ,ı,ö,ş,ü,Ç,Ğ,İ,Ö,Ş,Ü) kullanmadan giriniz: ");
            ozelMetin = Console.ReadLine();

            while (ozelMetin.Length >= sifreUzunlugu || ozelMetin.Any(c => "çğıöşüÇĞİÖŞÜ".Contains(c)))
            {
                Console.WriteLine("En fazla " + (sifreUzunlugu - 1) + " haneli bir kelime girişi yapabilirsiniz.");
                Console.Write("Eklemek istediğiniz kelimeyi türkçe karakter (ç,ğ,ı,ö,ş,ü,Ç,Ğ,İ,Ö,Ş,Ü) kullanmadan giriniz: ");
                ozelMetin = Console.ReadLine();
            }
            
        }
        
        return ozelMetin;
    }
}
