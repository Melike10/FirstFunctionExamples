// See https://aka.ms/new-console-template for more information
using System;
class Program
{
     static void Main()
    {
        Console.WriteLine("Sevdiğim şarkıdan bir kuple :\n\n ");
        MySong();

        Console.WriteLine( "----------------------------------");
        int kalan = Mod2Int();
        Console.WriteLine("Mod2Int methodunun çalışması sonucu çıkan sayı = "+kalan);

        Console.WriteLine("----------------------------------");
        Console.WriteLine("İki sayi giriniz.");
        Console.Write("1. sayı = ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("2. sayı = ");
        int b = Convert.ToInt32(Console.ReadLine());
        int res=MultiplyInt(a, b);
        Console.WriteLine(a+" ve "+ b +" sayılarının çarpımı "+ res+" eşittir.");

        Console.WriteLine("----------------------------------");
        Console.WriteLine("İsim Soyisim giriniz.");
        Console.Write("İsim:  ");
        string ad = Console.ReadLine();
        Console.Write("Soy İsim:  ");
        string soyad= Console.ReadLine();
        Greetings(ad, soyad);



    }
    //void method
    public static void MySong()
    {
        Console.WriteLine("Maybe I’m foolish\r\nMaybe I’m blind\r\nThinkin’ I can see through this\r\nAnd see what’s behind\r\nGot no way to prove it\r\nSo maybe I’m lyin’\r\n\r\nBut I’m only human after all\r\nI’m only human after all\r\nDon’t put your blame on me\r\nDon’t put your blame on me");
    }

    //geriye tam sayı döndüren method
    public static int Mod2Int() {
    Random random = new Random();
        int sayi = random.Next();
        int kalan = sayi % 2;
        return kalan;
    }

    // parametre aldığı iki sayıyı dönen method
    public static int MultiplyInt(int a,int b)
    {
        return a * b;
    }
    // parmetre alıp geriye değer döndirmeyen method
    public static void Greetings(string ad,string soyad)
    {
        Console.WriteLine("Hoş Geldiniz! " + ad + " " + soyad);
    }
}
