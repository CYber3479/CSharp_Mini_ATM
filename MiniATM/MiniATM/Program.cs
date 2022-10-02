using System;

namespace MiniATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            /*
            kullancıya soracağız nasıl bir işlem yapmak istediğini
            1-bakiye görüntüleme
            2-para çekme
            3-para yatırma
            q ya basarsa çıkış yaptıracağız
            */

            Console.WriteLine("ATM ye hoşgeldiniz!");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");
            string secim = Console.ReadLine();

            if(secim=="1")
            {
                Console.WriteLine("Şu anki bakiyeniz" + bakiye);
                Console.ReadLine();

            }
            else if(secim=="2")
                {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz.");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                if (cekilecek_tutar<=bakiye)
                {
                    Console.WriteLine("Yeni bakiyeniz:" + (bakiye - cekilecek_tutar));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezseniz.");
                    Console.ReadLine();
                }

            }
            else if(secim=="3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz.");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni bakiyeniz:"+(bakiye+yatirilacak_tutar));
                Console.ReadLine();
            }
            else if(secim=="q")
            {
                Console.WriteLine("ATM'den çıkış yapılıyor...");
                Console.WriteLine("Çıkış yapıldı.İyi günler...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                Console.ReadLine();
            }
        }
    }
}
