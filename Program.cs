using System;

namespace Uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uygulama 

            // 1-) Girilen 2 sayıdan hangisi büyüktür ?
                // System.Console.Write("Sayı 1: ");
                // int sayi1 = int.Parse(Console.ReadLine());

                // System.Console.Write("Sayı 2: ");
                // int sayi2 = int.Parse(Console.ReadLine());

                // var sonuc = (sayi1 > sayi2) && (sayi2 > sayi1) ? "Sayı 1 Sayı 2'den bütüktür.":"Sayı 2 Sayı 1'den büyüktür.";
                // System.Console.WriteLine("Sonç: " +sonuc);
            // 2-) Parola ve email bilgisini isteyip doğruluğunu kontrol ediniz.

                // string _email = "info@sadikturan.com";
                // string _password = "13456";

                // Console.Write("Lütfen email adresinizi giriniz: ");
                // string email = Console.ReadLine();

                // Console.Write("Lütfen parolanızı giriniz: ");
                // string password = Console.ReadLine();

                // var bilgi = (email == _email) && (password == _password);
                // System.Console.WriteLine("Giriş Başarılı: " + bilgi);

                
            // 3-) Girilen bir sayının pozitif çift sayı olup olmadığını kontrol ediniz.

                // Console.Write("Sayı: ");
                // int sayi = int.Parse(Console.ReadLine());

                // var result = (sayi > 0) && (sayi % 2== 0);
                // System.Console.WriteLine("Sayı pozitif çift sayıdır: " +result);

            // 4-) Girilen 3 sayıyı büyüklük olarak karşılaştırınız.
                // System.Console.Write("Sayı 1: ");
                // int a = int.Parse(Console.ReadLine());

                // System.Console.Write("Sayı 2: ");
                // int b = int.Parse(Console.ReadLine());

                // System.Console.Write("Sayı 3: ");
                // int c = int.Parse(Console.ReadLine());

                // var result = (a > b ) && (a > c);
                // System.Console.WriteLine("En büyük sayı a: " + result);

                // result = ( b > a ) && (b > c);
                // System.Console.WriteLine("En büyük sayı b: " +result);

                // result = (c > a) && ( c > b);
                // System.Console.WriteLine("En büyük sayı c: "+result);
                // var result = ((a > b) && (a>c))?"A en büyük sayıdır": ((b>a) && (b>c)) ?"B en büyük sayıdır.": (c>a)&&(c>b)?"C en büyük sayıdır":"Hatalı bilgi";
                // System.Console.WriteLine(result);
            // 5-) Kullanıcıdan 2 vize (%60) ve final (%40) notunu alıp ortalama hesaplayınız.
             // Eğer ortalama 50 ve üstündeyse geçti değilse kaldı yazdırın.
                    // a-) Ortalama 50 olsa bile final notu en az 50 olmalıdır.
                    // b-) Finalden 70 alındığında ortalamanın önemi olmasın

                // System.Console.Write("Vize 1 : ");
                // int vize1 = int.Parse(Console.ReadLine());

                // System.Console.Write("Vize 2 : ");
                // int vize2 = int.Parse(Console.ReadLine());

                // System.Console.Write("Final :");
                // int final = int.Parse(Console.ReadLine());

                // var ortalama =((vize1 + vize2)/2)* 0.6 + (final *0.4);
                // // var result =(ortalama >= 50)?"Geçti":"Kaldı";
                // // var result = (ortalama >= 50) && (final >=50);
                // var result = (ortalama >= 50) || (final >=70);
                // System.Console.WriteLine("Ortalama: " +ortalama);
                // System.Console.WriteLine(result?"geçti":"kaldı");

                   
            // 6-) Kişinin ad, kilo ve boy bilgilerini alıp kilo indexlerini hesaplayınız
                    // Formül: (Kilo / boy uzunluğunun karesi)
                    // Aşağıdaki tabloya göre kişi hangi gruba girmektedir?
                    // 0-18.4   => Zayıf
                    // 18.5-24.9 => Normal
                    // 25.0-29.9 => Fazla Kilolu
                    // 30.0-34.9 => Şişman (Obez)

                System.Console.Write("Adınız: ");
                string name = Console.ReadLine();

                System.Console.Write("Kilonuz: ");
                float kilo = float.Parse(Console.ReadLine());

                System.Console.Write("Boy: ");
                float boy = float.Parse(Console.ReadLine());

                float vki = (kilo) / (boy*boy);
                var sonuc = ((vki>=0) && (vki<=18.4))?"Zayıfsınız":
                            ((vki>=18.5) && (vki<=24.9))?"Normal":
                            ((vki>=25.0) && (vki<=29.9))?"Fazla Kilolu":
                            ((vki>=30.0) && (vki<=34.9))?"Obez":"Geçersiz İşlem";

                System.Console.WriteLine(sonuc);
        }
    }
}
