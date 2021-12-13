using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCD_SystemIODirectoryIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //YeniKlasorOlustur("c:\\Network Akademi");
            //KlasorKontrolu("c:\\Network Akademi");
            //KlasorSilme("c:\\aa");
            //KlasorTasima("c:\\Network", "c:\\Network Akademi\\Network");
            Odev1();
        }
        static void YeniKlasorOlustur(string path)
        {
            DirectoryInfo DI = Directory.CreateDirectory(path);
        }
        static bool KlasorKontrolu(string path)
        {
            bool kontrol = Directory.Exists(path);
            return kontrol;
        }
        static void KlasorSilme(string path)
        {
            Directory.Delete(path, true);
        }
        static void KlasorTasima(string source, string target)
        {
            Directory.Move(source, target);
        }

        static void Odev1()
        {
            //C sürücüsü içerisinde Network Akademi adında bir klasör oluşturun. Oluşturmadan önce varlık kontrolü yapın. Eğer klasör varsa silin.
            //Silerken yine kullanıcıdan silmek istiyor musunuz diye E/H kontrolü sağlayın. Daha sonra oluşturun. Klasör yoksa oluşturun fakat adımların bilgisini ekrana yazdırın.

            
            if (KlasorKontrolu("c:\\Network Akademi"))
            {
                Console.WriteLine("Klasör Bulunmakta Silmek ister misiniz? (e/h)");
                char choice = char.Parse(Console.ReadLine());
                if (char.ToLower(choice) == 'e')
                {
                    KlasorSilme("c:\\Network Akademi");
                    Console.WriteLine("Klasör silindi.");
                }
                else
                {
                    Console.WriteLine("Bulunan klasör silinmeyecek.");
                }
            }
            else
            {
                YeniKlasorOlustur("c:\\Network Akademi");
                Console.WriteLine("Yeni klasör oluşturuldu.");
            }
            
        }
    }
}
