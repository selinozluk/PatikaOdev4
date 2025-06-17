using System;

namespace SwitchCaseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı hoş geldiniz diye karşılanıp, fiyat listesi yazdırılıyor
            Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Çilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");
            Console.WriteLine("Diğer bütün meyveler = 4 TL");

            //Kullanıcıdan meyve ismi girmesini istiyoruz
            Console.Write("Hangi meyveyi satın almak istersiniz?: (Elma/Armut/Çilek/Muz/Diğer)");
            
            /*ToLower kullanıldığında tüm harfleri küçük algılıyor ve ürün fiyatını döndürüyor
            fakat bu ifadeyi kullanmadığımızda algılamıyor ve hiçbir meyveyle uyuşmayarak fiyatı 4 TL kabul ediyor*/
            string fruit = Console.ReadLine().ToLower();


            // IF-ELSE YAPISI
            Console.WriteLine("[IF-ELSE ile Sonuç]");
            if (fruit == "elma" || fruit == "çilek") //meyve ismi elma veya çilek girilirse
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL"); //çıktı 2 TL olacak
            }
            else if (fruit == "armut" || fruit == "muz") //meyve ismi armut veya muz girilirse
            {
               Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL"); //çıktı 3 TL olacak
            }
            else //bu listedeki meyveler dışında bir meyve girilirse de
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL"); //fiyat 4 TL olarak yazdırılacak
            }

            //SWITCH-CASE YAPISI
            Console.WriteLine("[SWITCH-CASE ile Sonuç]");
            switch (fruit)
            {
                case "elma":
                case "çilek":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
                    break;

                case "armut":
                case "muz":
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
                    break;

                default:
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
                    break;
            }

        }
        /*Bu uygulamada sınırlı sayıda seçeneğimiz olduğu için switch-case yapısını kullanmak
         daha kolay olur, if-else genelde daha karmaşık ifadelerde kullanılır. */
    }
}