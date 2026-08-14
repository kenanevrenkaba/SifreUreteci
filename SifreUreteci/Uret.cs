namespace SifreUreteci;

public class Uret
{
    public static string SifreUret(int uzunluk, string karakterHavuzu, string ozelMetin)
    {
        string uretilen = "";
        Random rnd = new Random();
        for (int i = 0; i < uzunluk; i++)
        {
            int randomIndex = rnd.Next(0, karakterHavuzu.Length);
            uretilen += karakterHavuzu[randomIndex];
        }
        
        Random urt = new Random();
        int eklemeIndex = urt.Next(0, uretilen.Length + 1);
        uretilen = uretilen.Insert(eklemeIndex, ozelMetin);
        
        return uretilen; // Üretilen şifreyi geri gönderir
    }
}