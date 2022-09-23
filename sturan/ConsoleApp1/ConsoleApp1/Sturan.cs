using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Sturan
    {
        static void Main(string[] args)
        {
            #region C# ve .Net Framework Nedir ?
            /* C# ve .Net Framework Nedir ?

             C#, Microsoft firmasının geliştirdiği ve bir çok alanda uygulama geliştirebileceğimiz popüler bir programlama dilidir.

             .Net ise uygulama geliştirmek için gereken bir framework’dür.Yani Microsoft ‘un yazılım geliştirmek için oluşturmuş olduğu kod kütüphanesi olarak adlandırılabilir.

             .Net framework içerisinde kullandığımız tek dil C# değildir. Örneğin; Visual Basic, C++ ya da F# dillerini de kullanabiliriz.

             .Net temel olarak 2 ana bileşenden oluşur.CLR(Common Language Runtime) ve Class Library yani Sınıf Kütüphanesi.

             Bilgisayarların yani işlemcilerin anlayacağı tek yapı makine kodudur. Dolayısıyla her yazılan kodu direk makine koduna çevirmek her programın her sistemde çalışmasını engelleyen bir durumdur. Dolayısıyla yazdığımız kodları direk makine koduna çevirmektense bunu önce bir IL(Intermedia Language) yani ara dile çevirmek mantıklı olandır. 

              Daha sonra istediğimiz sistemde bu IL kodunu makine koduna çevirip kullanabiliriz bu işlemi yöneten yapı ise CLR yapısıdır.Aynen Java programlarını bilgisayarlarda ya da telefonlarda çalıştırmak için indirdiğimiz Java Runtime yapısıdır.

             .Net Framework içerisinde yazdığımız her kod(IL) ara koda çevrildiğinden dolayı kodumuzu .Net içindeki hangi programlama diliyle yazdığımızın bir önemi yok sonuçta Visual Basic de kullansak C# da kullansak her durumda derleyici kodumuzu IL koduna çevirecektir. */

            #endregion

            #region giriş
            //byte sayi = 255;
            //short sayi2 = 500;
            //int sayi3 = 30000;
            //long sayi4 = 1000000;

            //float sayi5 = 2.5f;
            //double sayi6 = 12.5;
            //decimal sayi7 = 125.56m;

            //char character = 'A';
            //string adSoyad = "ece tohma";

            //bool isOk = true;

            //Console.WriteLine(sayi);
            //Console.WriteLine(sayi2);
            //Console.WriteLine(sayi3);
            //Console.WriteLine(sayi4);

            //Console.WriteLine(sayi5);
            //Console.WriteLine(sayi6);
            //Console.WriteLine(sayi7);
            //Console.WriteLine(character);
            //Console.WriteLine(isOk);
            //Console.WriteLine(adSoyad); 
            #endregion

            #region değişkenler

            //var sayi = 255;
            //var sayi2 = 500;
            //var sayi3 = 30000;
            //var sayi4 = 1000000;

            //var sayi5 = 2.5f;
            //var sayi6 = 12.5;

            //var sayi7 = 125.56m;

            //var character = 'A';
            //var adSoyad = "ece tohma";

            //var isOk = true;

            //Console.WriteLine(sayi);
            //Console.WriteLine(sayi2);
            //Console.WriteLine(sayi3);
            //Console.WriteLine(sayi4);

            //Console.WriteLine(sayi5);
            //Console.WriteLine(sayi6);
            //Console.WriteLine(sayi7);
            //Console.WriteLine(character);
            //Console.WriteLine(isOk);
            //Console.WriteLine(adSoyad); 
            #endregion

            #region değişkenler-2
            // Kilo bilgisi tutacak bir değişken (byte, short, int, long)
            //byte kilo = 255;
            // sbyte -128 ile 127 arası değer taşır
            //Console.WriteLine(kilo);

            // Araç km bilgisini tutacak bir değişken
            //int aracKm = 1000000;
            //Console.WriteLine(aracKm);

            // müşteri id'sini tutacak bir değişken
            //long musteriId = 1000000;
            //Console.WriteLine(musteriId);

            // Maaş bilgisini tutacak bir değişken
            //bool satistami = false;
            //Console.WriteLine(satistami);
            //decimal maas = 3000.54m; //m eklenmesi gerek, f eklersek float olur
            //Console.WriteLine(maas);

            // Öğrenci adını ve soyadını tutacak bir değişken
            //string adSoyad = "ece tohma"
            //Console.WriteLine(adSoyad);

            // Şube kodunu tutacak bir değişken
            //char subeKodu = 'A';
            //Console.WriteLine(subeKodu); 
            #endregion

            #region Tür Dönüşüm
            //Type Conversion
            //string a = "5";
            // int b = a; olmaz çünkü metni sayıya dönüştürmek bu şekilde sağlanamaz. bunun için Convert() ve Parse() yapılarını kullanırız. Convert. dan sonra To... yapısı kullanılır ama sol taraftaki yapıyı da değiştirmek unutulmamalı.

            //int b = Convert.ToInt32(a);
            //long b = Convert.ToInt64(); // long
            //byte b = Convert.ToSByte(); // byte

            //int b = int.Parse(a);
            //byte b = byte.Parse(a); //byte
            //int b = int16.ToParse(a); //short

            //Console.WriteLine(b);

            //byte b = 8;
            //int i = b;
            //Console.WriteLine(i);

            //int i = 9;
            //byte b = i;// int türü byte'a dönüştürülemez. kasıtlı dönüştürme mi yapılıyor?
            //byte b = (byte)i;
            //Console.WriteLine(b);  
            #endregion

            #region Tür Dönüşüm-1

            //int i = 256;
            //byte b = (byte)i;
            //Console.WriteLine(b); //çıktı 0 olur çünkü byte en fazla 255 değerini alır. OverFlowing denilen olay olur. veri kaybı yaşandı. bu tür durumda bizi uyarması için checked yapısı kullanılabilir.
            //checked
            //{
            //    try
            //    {
            //        byte b = (byte)i;
            //        Console.WriteLine(b);
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("OverFlowing Hatası");
            // throw;  yakala
            //}

            //byte b = (byte)i; // İşlenmeyen Özel Durum: System.OverflowException: Aritmetik işlem taşmayla sonuçlandı.
            //Console.WriteLine(b); // i adı geçerli bağlamda yok 
            //}


            //try
            //{
            //string sayi = "256";
            //int i = int.Parse(sayi); // çıktı: 256
            //float i = float.Parse(sayi); // çıktı: 256
            //double i = double.Parse(sayi); // çıktı: 256
            //long i = Convert.ToInt64(sayi);// çıktı: 256

            //string sayi = "true";
            //bool i = bool.Parse(sayi); // çıktı: true
            //bool i = Convert.ToBoolean(sayi); // çıktı: true
            //Console.WriteLine(i);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Tür Dönüşüm Hatası");
            //} 
            #endregion

            #region değişken toplama
            //a = "50" ve b = "100" olan iki değişkeni topla.
            //string a = "50";
            //string b = "100";            
            //int result = int.Parse(a) + int.Parse(b);

            //Console.WriteLine(result); 
            #endregion

            #region string toplama
            //Klavyeden girilen iki sayıyı string olarak topla
            //Console.WriteLine("sayi1: ");
            //var sayi1 = Console.ReadLine();

            //Console.WriteLine("sayi2: ");
            //var sayi2 = Console.ReadLine();

            //var sonuc = sayi1 + sayi2;
            //Console.WriteLine(sonuc); 
            #endregion

            #region sayısal topla
            //Klavyeden girilen iki sayıyı sayısal olarak topla
            //Console.WriteLine("sayi1: ");
            //var sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("sayi2: ");
            //var sayi2 = int.Parse(Console.ReadLine());

            //var sonuc = sayi1 + sayi2;
            //Console.WriteLine(sonuc);
            #endregion

            #region byte toplama

            //byte a=255 ve byte b=10 değerlerini topla
            //byte a = 255;
            //byte b = 10;

            //var result = a + b;
            //Console.WriteLine(result); 
            #endregion

            #region bölme

            //int a=10 ve int b=3 iken a/b değerini tamsayı olarak yaz
            //int a = 10;
            //int b = 3;
            //Console.WriteLine(a / b);

            //int a=10 ve int b=3 iken a/b değerini ondalıklı olarak yaz
            //int a = 10;
            //int b = 3;

            //float result = (float)a / b;
            //Console.WriteLine(result); 
            #endregion

            #region koşul

            //string isWorking = "true" değerini koşul ifadesinde kullan
            //string isWorking = "true"; //false yazarsak veri gelmez 

            //if (bool.Parse(isWorking)) //if seçip 2 defa tab yapıyoruz
            //{
            //    Console.WriteLine("if bloğu işletildi");
            //} 
            #endregion

            #region nullable types
            //Nullable Types
            // bir boşluğa denk gelen yani içerisine boş değer atanan demek. mesela;
            //int? sayi = null;
            //int? sayi = 100;
            //Console.WriteLine(sayi);
            //int? sayi = null;
            //sayi.HasValue
            //sayi.GetValueOrDefault();

            //bool? sonuc = null;            
            //int? sayi = null;
            //if (sayi.HasValue==true)
            //{
            //    Console.WriteLine(sayi);
            //}
            //sayi = 100;
            //Console.WriteLine(sonuc);
            //Console.WriteLine(sayi);
            //Console.WriteLine(sonuc.HasValue);
            //Console.WriteLine(sayi.HasValue);

            //int? x = 10;
            //int? y = 20;
            //Console.WriteLine("X: {0} Y: {1}", x, y);

            //x = y.GetValueOrDefault(); // y değişkeninin içerisinde bir değer varsa onu alır
            //Console.WriteLine("X: {0} Y: {1}", x, y);

            //x = null;
            //y = x.GetValueOrDefault();
            //Console.WriteLine("X: {0} Y: {1}", x, y); // x: y: 0  x te değer olmadığından y 0 oldu

            //y = x.GetValueOrDefault(10);
            //Console.WriteLine("X: {0} Y: {1}", x, y); // x: y: 10  varsayılan değeri değiştirdiğimiz için

            //y = x ?? 20;
            //Console.WriteLine("X: {0} Y: {1}", x, y); // x:  y: 20  x değerinde bir karşılık varsa onu al yoksa 20 değerini kullan 

            //x = 25;
            //y = x ?? 20;
            //Console.WriteLine("X: {0} Y: {1}", x, y); //x: 25 y: 25 çünkü x değerinin bir karşılığı var 
            #endregion

            #region scope
            // Scope
            /* Parantezler kod gruplarını gruplamak için kullanılır
             * Değişkenler tanımlandığı parantez dışına çıktığında bellekten silinir
             *  {
             *  var sayi = 10; 
             *  } örneği gibi
             *
             * Aynı isimde farklı değişken kullanılmaz
             * Ama farklı formatta kullanılabilir (int ise string şeklinde kullanılabilmesi gibi). Ancak çok tercih edilmez. örnek;
             * 
             * var sayi = 10;
             * {
             *   sayi = 20; //sayi hala bellekte ve kullanılabilir
             *      {
             *          sayi = 30; //sayi hala bellekte ve kullanılabilir
             *      }
             * }
             */
            #endregion

            #region Aritmetik Operatörler
            //Aritmetik Operatörler
            //int a = 2;
            //int b = 3;
            //Console.WriteLine(Math.Pow(a, b)); //üs alma

            //var a = 15;
            //var b = 4;
            //var c = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine((float)a / (float)b); // burada var int olarak geldiğinden sonuç int olacaktır. bu nedenle (float) ile dönüştürüyoruz
            //Console.WriteLine(a + b * c);
            //Console.WriteLine((a + b) * c);
            //Console.WriteLine(a % b);
            //Console.WriteLine(Math.Log(a, b));
            //Console.WriteLine(a++);
            //Console.WriteLine(++a);
            //Console.WriteLine(b--);
            //Console.WriteLine(b);
            //Console.WriteLine(c = b++);

            //var d = 3;
            //var e = 5;

            //d = e++;
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //d = ++e;
            //Console.WriteLine(e);
            #endregion

            #region Aritmetik Operatörler-2
            //Aritmetik Operatörler-2
            //double a = 3;
            //double b = 4;
            //Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b}");
            //Console.WriteLine($"Length of the hypotenuse of the right triangle with legs of {a} and {b} is {CalculateHypotenuse(a, b)}");// Area of the right triangle with legs of 3 and 4 is 6

            //double CalculateHypotenuse(double leg1, double leg2) => Math.Sqrt(leg1 * leg1 + leg2 * leg2);// Length of the hypotenuse of the right triangle with legs of 3 and 4 is 5


            // a = 10 b = 20 c = 50 => (a+b)*c sonucu nedir?
            //var a = 10;
            //var b = 20;
            //var c = 50;
            //Console.WriteLine((a+b)*c); //1500

            // int? a = 50, int b = 100 ise a+b yi hesaplayın 
            //int? a = 50;
            //int b = 100;
            //int sonuc = (a ?? 0) + b;
            //Console.WriteLine(sonuc); //150 eğer int? a = null; olsaydı o zaman sonuç 100 olurdu

            // a=10 ve b =50 iken a = b-- ise a ve b ne olur?
            //int a = 10;
            //int b = 50;
            //Console.WriteLine(a = b--); //50
            //Console.WriteLine(a); // 50
            //Console.WriteLine(b); // 49


            // a = 10 b = 20 c = 50 ise (a)+(b++)-c'yi hesaplayınız
            //var a = 10;
            //var b = 20;
            //var c = 50;
            //Console.WriteLine(a); //10
            //Console.WriteLine(b++); //20 
            //Console.WriteLine((a) + (b++) - c); // -20

            // a = 10 iken a== b true değerini döndürüyor ise b kaçtır?
            //int a = 10;
            //int b = 10; // true değeri için biz girdik
            //Console.WriteLine(a==b);

            // 3 üzeri 5'i hesaplayın
            //int a = 3;
            //int b = 5;
            //Console.WriteLine(Math.Pow(a,b)); //veya
            //Console.WriteLine(Math.Pow(3,5));

            // Klavyeden girilen bir sayının tek çift olduğunu hesaplayın
            //Console.WriteLine("sayi giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çift");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tek");
            //} 
            #endregion

            #region ilişkisel operatörler
            //İlişkisel Operatörler
            //int a = 10, b = 70, c = 75, d = 60;
            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);
            //Console.WriteLine(a != c);
            //Console.WriteLine(a > b);
            //Console.WriteLine(a >= b);

            //var sonuc = c > b ? "c b'den büyük" : "b c'den büyük";
            //var sonuc = (c > b) ? (c > d) ?
            //    "c d'den büyük"
            //    : "c d'den küçük"
            //    : "b c'den büyük";
            //Console.WriteLine(sonuc);

            //yaşı 18 ve daha büyükse oy kullanabilir
            //Console.WriteLine("Yaşınızı giriniz: ");
            //int yas = int.Parse(Console.ReadLine());
            //bool sonuc = yas >= 18; //veya
            //if (yas >= 18)
            //{
            //    Console.WriteLine("oy kullanabilirsiniz");
            //}           
            //else        
            //{           
            //    Console.WriteLine("oy kullanamazsınız. {0} yılınız kaldı", 18 - yas);
            //}
            //Console.WriteLine(sonuc);

            //Girilen bir sayının işaretini kontrol edin
            //Console.Write("Sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());

            //bool sonuc = sayi < 0; // sayı negatif
            //if (sonuc)
            //{
            //    Console.WriteLine("Sayı negatif");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Pozitif");
            //}
            //veya
            //Console.WriteLine("Sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //string sonuc = sayi < 0 ? "sayi negatif" : "sayi pozitif";
            //Console.WriteLine(sonuc);

            //girilen iki sayının eşitlik kontrolünü yapın
            //Console.WriteLine("sayi1: ");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("sayi2: ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //string result = sayi1 == sayi2 ? "sayılar eşit" : "sayılar eşit değil";

            //Console.Write(result);

            //a = 20, b= 10, c= 15 sayılarını büyükten küçüğe sırala
            //int a = 62, b = 73, c = 70;

            //var sonuc = (c > a) ? (c > b) ?
            //    "c en büyük sayıdır"
            //    : "b en büyük sayıdır"
            //    : "a en büyük sayıdır";
            //Console.WriteLine(sonuc);

            //int max = c;
            //if (a > max)
            //{
            //    max = a;
            //}
            //if (b > max)
            //{
            //    max = b;
            //}

            //Console.WriteLine("en büyük sayı : {0}", max);
            #endregion

            #region mantıksal operatörler
            /*  Mantıksal Operatörler
              *  Operatör    İşlem               Örnek
              *  &           Ve                  true & true
              *  |           Veya                true | false
              *  ^           Özel Veya           true ^ false
              *  ||          Koşula Bağlı Veya   true || false
              *  &&          Koşula Bağlı Ve     true && true
              *  !           Değil               ! true
              */

            //var a = true;
            //var b = true;
            //var c = false;
            //var d = false;

            ////var sonuc = (a & b);
            //Console.WriteLine("&");
            //Console.WriteLine(a & b);
            //Console.WriteLine(a & c);
            //Console.WriteLine(c & d);
            //Console.WriteLine("--------");

            //Console.WriteLine("|");
            //Console.WriteLine(a | b);
            //Console.WriteLine(a | c);
            //Console.WriteLine(c | d);
            //Console.WriteLine("--------");

            //Console.WriteLine("^");
            //Console.WriteLine(a ^ b);
            //Console.WriteLine(a ^ c);
            //Console.WriteLine(c ^ d);
            //Console.WriteLine("----------");

            //Console.WriteLine("&&");
            //Console.WriteLine(a && b);
            //Console.WriteLine(a && c);
            //Console.WriteLine(c && d);
            //Console.WriteLine("--------");

            //Console.WriteLine("||");
            //Console.WriteLine(a || b);
            //Console.WriteLine(a || c);
            //Console.WriteLine(c || d);
            //Console.WriteLine("--------"); 

            //Console.WriteLine("!");
            //Console.WriteLine(!a); // false

            //Console.WriteLine(((a & b) || c) & d); //false
            //Console.WriteLine(!(((a & b) || c) & d)); //true


            // Ornekler
            //Yaşı 18'den büyük ya da veli izni varsa bir işte çalışabilir
            //int yas = 17;
            //bool veliIzni = true;

            //bool birinci = (yas >= 18);
            //bool ikinci = veliIzni;

            //if ((birinci) || (ikinci))
            //{
            //    Console.WriteLine("çalışabilir");
            //}
            //else
            //{
            //    Console.WriteLine("çalışamaz"); // || (yada) dediğimiz için 2 ifadeden birinin true olması çalışabilir sonucu vereceğinden çıktı: çalışabilir. ancak 2 koşulun uymadığı durumda çalışamaz çıktısını verir
            //}


            //Ders notu 45-100 arasındaysa dersten geçer
            //int not = 20;

            //bool kosul1 = (not >= 45);
            //bool kosul2 = (not <= 100);

            //if ((kosul1)&(kosul2))
            //{
            //    Console.WriteLine("sayı 45 ile 100 arasındadır");
            //}
            //else
            //{
            //    Console.WriteLine("sayı 45 ile 100 arasında değildir");
            //}

            //Ortalaması en az 70 ve zayıf yoksa teşekkür
            //int ort = 85;
            //int zayif = 1; // zayıf sayısı

            //if (ort >= 70 && zayif == 0)
            //{
            //    Console.WriteLine("Teşekkür Belgesi alır");
            //}
            //else
            //{
            //    Console.WriteLine("Alamaz");
            //}


            //İşe alım işlemini yüksekokul ya da üniversite olarak yapalım
            //string egitimSeviyesi = "yüksekokul";
            //bool isSigara = true; // veya bool isSigara = false;

            //if ((egitimSeviyesi == "yüksekokul" || egitimSeviyesi == "üniversite") && (!isSigara // veya isSigara==0))
            //{
            //    Console.WriteLine("işe alınabilir");
            //}

            //else
            //{
            //    Console.WriteLine("işe alınamaz");
            //}

            //Login işlemini kullanıcı adıyla ya da eposta ile yapalım

            //string username = "serdartohma";
            //string email = "serdartohma@gmail.com";
            //string password = "1234";

            //Console.WriteLine("username yada email giriniz: ");
            //string girilenUsername = Console.ReadLine();

            //Console.WriteLine("Parola giriniz: ");
            //string girilenParola = Console.ReadLine();

            //if ((username == girilenUsername || girilenUsername == email) && (girilenParola == password))
            //{
            //    Console.WriteLine("giriş yapıldı");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı Adı veya Parola Hatalı");
            //}
            #endregion

            #region atama operatörleri
            //Atama Operatörleri
            //var a = 40;
            //var b = 20;

            //a = b;
            //Console.WriteLine(a);

            //a = a + b; // a += b
            //Console.WriteLine(a);

            //a *= b;
            //Console.WriteLine(a);

            //a %= b;
            //Console.WriteLine(a); //çıktı: 0


            // Ornekler
            // a = 50 iken b değerini kullanıcıdan alıp a ile toplayalım
            //var a = 50;
            //Console.WriteLine("bir sayı giriniz: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(a + b);

            //veya
            //int a = 50;
            //int b;

            //Console.WriteLine("b sayısı: ");
            //string num1 = Console.ReadLine();

            //bool sonuc = int.TryParse(num1, out b);

            //if (!sonuc)
            //{
            //    Console.WriteLine("yanlış değer girdiniz");
            //}

            //a += b;
            //Console.WriteLine(a);


            // Girilen iki değeri toplayın
            //Console.WriteLine("sayi1: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("sayi2: ");
            //int b = int.Parse(Console.ReadLine());

            //a += b;
            //Console.WriteLine(a);

            // string değer toplama
            //Console.WriteLine("1.değer: ");
            //string deger1 = Console.ReadLine();

            //Console.WriteLine("2.değer: ");
            //string deger2 = Console.ReadLine();

            //string sonuc = deger1 + deger2;
            //Console.WriteLine(sonuc);


            // Girilen bir sayının 15'in katı olup olmadığını değerlendir
            //Console.WriteLine("sayi: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine(a%15);

            //veya

            //int sayi = 35;

            //bool sonuc1 = sayi % 5 == 0;
            //bool sonuc2 = sayi % 3 == 0;

            //if (sonuc1 && sonuc2)
            //{
            //    Console.WriteLine("sayı 15 e tam bölünür");
            //}
            //else
            //{
            //    Console.WriteLine("sayı 15 e tam bölünemez");
            //}


            //1-100 arasındaki sayıları toplayın

            // for (int i = ; i < args.Length; i++) gelen şablon bu.. biz soruya göre şekillendiriyoruz
            //int toplam = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam); 
            #endregion

            #region if else
            /* Console.Write("sayı giriniz: ");
            var sayi = int.Parse(Console.ReadLine());

            if (sayi == 0)
            {
                //true ise burası çalışır
                Console.WriteLine("girilen sayı sıfır");
            }
            else if (sayi > 0)
            {
                //sayı 0'dan büyük ise çalışır
                Console.WriteLine("sayı pozitif");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Sayı negatif");
            }
            */

            /* Console.Write("yaşınızı girin: ");
            int yas = int.Parse(Console.ReadLine());

            if (yas >= 18)
            {
                Console.WriteLine("Ehliyet alabilirsiniz");
            }
            else
            {
                Console.WriteLine("Ehliyet alamazsınız, yaşınız tutmuyor");
            }
            */

            /* Console.Write("yaşınızı girin: ");
            int yas = int.Parse(Console.ReadLine());

            if (yas >= 18)
            {
                Console.Write("Eğitim durumunuzu girin: ");
                string egitim = Console.ReadLine();

                if (egitim == "lise" || egitim == "üniversite")
                {
                    Console.WriteLine("Ehliyet alabilirsiniz");
                }
                else
                {
                    Console.WriteLine("Eğitim durumunuz ehliyet almanız için yeterli değildir");
                }
            }
            else
            {
                Console.WriteLine("Ehliyet alamazsınız, yaşınız tutmuyor");
            }
            */
            #endregion

            #region if-else if uygulamalar
            // Kullanıcıya sunulan bir menü içinden seçilecek olan matematiksel işlem tipine göre if-else yapısını kullanın
            /*  Console.WriteLine("Toplama için: + ");
             Console.WriteLine("Çıkarma için: - ");
             Console.WriteLine("Çarpma için: * ");
             Console.WriteLine("Bölme için: / ");
             Console.WriteLine("Seçiminiz: ");

             double sonuc = 0; // TODO: başlangıçta atadık ama neden???
             string secim = Console.ReadLine();

             Console.Write("1.sayı: ");
             int sayi1 = int.Parse(Console.ReadLine());

             Console.Write("2.sayı: ");
             int sayi2 = int.Parse(Console.ReadLine());

             if (secim == "+")
             {
                 sonuc = sayi1 + sayi2;
             }
             else if (secim == "-")
             {
                 sonuc = sayi1 - sayi2;
             }
             else if (secim == "*")
             {
                 sonuc = sayi2 * sayi2;

             }
             else if (secim == "/")
             {
                 sonuc = sayi1 / sayi2;
             }
             else
             {
                 Console.WriteLine("Hatalı bir işlem tipii seçtiniz.");
             }

             Console.WriteLine("İşlem Sonucu: {0} {1} {2} = {3}", sayi1,secim,sayi2,sonuc);
            */ // veya aşağıdaki şekilde yapılabilir. çünkü üstteki örnekte hatalı işlem tipi seçilse bile "hatalı işlem tipi seçtiniz" uyarısı ile birlikte işlem yapmaya çalışacak.

            /*
            Console.WriteLine("Toplama için: + ");
            Console.WriteLine("Çıkarma için: - ");
            Console.WriteLine("Çarpma için: * ");
            Console.WriteLine("Bölme için: / ");
            Console.Write("Seçiminiz: ");

            double sonuc = 0;
            bool ok = true; // bununla ilgili işlem yapılmasına gerek yok. son yazdırma bölümünde ok = false; girilmesi ile hatalı giriş yapılması sonrası sistem işlem yapmayacak
            string secim = Console.ReadLine();

            Console.Write("1.sayı: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("2.sayı: ");
            int sayi2 = int.Parse(Console.ReadLine());

            if (secim == "+")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (secim == "-")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (secim == "*")
            {
                sonuc = sayi1 * sayi2;
            }
            else if (secim == "/" && sayi2 == 0)
            {
                // sayi2 0'a eşitse kullanıcıyı uyar
                sonuc = sayi1 / sayi2;
                Console.WriteLine("Sıfıra bölme hatası meydana geldi");
            }
            else
            {
                ok = false;
                Console.WriteLine("Hatalı bir işlem tipi seçtiniz.");
            }
            if (ok)
            {
                Console.WriteLine("İşlem Sonucu: {0} {1} {2} = {3}", sayi1, secim, sayi2, sonuc);
            }
            */
            #endregion

            #region if else uygulama

            // Bir kişi mağazadan 100 TL ve üzeri alışveriş yaparsa % 10 indirim, 200 TL ve üzeri alışveriş yaparsa % 15 indirim, 300 TL ve üzeri alışveriş yaparsa % 20 indirim kazandığını ve ödeyeceği miktarı ekrana yazan C # kodlarını yazınız.

            /*
            int tutar;
            double odenecek;
            Console.WriteLine("Ödenecek tutarı giriniz.");
            tutar = Convert.ToInt32(Console.ReadLine());

            if (tutar < 100)
            {
                Console.WriteLine("İndirim yok. Ödeyeceğiniz miktar: " + tutar + " TL");
            }
            else if (tutar < 200)
            {
                odenecek = tutar - (tutar * 10) / 100;
                Console.WriteLine("İndirim %10. Ödeyeceğiniz miktar: " + odenecek + " TL");

            }
            else if (tutar < 300)
            {
                odenecek = tutar - (tutar * 15) / 100;
                Console.WriteLine("İndirim %15. Ödeyeceğiniz miktar: " + odenecek + " TL");
            }
            else
            {
                odenecek = tutar - (tutar * 20) / 100;
                Console.WriteLine("İndirim %20. Ödeyeceğiniz miktar: " + odenecek + " TL");
            }
            Console.ReadKey();
            */
            #endregion

            #region iç içe if blokları
            /* int i = 130;
            if (i > 0)
            {
                Console.WriteLine("{0} 0'dan büyük", i);
                if (i < 100)
                {
                    Console.WriteLine("{0} 100 den küçük", i);
                }
                if (i > 100)
                    Console.WriteLine("{0} 100 den büyük", i);
            } 
            */

            /*
            // 0 ile -100 arası
            int i = -30;
            if (i < 0)
            {
                Console.WriteLine("{0} 0'dan küçük", i);
                if (i < -100)
                {
                    Console.WriteLine("{0} -100 den küçük", i);
                }
                if (i > -100)
                    Console.WriteLine("{0} -100 den büyük", i);
            }
            */
            #endregion

            #region Alan Çevre Hesaplama
            /*  Console.WriteLine("Kısa Kenarı Giriniz: ");
              int kisa = int.Parse(Console.ReadLine());

              Console.WriteLine("Uzun Kenarı Giriniz: ");
              int uzun = int.Parse(Console.ReadLine());

              int cevre = 2 * (kisa + uzun);

              Console.WriteLine("")

              #endregion

              #region 0 a bölme hatası uyarı yazısı
              /*
              int x, y;
              Console.Write("1. Sayıyı Giriniz: ");
              x = Convert.ToInt16(Console.ReadLine());

              Console.Write("2. Sayıyı Giriniz: ");
              y = Convert.ToInt16(Console.ReadLine());

              try
              {
                  Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
              }
              catch (Exception e)
              {
                  Console.WriteLine("Sıfıra bölme hatası meydana geldi", e);
              }
              */
            #endregion

            #region switch case
            /* switch (değişken)
             * {
             * case (..) //değer:
             * ...
             * break;
             * case (..) //değer:
             * ...
             * break;
             * default:
             * ...
             * break;
             * }
             * switch (mevsim)
             * {
             * case "yaz":
             * cw("yaz mevsimi");
             * break;
             * case "ilkbahar":
             * cw("ilkbahar mevsimi");
             * break;
             * case "sonbahar":
             * cw("sonbahar mevsimi");
             * break;
             * default:
             * cw("hatalı giriş");
             * break;
             */
            #endregion

            #region switch case örnek
            // Console.WriteLine(DateTime.Now); //çıktı: 4.09.2022 15:55:01
            /*
            int gun = (int)DateTime.Now.DayOfWeek;

            switch (gun)
            {
                case 1:
                    Console.WriteLine("Bugün Pazartesi");
                    break;
                 case 2:
                    Console.WriteLine("Bugün Salı");
                    break;
                 case 3:
                    Console.WriteLine("Bugün Çarşamba");
                    break;
                 case 4:
                    Console.WriteLine("Bugün Perşembe");
                    break;
                 case 5:
                    Console.WriteLine("Bugün Cuma");
                    break;
                 case 6:
                    Console.WriteLine("Bugün Cumartesi");
                    break;
                 case 7:
                    Console.WriteLine("Bugün Pazar");
                    break;
                 
                default:
                    Console.WriteLine("Hatalı Giriş Yaptınız!");
                    break;
            }
            */

            #endregion

            #region Mevsimler örnek
            /*
            Console.Write("Ay: ");
            int ay = int.Parse(Console.ReadLine());
            switch (ay)
            {
                case 12:
                    Console.WriteLine("Kış mevsimindeyiz");
                    break;
                case 1:
                    Console.WriteLine("Kış mevsimindeyiz");
                    break;
                case 2:
                    Console.WriteLine("Kış mevsimindeyiz");
                    break;
                case 3:
                    Console.WriteLine("Ilkbahar mevsimindeyiz");
                    break;
                case 4:
                    Console.WriteLine("Ilkbahar mevsimindeyiz");
                    break;
                case 5:
                    Console.WriteLine("Ilkbahar mevsimindeyiz");
                    break;
                case 6:
                    Console.WriteLine("Yaz mevsimindeyiz");
                    break;
                case 7:
                    Console.WriteLine("Yaz mevsimindeyiz");
                    break;
                case 8:
                    Console.WriteLine("Yaz mevsimindeyiz");
                    break;
                case 9:
                    Console.WriteLine("Sonbahar mevsimindeyiz");
                    break;
                case 10:
                    Console.WriteLine("Sonbahar mevsimindeyiz");
                    break;
                case 11:
                    Console.WriteLine("Sonbahar mevsimindeyiz");
                    break;
                default:
                    Console.WriteLine("Hatalı değer girdiniz!");
                    break;
            }
            */
            //daha pratik olarak aşağıdaki şekle çevirebiliriz

            /*Console.Write("Ay: ");
            int ay = int.Parse(Console.ReadLine());
            switch (ay)
            {
                case 12:                    
                case 1:                    
                case 2:
                    Console.WriteLine("Kış mevsimindeyiz");
                    break;
                case 3:                    
                case 4:                    
                case 5:
                    Console.WriteLine("Ilkbahar mevsimindeyiz");
                    break;
                case 6:                    
                case 7:                    
                case 8:
                    Console.WriteLine("Yaz mevsimindeyiz");
                    break;
                case 9:                    
                case 10:                    
                case 11:
                    Console.WriteLine("Sonbahar mevsimindeyiz");
                    break;
                default:
                    Console.WriteLine("Hatalı değer girdiniz!");
                    break;
            }
            */
            #endregion

            #region Ternary
            /*
            Console.WriteLine("Bir sayı giriniz: ");
            int num = int.Parse(Console.ReadLine());
            */
            /*
            var result = (num % 2 == 0) ? "çift sayı" : "tek sayı";
            Console.WriteLine(result);
            */
            // örneği genişletelim
            /*
            var result = (num % 2 == 0) ? (num > 0 ? "Sayı çift pozitif" : "Sayı çift negatif") :
                (num > 0 ? "Sayı tek pozitif" : "Sayı tek negatif");
            Console.WriteLine(result);
            */

            #endregion

            #region Döngüler
            /* for
             * For (Kontrol Değişkeni; Test; Arttır yada Azalt)
             * {
             * Kod Blogu
             * }
             * 
             * while
             * do-while
             * ForEach
             * 
             * */
            // Kullanıcıdan başlangıç bitiş ve artış miktarı isteyin ve aralıktaki tüm sayıları yazıp toplayın
            /*
            Console.WriteLine("Başlangıç değeri: ");
            int baslangic = int.Parse(Console.ReadLine());

             Console.WriteLine("Bitiş değeri: ");
            int bitis = int.Parse(Console.ReadLine());

            Console.WriteLine("Artış miktarı");
            int artis = int.Parse(Console.ReadLine());
            */
            /* for (int i = baslangic; i <= bitis; i = i+artis)
            {
                Console.WriteLine("sayı: {0}", i);
            }
            */
            /* int sayac = 0;
            int toplam = 0;
            for (int i = baslangic; i <= bitis; i = i + artis)
            {
                sayac++;
                toplam += i;
                Console.WriteLine("{1}.sayı: {0}", i, sayac);
            }
            Console.WriteLine("Toplam değer: {0}",toplam);
            */

            // TODO: aralıktaki tüm sayıların çarpımı 
            // TODO: aralıktaki tüm sayıların tek tek karesini yazdırın
            // TODO: aralıktaki sayıların tek çift durumunu yazın

            /* int sayac = 0;
            int carpim = 1;
            for (int i = baslangic; i <= bitis; i = i * artis)
            {
                sayac++;
                carpim *= i;
                Console.WriteLine("{1}.sayı: {0}", i, sayac);
            }
            Console.WriteLine("Toplam değer: {0}", carpim);
            */
            #endregion

            #region while
            /* Kontrol değişkeni
             * while (test)
             {
                 Kod Blogu
                 Arttır ya da  Azalt
             }
            */
            /* int i = 1;

            while (i<10)
            {
                Console.WriteLine(i);
                i++; // 1'den 9'a kadar yazdırıyoruz
            }
            */
            /*
            int i = 10;

            while (i >= 1)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000); //sistem 1 sn uyuyup bu şekilde yazdırır
                i--; // 10'dan 1'e kadar yazdırma
            }
            */
            #endregion

            #region while örnek
            /* 
             * int toplam = 0;
             char secim = 'e';
             int sayac = 1;

             while (secim == 'e')
             {
                 Console.WriteLine("{0}. sayı giriniz: ", sayac);
                 toplam += int.Parse(Console.ReadLine());

                 Console.WriteLine("Devam etmek istiyor musun? (e/h)");
                 secim = Convert.ToChar(Console.ReadLine());

                 sayac++;

             }

             // Console.WriteLine("Sayıların toplamı: {0}", toplam); // kullanıcıdan gelen ve döngüye giren sayıların toplamını verir
             Console.WriteLine("{1} adet sayının toplamı: {0}", toplam, sayac - 1); // çıktı: ... sayının toplamı ... //sayac-1 dememizin hikmeti sayac'ı 1'den başlatmasından başka değildir
            */
            #endregion

            #region while Sayı bulma oyunu yapalım

            /* Sayı bulma oyunu yapalım
             * Rastgele üretilen bir sayıyı buldurmaya çalışın
             * Belirtilen hak bilgisi göz önünde bulundurulsun
             * Sayı girildiği anda oyuncu aşağı ya da yukarı yönlendirilsin
             * Sayı bulunduğu zaman kaç defada bilindiği yazılsın.
             * TODO: 100 puan üzerinden puanlandırın 
             * TODO: Oyun bittiği zaman kullanıcının devam etmek isteyip istemediği sorulsun. (e/h). e ise program bitmeden sorguya devam edilsin
             */

            // Belli bir hak verilen sayı bulma oyunu

            /*
            int hak = 5;// buradaki hak değeri ile 
            int sayac = 0;
            // var rnd=new Random(); şekli ile veya aşağıdaki şekli ile yazabiliriz ama ek satır gerekir ki bu da efektif kullanım olmaz
             // int tutulan=(rnd.Next(1,10);
            
            int tutulan = (new Random()).Next(1, 10); //1 ile 10 arasında rasgele sayı üretsin


            while (hak > 0) 
            {
                sayac++;
                Console.Write("Sayı: ");
                int sayi = int.Parse(Console.ReadLine());

                if (tutulan==sayi)
                {
                    // Console.WriteLine("Tebrik ederim :) {0} defada bildiniz", 5 - hak); // buradaki hak değeri aynı olmalı. çünkü sabit değer verildio yüzden mümkün olduğunca sabit değer kullanımı tercih edilmez
                    Console.WriteLine("Tebrik ederim :) {0} defada bildiniz", sayac);
                    break; // break; ile sorguyu sonlandırıyoruz
                }
                else
                {
                    if (tutulan>sayi)
                    {
                        Console.WriteLine("Yukarı");
                    }
                    else if (tutulan<sayi)
                    {
                        Console.WriteLine("Aşağı");
                    }
                }
                hak--;
                if (hak==0)
                {
                    Console.WriteLine("Oyun bitti");
                    break;
                }
            }
            */
            #endregion

            #region do while
            /*
             * Kullanıcı işlem bittikten sonra sorguya başlanıyor ve döngüye girip girmeyeceğine karar veriliyor
             * break; ile döngü sonlanıyor
              
            int i = 1;
                        
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i<10); // 1'den 10'a kadar yazdırır
            */

            #endregion

            #region do while örnek
            /*
            string username = "";
            string password = "";
            byte hak = 2; //kullanıcıya giriş hakkı tanıyoruz

            do
            {
                if (hak == 0)
                {

                    break; //hak 0'a geldiğinde sorgudan direk çıkılır. 
                }
                Console.Write("Kullanıcı adı girin: ");
                username = Console.ReadLine();

                Console.WriteLine("Parola girin: ");
                password = Console.ReadLine();

                hak--; //ilk giriş yaptığı andan itibaren hak kullanmaya başlamış olacaktır
            } while (username != "ecetohma" || password != "1234"); // username veya password bu değerleri sağlamadığı sürece döngüye devam et. doğru olduğu anda döngüden çıkacak ve giriş başarılı diyecek

            if (hak == 0)
            {
                Console.WriteLine("Hakkınız bitti");
            }
            else
            {
                Console.WriteLine("Giriş başarılı..!");
            }
            */

            #endregion

            #region do while örnek 2
            /*
             * Başlangıçta hiç koşul olmadan yaptığımız için do-while yapısını kullanıyoruz
             * 
            string secim;
            //Kasa koyalım
            double bakiye = 0;
            do
            {
                //bakiye görüntüledikten sonra
                Console.WriteLine("-----------");

                Console.WriteLine("1-Bakiye Görüntüleme \n2-Para Yatırma \n3-Para Çekme \n4-Çıkış \nSeçim");
                secim = Console.ReadLine();
                //bakiye görüntüledikten sonra
                Console.WriteLine("-----------");
                switch (secim)
                {
                    case "1":
                        //Bakiye Görüntüle
                        Console.WriteLine("Bakiyeniz {0} TL", bakiye);
                        break;
                    case "2":
                        //Para Yatır
                        Console.Write("Ne kadar yatırmak istiyorsunuz: ");
                        double miktar = double.Parse(Console.ReadLine());
                        bakiye += miktar; //bakiye + miktar yapıp bakiye'ye atıyor
                        break;
                    case "3":
                        //Para Çekme
                        Console.WriteLine("Ne Kadar Para İstiyorsunuz: ");
                        double eksilen = double.Parse(Console.ReadLine());
                        //eksilen hesaptaki paradan az veya çok olabilir ( - bakiyeden para çekilebilir)
                        if (eksilen > bakiye)
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }
                        else
                        {
                            bakiye -= eksilen;
                        }
                        break;
                    default:
                        break;
                }
            } while (secim != "4");
            */

            #endregion

            #region forEach
            /* string ifadesini kullandığımızda bu bizim için liste olabilir ve biz burada forEach yapısını kullanabiliriz*/

            // string ad = "ecetohma";

            /* char ch = ad[0]; // ad string'indeki 0'ıncı karakter yazılır

            for (int i = 0; i < ad.Length; i++)
            {
                Console.WriteLine(ad[i]); //ad'daki her karakter 1 satırda olacak şekilde çıktı verir
            } */ //veya aşağıdaki şekilde de yazdırabiliriz

            /*
            foreach (var ch in ad) //bu grup içerisindeki her bir elemanı teker teker ch (item)'ın içerisine atmak
            {
                Console.WriteLine(ch); //ad'daki her karakter 1 satırda olacak şekilde çıktı verir
            }
            */


            // int[] sayilar = { 10, 20, 50, 3, 5, 1, 3, 10 };
            /*
            foreach (var item in sayilar)
            {
                Console.WriteLine(item); //foreach kollaksiyonların tipini analiz ediyor ve bu tipi tek tek tanımladığı değişken içerisine parçalayıp atıyor ve bu aşamada bu içeriği istediğimiz gibi kullanıyoruz
            }
            */ //aynısını for ile yapalım

            /*
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]); // [i] (sayıların index numarası mutlaka yazdırılır
            }
            */
            #endregion

            #region Class (sınıf)
            /* Sınıflar (farklı proje sayfası oluşturuyoruz)
             * Değişken ve metotları içerir
             */


            #endregion

            #region Struct
            /* Değişken ve metotları içerir
             * Class referans tiplidir
             * Strcut değer tip 
             * Strcut genel olarak Class yapısına göre daha hızlı ama Class daha kullanışlı ve daha çok özelliği olduğundan tercih sebebi
             */
            /* Public strcut Dikdortgen
                {
                Public intKisa;
                Public intUzun;
                
            Public int alan (int kisa, int uzun)
            {
            Kisa = kisa;
            Uzun = uzun;
            returnKisa*Uzun;
            }
            }
            */

            #endregion

            #region Array (dizi)
            /* 20 kişilik bir sınıfta öğrenci numaralarını girmek ve takip etmek kolay olabilir ama çok sayıda öğrenci bilgisi olması durumunda  bunları gruplamak gerekebilir. 
             * [] ile yapının dizi olduğunu anlıyoruz.
             * örnek;

            /* int[] ogrnu = new int[20];
            ogrnu[0] = 12;
            ogrnu[1] = 13;
            ogrnu[2] = 14;
            ogrnu[3] = 15;
            ...
            ogrnu[19] = 320; */

            // tek tek öğrenci numarasını Console.WriteLine(ogrnu[10]); ile çağırmak vakit alır. bunun yerine for döngüsü kullanılabilir.

            /* for (int i = 0; i < length; i++)
            {

            }
            */

            /*
            int[] ogrnu = new int[5]; // 5 kişilik öğrenci grubu
            
            ogrnu[0] = 100;
            ogrnu[1] = 110;
            ogrnu[2] = 120;
            ogrnu[3] = 130;
            ogrnu[4] = 140;

            // Console.WriteLine(ogrnu[3]);


            for (int i = 0; i < ogrnu.Length; i++)
            {
                //0,1,2,3,4
                Console.WriteLine(ogrnu[i]);
            }

            Console.WriteLine("------------");
            foreach (var ogr in ogrnu)
            {
                Console.WriteLine(ogr);
            }
            */

            /*
            string[] ogrenciler = new string[5];

            ogrenciler[0] = "ece";
            ogrenciler[1] = "hayat";
            ogrenciler[2] = "hilal";
            ogrenciler[3] = "bilge";
            ogrenciler[4] = "gamze";

            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }
            */

            int[] ogrnu = new int[5];

            ogrnu[0] = 100;
            ogrnu[1] = 110;
            ogrnu[2] = 120;
            ogrnu[3] = 130;
            ogrnu[4] = 140;

            string[] ogrenciler = new string[5];

            ogrenciler[0] = "ece";
            ogrenciler[1] = "hayat";
            ogrenciler[2] = "hilal";
            ogrenciler[3] = "bilge";
            ogrenciler[4] = "gamze";

            //sınıf tanımlayıp ayrı değerleri aynı sınıf içerisinde toplu gösterelim

            #endregion

            #region String
            /* string nedir?
             * Karakter dizileridir
             * örneğin "ecetohma"
             * string ad = "ece"
             * var soyad = "tohma"
             * string ad = "ece";
            * var soyad = "tohma";

            * "adınız: " + ad + " soyadınız: " + soyad +; //veya

            * string.Format("adınız {0} soyadınız {1}", ad, soyad); //veya (0 index'teki yani ,'den sonraki ilk tanımı ifade eder)

            * string.Format($"adınız {ad} soyadınız {soyad}"); //ile yazılabilir
             * 
             * 
             */

            #endregion

            #region String Metotları


            /*
            string[] kurs = { "C#", "Programlama", "Eğitimi" };
            string message=string.Join(" ", kurs); //burada kurs dizisinin elemanları verilecek. " " yazılması ile her kelime arası boşluk bırakılması sağlanır
            */

            #endregion

            #region String Uygulama
            /*
            var ad = "hilal";
            var soyad = "tohma";

            // var adsoyad = "adınız: " + ad + " soyadınız " + soyad;
            // var adsoyad = string.Format("adınız {ad} soyadınız {soyad}", ad, soyad);
            var adsoyad = ($"adınız {ad} soyadınız {soyad}");

            Console.WriteLine(adsoyad);
            */

            /*
            string[] adlar = {"hayat", "ece", "hilal", "bilge"};
            // Console.WriteLine(adlar[2]); // istenilen sıradaki ismi çağırabiliriz

            var tumadlar=string.Join("-", adlar); //araya - ekler.. bunun gibi farklı ekleme ve düzenlemeler yapılabilir
            Console.WriteLine(tumadlar);
            */

            /*
            string[] adlar = { "hayat", "ece", "hilal", "bilge", "", null }; // "" veya null aynı şekilde kontrol edilebilir

            if (string.IsNullOrEmpty(adlar[4])) // bu değer ilgili yerdeki string'in null değerde mi boşluk karakterde mi olduğunu belirler.. gelen karakterin kullanıcı tarafından gerçekten doldurulup dolrulmadığı durumlarda kullanılır.. gelen değer true mu false mı olduğu gösterir
            {
                Console.WriteLine("isim boş");
            }
            */
            #endregion

            #region Enum

            /* Sabit değerli değişkenleri gruplamak için kullanılır
             * Okunabilirliği arttırır
             * Hataların önüne geçer
             */



            #endregion

            #region Değer ve Referans Tipler
            /* Value Types:
             * Primitive Types: char, bool, byte
             * Struct
             * 
             * Reference Types:
             * Array
             * String
             * Class
             *   
             */
            #endregion

            #region String

            #endregion

            #region DateTime
            /*
            DateTime tarih = DateTime.Now;
            Console.WriteLine(tarih.ToShortDateString());
            Console.WriteLine(tarih.ToShortTimeString()); // t.


             DateTime tarih = new DateTime(2022,12,09);
             DateTime now = DateTime.Now;

             Console.WriteLine("saat: {0}",now.Hour);
             Console.WriteLine("dakika: {0}",now.Minute);
             Console.WriteLine("gün: {0}",now.Day);
             Console.WriteLine("yıl: {0}",now.Year);

             DateTime tomorrow = now.AddDays(1);
             DateTime yesterday = now.AddDays(-6);
             DateTime saat = now.AddHours(-3);


             Console.WriteLine("gün: {0}", tomorrow.Day);
             Console.WriteLine("geçen gün: {0}", yesterday.Day);
             Console.WriteLine("saat: {0}", saat.Hour);

             Console.WriteLine(now.ToString());
             Console.WriteLine(now.ToShortTimeString());
             Console.WriteLine(now.ToShortDateString());
             Console.WriteLine(now.ToLongTimeString());
             Console.WriteLine(now.ToLongDateString());
             Console.WriteLine(now.ToString("yyyy-mm-dd"));
             Console.WriteLine(now.ToString("yyyy-mm-dd hh:dd:ss"));
             */
            #endregion

            #region Time Span
            /* saat cinsinden fark
            DateTime now1 = DateTime.Now;
            // DateTime now2 = DateTime.Now.AddHours(2); // dersek milisaniyeyi de gösteriyor atama arasındaki süreyi de dikkate aldığından
            DateTime now2 = now1.AddHours(2);

            TimeSpan timeSpan = now2 - now1;

            Console.WriteLine("Geçen süre: {0}", timeSpan);
            */

            /* dakika cinsinden
            DateTime now1 = DateTime.Now;
            DateTime now2 = now1.AddHours(2);

            TimeSpan timeSpan = now2 - now1;

            Console.WriteLine("Geçen süre: {0}", timeSpan.TotalMinutes);
            */

            /*
            TimeSpan ts1 = new TimeSpan(2, 10, 50);
            TimeSpan ts2 = new TimeSpan(4, 15, 50);
            TimeSpan ts3 = TimeSpan.FromHours(2); // ilk satıra göre 2 saatlik farkı ifade eder

            Console.WriteLine("saniye: {0}", ts1.Seconds);
            Console.WriteLine("dakika: {0}", ts1.Minutes);
            Console.WriteLine("saat: {0}", ts1.Hours);

            Console.WriteLine("toplam dakika: {0}", ts1.TotalMinutes);

            Console.WriteLine((ts2-ts1).TotalMinutes);
            */






            #endregion




            Console.ReadLine();
        }
    }
}
