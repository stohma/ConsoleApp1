using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyDersleri
{
    internal class gyildiz
    {
        static void Main(string[] args)
        {
            #region Yorum Satırı/ Region
            /*Kodun niteliğini, anlaşılabilirliğini, kalitesini arttırabilmek için kullanılır.
             * Kritik noktalarda ve özet olarak kodlar izah edilir
             * İstenilen her yerde yorum yazılabilir fakar kod konseptini ve semantik akışı bozulmaması kaydıyla
             * 
             */

            /* Region
             * Kod dosyaları kategorik hale getirilir
             * Developer'ın yazmış olduğu kodu daha net görmesini sağlar
             */
            #endregion

            // TODO: burada 1'den 10'a kadar yazılmalıdır

            #region aritmetik operatörler
            // Aritmetik operatörler, iki sayısal değer üzerindeişlem yapan operatörler olduklarından işlem neticesinde geriye "uygun sonuç" dönerler




            #endregion

            #region inceleme1
            // int result = 3 + 5;
            #endregion

            #region inceleme2
            //int x = 3;
            //int y = 5;
            //int result = x * y;
            #endregion

            // aynı türde olan sayısal değer üzerinde işlem yaparken sonuç türü aynı olacaktır

            #region inceleme3
            //double s1 = 123;
            //double s2 = 456;
            //double result = s1 + s2;
            #endregion

            #region inceleme4
            //decimal a = 2133413241;
            //decimal b = 314141234;
            //decimal result = a % b;
            #endregion

            #region 2 farklı değerde 4işlem
            //2 farklı türde sayısal işlem sonucu büyük olan türe göre olacaktır

            /* int a = 9;
             double b = 2.3;

             var c = a + b; */


            #endregion

            #region byte*int

            /* int a = 3;
            byte b = 122;
            var c = a - b; //int */
            #endregion

            #region byte*byte mülakat sorusu
            // normalde 2 aynı türdeki sayısal değer üzerinde yapılan aritmetik işlem neticesinde sonuc ayni turde doncekken, bu 2 deger byte ise sonuc her zaman int 'e donecektir

            /* byte a = 11;
             byte b = 23;

             var c = a + b; */
            #endregion

            #region Karşılaştırma Operatörlerinin Geri Dönüş Değerleri
            // karsilastirma operatorleri geriye sürekli olarak bool türde bir değer döndürür
            /* int a = 11;
             int b = 10;

            bool c=  a < b; */
            #endregion

            #region if yapısı
            /* switchCase elimizdeki bir değerin sadece eşitlik durumunu kontrol eden/ kıyaslayan bir akış kontrol mekanizmasıdır. Eşit olmayanlar değerlerde kullanılamaz. <,> gibi kıyaslamalarda kullanılmaz bunu if ile yaparız
             * switchcase bilinmeden if bilinse yeterlidir. bütün yapıların öğrenilmesi amacıyla switchcase de gerekli.
             * tek sonuç döndürmede daha şık, kolay olur
                        
             * If yapılanması, elimizdeki bir değerin eşitlik duurmu dahil bütün karşılaştırmaları yapmamızı sağlayan ve sonuca göre akışı yönlendirmemiz olanak veren bir yapılanmadır
             * Prototip: 
             * if (... (koşul)) 
             * //koşul doğru ise burası tetiklenir. false ise compiler if scop'undan çıkacak ve yoluna devam edecektir. 
             * // koşul her daim bool türde olmalıdır
             * // Karşılaştırma operatörleri ve mantıksal operatörlerin hepsi burada kullanılabilir
             * {
             * }
             */
            /* bool medeniHal = true;
            if (medeniHal==true)
            {
                Console.WriteLine("Allah tek yastıkta gocatsın...");
            } */
            // if yapılanması tek başına kullanılıyorsa sadece şarta bağlı çalışılacak koda odaklanır. koşul true olmasaydı bu if i pas geçerek yoluna devam edecekti. bu koşulda herhangi bir çıktı olmayacaktı

            #endregion

            #region if senaryo1
            /* int i = 10;
              if (i == 10)
              {
                  Console.WriteLine("merhaba");
              }
              Console.WriteLine("dünya"); //önce if komutu sorgulanacak. true ise oradaki değeri alacak ve sonra yoluna devam edecek */

            /* int i = 10;
            if (i != 10)
            {
                Console.WriteLine("merhaba");
            }
            Console.WriteLine("dünya"); // if şu an çalışmayacağından sadece "dünya" çıktı olarak gelecektir */
            #endregion

            #region if senaryo2
            //Kullanıcı adı ve şifre doğru girildiğinde "Giriş başarılı", yanlış girildiğinde "Kullanıcı adı veya Şifreniz hatalı" mesaj veren Console uygulaması yapın

            /* string username = "ece";
            string password = "1234";

            Console.Write("Kullanıcı adı: ");
            string girilenUsername = Console.ReadLine();
            
            Console.Write("Parola: ");
            string girilenPassword = Console.ReadLine();

            if (username == girilenUsername && password== girilenPassword)
            {
                Console.WriteLine("giriş yapıldı");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya Şifreniz hatalı");
            } */

            /* Console.Write("Kullanıcı adı: ");
            string username = Console.ReadLine();

            Console.Write("Parola: ");
            string password = Console.ReadLine();

            if (username == "ece" && password == "1234")
            {
                Console.WriteLine("Giriş yapıldı");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya Şifreniz hatalı");
            }  */

            //veya bu örnekte tek konseptlik iş yaptığımızdan {} (scope) kullanılması zorunlu değil. 

            /* Console.Write("Kullanıcı adı: ");
            string username = Console.ReadLine();

            Console.Write("Parola: ");
            string password = Console.ReadLine();

            if (username == "ece" && password == "1234")
                Console.WriteLine("Giriş yapıldı");
            else
                Console.WriteLine("Kullanıcı adı veya Şifreniz hatalı");  */

            // ! ile soruyu tersten sorarak girdilerin yerlerini değiştirebiliriz
            /* Console.Write("Kullanıcı adı: ");
            string username = Console.ReadLine();

            Console.Write("Parola: ");
            string password = Console.ReadLine();

            if (!(username == "ece" && password == "1234"))
                Console.WriteLine("Kullanıcı adı veya Şifreniz hatalı");
            else
                Console.WriteLine("Giriş yapıldı");
            */
            // veya

            /* Console.Write("Kullanıcı adı: ");
            string username = Console.ReadLine();

            Console.Write("Parola: ");
            string password = Console.ReadLine();

            Console.WriteLine(username == "ece" && password =="1234" ? "Giriş yapıldı" : "Kullanıcı adı veya Şifreniz hatalı");
            */

            #endregion

            #region if kritik
            /* bool medeniHal = true;

            // if (medeniHal == true) //bool türdeki değişkenlerin değerleri zaten bool olacağından karşılaştırma operatörü kullanmak zorunda değiliz. o yüzden aşağıdaki şekilde de yazabiliriz. tersini alacaksak başında ! kullanmamız yeterli
            if (medeniHal)
            {
                Console.WriteLine("Hayırlı olsun");
            }
            */
            #endregion

            #region if/else yapısı
            /* if yapısı şarta göre kodun çalışıp çalışmayacağını belirleyen yapılanma
             * 
             * if else yapısı --> Şarta göre kodun çalışıp şartın olmadığı durumlarda bir başka kodun çalışmasını belirleyen bir yapılanmadır. yani sonuç vardır. Şartın olumsuz/değil durumu da belirlenmiş olur
             * if (...) //Koşul
             * {
             * * Koşul true ise burası
             * }
             * else 
             * {
             * * False ise burası tetiklenecektir
             * }
             * * if bloğunda else varsa şartın false olması durumunda kesinlikle else blogu tetiklenir
             * * hem if hem else yapıları aynı anda tetiklenemez. mantık ve matematiğe aykırı durumdur
             * * yani if else yapılanmasında şart doğru olduğunda sadece if, yanlış olduğunda ise sadece else blogu tetiklenir
             */
            #endregion

            #region if/else örnek
            /* int i = 10;
            if (i > 5)
            {
                Console.WriteLine("i, 5 ten büyük");
            }
            else
            {
                Console.WriteLine("i, 5 ten küçük");
            }
            */
            #endregion

            #region if else kritik1

            /* int i = 10;
             if (i == 10)
             {
                 Console.WriteLine("i degeri 10");
             }
             else
             {
                 Console.WriteLine("i degeri 10 degil");
             }
            */
            //veya
            /* int i = 10;
            if (i != 10)
            {
               Console.WriteLine("i degeri 10 degil"); 
            }
            else
            {
                Console.WriteLine("i degeri 10");
            }
            */
            #endregion

            #region if else kritik2
            /* if else yapılanmasındaki if ve else bloklarında aynı işlemleri yapacaksak eğer, bunları bu şekilde blok içerisinde tekrarlı şekilde YAPMAMAMIZ gerekmektedir.
            * Scope dışına yazmamız sorunu çözecektir
            *  mümkün olduğunca kod tekrarından kaçın
            */
            /* int i = 10;
            if (i == 10)
            {
                Console.WriteLine("i degeri 10");
                // Console.WriteLine("merhaba"); //bunun gibi
            }
            else
            {
                Console.WriteLine("i degeri 10 degil");
                // Console.WriteLine("merhaba");//bunun gibi
            }
            Console.WriteLine("merhaba");
            */
            #endregion

            #region if-else if yapılanması


            #endregion


            // anlık saat ve dk.yı verir
            /*
            var curr = DateTime.Now;
            string s = curr.ToString("HH:mm");
            Console.WriteLine(s);
            */

            /*
            Console.Write("Arama saati girin: ");
            int aramaSaati = int.Parse(Console.ReadLine());
            Console.Write("Arama başlangıç saati girin: ");
            TimeSpan baslangicSaati = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Arama bitiş saati girin: ");
            TimeSpan bitisSaati = TimeSpan.Parse(Console.ReadLine());
            TimeSpan totalTime = bitisSaati - baslangicSaati;
            //int totalTime = bitisSaati - baslangicSaati;
            Console.WriteLine($"Arama süresi: {totalTime.TotalMinutes} dakikadır");
            */



            Console.ReadLine();
        }
    }
}
