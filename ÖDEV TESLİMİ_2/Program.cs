using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

namespace ÖDEV_TESLİMİ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////ÖDEV TESLİMİ_2

            //   //SORU_1:Bir mağazada alınan ürünün fiyatı 100 TL ve üzerinde ise 5 TL olan kargo ücreti alınmamaktadır.
            //   //Ürünün fiyatı girildiğinde toplam ödenmesi gereken tutarı gösteren C# konsol uygulamasını yapalım.
            //   //CEVAP:

            //   Console.Write("Ürün fiyatını giriniz: ");
            //   double fiyat = double.Parse(Console.ReadLine());
            //   double odenecek = 0;

            //   if ( fiyat >= 100)
            //   {
            //       odenecek = fiyat;
            //   }
            //   else
            //   {
            //       odenecek = fiyat + 5;
            //   }
            //   Console.WriteLine("Ödenecek Tutar Toplam: " + odenecek);


            ////SORU_2:Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL’den fazla ise,
            ////2.üründen %25 indirim yaparak ödenecek tutarı gösteren kodu yaz.
            ////CEVAP:

            //Console.Write("1.Ürün fiyatı: ");
            //double birinci = double.Parse(Console.ReadLine());

            //Console.Write("2.Ürün fiyatı: ");
            //double ikinci = double.Parse(Console.ReadLine());
            //double toplam = birinci + ikinci;

            //if (toplam > 200)
            //{
            //    ikinci = ikinci * 0.75;
            //    toplam = birinci + ikinci;
            //}

            //Console.WriteLine("Ödenecek tutar toplam: " + toplam);


            ////SORU_3:1’den 25’e kadar olan sayıların kareleri toplamını bulan kodu yaz.
            ////CEVAP:

            //int toplam = 0;
            //for (int i = 1; i <= 25; i = i + 1)
            //{
            //    toplam = toplam +  (i * i);
            //}
            //Console.WriteLine("1'den 25'e kadar olan sayıların kaereleri toplamı: " + toplam);

            ////SORU_4:Kullanıcıdan kaç tane sayı girileceği istenecek. Kullanıcının istediği kadar sayı girişi alınacak.
            ////Sayılar alındıktan sonra aşağıdaki çıktıyı veren kodu yazın.
            ////Tek sayı adedi: x
            ////Çift sayı adedi: y
            ////En büyük sayı: z
            ////En küçük sayı: t

            ////CEVAP:

            //Console.Write("Sayı adedini giriniz: ");
            //int adet = int.Parse(Console.ReadLine());
            //int enb = 0, enk = 0, tek = 0, cift = 0;

            //for (int ii = 1; ii <= adet; ii++)
            //{
            //    Console.Write(ii + ". sayıyı giriniz: ");
            //    int x = int.Parse(Console.ReadLine());

            //    if (x % 2 == 0)
            //    {
            //        cift = cift + 1;
            //    }
            //    if (x % 2 != 0)
            //    {
            //        tek = tek + 1;
            //    }
            //    if (ii == 1 || x > enb)
            //    {
            //        enb = x;
            //    }
            //    if (ii == 1 || x < enk)
            //    {
            //        enk = x;
            //    }


            //}

            //Console.WriteLine("Tek sayı adedi: "+ tek);
            //Console.WriteLine("Çift sayı adedi: "+cift);
            //Console.WriteLine("En büyük sayı: "+ enb);
            //Console.WriteLine("En küçük sayı: " + enk);

            ////SORU_5:Kullanıcıdan 2 sayı istenecek. Bu iki değer arasındaki 3 ile tam olarak bölünebilen sayıların ortalamasını ve
            ////bu sayıların kaç tane olduğunu veren kodu yazın.
            ////CEVAP:

            //Console.Write("1. sayıyı giriniz: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz: ");
            //int b = int.Parse(Console.ReadLine());

            //int sayac = 0;
            //double toplam = 0;

            //if (a < b)
            //{
            //    for (int q = a; q <= b; q = q + 1)
            //    {
            //        if (q % 3 == 0)
            //        {
            //            sayac = sayac + 1;
            //            toplam = toplam + q;
            //        }
            //    }
            //}
            //else if (a > b)
            //{
            //    for (int q = b; q <= a; q = q + 1)
            //    {
            //        if (q % 3 == 0)
            //        {
            //            sayac = sayac + 1;
            //            toplam = toplam + q;
            //        }
            //    }
            //}
            //Console.WriteLine("3'e bölünebilen sayı adedi: " + sayac);
            //Console.WriteLine("3'e bölünebilen sayıların ortalaması: " + toplam / sayac);

            ////CEVAP_2;

            //Console.Write("1. sayıyı giriniz: ");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz: ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int sayacc = 0;
            //double toplamm = 0;

            //if (sayi1 > sayi2)
            //{
            //    int temp = sayi1;
            //    sayi1 = sayi2;
            //    sayi2 = temp;
            //}

            //for (int i = sayi1; i<= sayi2; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        toplamm += i; //toplam= toplam + i
            //        sayacc++;

            //    }
            //}
            //if (sayacc > 0)
            //{
            //    double ortalama = (double)toplamm / (double)sayacc; //siz int gibi değil double gibi davranın.
            //    Console.WriteLine("3'e bölünebilen sayı adedi: " + sayacc);
            //    Console.WriteLine("3'e bölünebilen sayıların ortalaması: " + ortalama);
            //}
            //else
            //{
            //    Console.WriteLine("Girilen sayılar arasında 3'e bölünebilen sayı yoktur.");
            //}


            //SORU_6:Furkan, bir romanın her gün bir önceki gün okuduğu sayfadan 5 sayfa fazlasını okumaktadır. İlk gün 10 sayfa okuyarak başlayan
            //Furkan' ın 1.000 sayfalık bir romanı kaç günde bitireceğini bulan kodu yazın.
            //CEVAP:

            //Console.WriteLine("Furkan'ın ilk gün okuduğu sayfa sayısı: 10 ");
            //int toplamSayfa = 1000;
            //int ilkGun = 10;
            //int okunanSayfa = 0;
            //int gun = 0;

            //while (okunanSayfa <= toplamSayfa)
            //{
            //    gun = gun + 1;
            //    okunanSayfa = okunanSayfa + ilkGun;
            //    ilkGun = ilkGun + 5;
            //}

            //Console.WriteLine("Furkan romanı şu kadar günde bitirecek:" + gun);





            ////SORU_7:Girilen sayının asal olup olmadığını söyleyen kodu yazın.
            ////CEVAP_1:

            //Console.Write("Bir sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //int kontrol = 0;


            //for (int i = 2; i < sayi; i = i + 1)
            //{
            //    if (sayi % i == 0)
            //    {
            //        kontrol = kontrol + 1;
            //    }

            //}
            //if (kontrol == 0)
            //{
            //    Console.WriteLine("Bu sayı asaldır.");
            //}
            //else
            //{
            //    Console.WriteLine("Bu sayı asal değildir.");
            //}

            ////CEVAP_2:

            //Console.Write("Bir sayı giriniz: ");
            //int sayi2 = int.Parse(Console.ReadLine());
            //int kontrol2 = 0;

            //for(int ii = 2; ii < sayi2; ii++)
            //{
            //    if (sayi % ii == 0)
            //    {
            //        kontrol2++;
            //        break;
            //    }
            //}

            //if(kontrol2 == 0 && sayi2 != 1)
            //{
            //    Console.WriteLine("Bu sayı asaldır.");
            //}
            //else
            //{
            //    Console.WriteLine("Bu sayı asal değildir.");
            //}

            ////CEVAP_3:

            //Console.Write("Bir sayı giriniz: ");
            //int sayi2 = int.Parse(Console.ReadLine());
            //bool asalMi = true;
            
            //for (int ii = 2; ii < sayi2; ii++)
            //{
            //    if (sayi2 % ii == 0)
            //    {
            //        asalMi = false;
            //        break;
            //    }
            //}

            //if (asalMi  && sayi2 != 1) //if içerisinde boolean varsa true mu diye sorguluyor (asalMi == ture yazmaya gerek yok sadece asalMi yazmak da aynı işlem)
            //{
            //    Console.WriteLine("Bu sayı asaldır.");
            //}
            //else
            //{
            //    Console.WriteLine("Bu sayı asal değildir.");
            //}



            ////SORU_8:Bir memur, ATM makinesinden para çekmek istemektedir. Makinede sadece 10, 20, 50 ve 100TL' lik banknotlar kalmıştır. Büyük değerli banknotların sayısı maksimum olacak şekilde,
            ////çekilecek paranın kaç tane 100, 50, 20 ve 10 liralık banknottan oluşacağını ekranda yazan kodu yazın.
            ////CEVAP_1:

            //Console.Write("Lütfen para miktarını giriniz: ");
            //int para = int.Parse(Console.ReadLine());

            //int yuzlukb = 0;
            //int ellilikb = 0;
            //int yirmilikb = 0;
            //int onlukb = 0;

            //if (para % 10 != 0)
            //{
            //    Console.WriteLine("En küçük 10 TL'lik banknot mevcut..! 10'un katı bir değer girin.");
            //}
            //else
            //{
            //    while (para > 100)
            //    {
            //        yuzlukb = yuzlukb + 1;
            //        para = para - 100;
            //    }
            //    while (para > 50)
            //    {
            //        ellilikb = ellilikb + 1;
            //        para = para - 50;
            //    }
            //    while (para > 20)
            //    {
            //        yirmilikb = yirmilikb + 1;
            //        para = para - 20;
            //    }
            //    while (para >= 10)
            //    {
            //        onlukb = onlukb + 1;
            //        para = para - 10;
            //    }

            //    Console.WriteLine(yuzlukb + "adet 100 TL");
            //    Console.WriteLine(ellilikb + "adet 50 TL");
            //    Console.WriteLine(yirmilikb + "adet 20 TL");
            //    Console.WriteLine(onlukb + "adet 10 TL");
            //}


            ////CEVAP_2:


            //while (true)
            //{

            //    Console.Write("Lütfen para miktarını giriniz: ");
            //    int miktar = int.Parse(Console.ReadLine());
            //    int yuz, elli, yirmi, on = 0;

            //    if( miktar % 10 > 0)
            //    {
            //        Console.WriteLine("En küçük 10 TL'lik banknot mevcut..! 10'un katı bir değer girin.");
            //        continue;
            //    }

            //    yuz = miktar / 100;
            //    miktar = miktar - (yuz * 100);

            //    elli = miktar / 50;
            //    miktar = miktar - (elli * 50);

            //    yirmi = miktar / 20;
            //    miktar = miktar - (yirmi * 20);

            //    on = miktar / 10;
            //    miktar = miktar - (on * 10);

            //    Console.WriteLine(yuz + "adet 100 TL");
            //    Console.WriteLine(elli + "adet 50 TL");
            //    Console.WriteLine(yirmi + "adet 20 TL");
            //    Console.WriteLine(on + "adet 10 TL");

            //    break;
            //}


            // //SORU_9:1'den 999'a kadar olan tam sayılar içerisinden basamaklarının küp değeri toplamı kendisine eşit olan değerleri ekrana yazdıran kodu yazın.
            // //CEVAP:

            // int toplam = 0;


            //for (int m = 1; m <= 999; m = m+1)
            // {

            //     int yuzlerb = m / 100;
            //     int onlarb = (m - yuzlerb * 100) / 10;
            //     int birlerb = m - ((yuzlerb * 100) + (onlarb * 10));


            //     toplam = (birlerb * birlerb * birlerb) + (yuzlerb * yuzlerb * yuzlerb) + (onlarb * onlarb * onlarb);

            //     if (toplam == m)
            //     {
            //         Console.WriteLine("Basamaklarının küpleri toplamı kendisine eşit olan sayılar: " + m);
            //     }

            // }



        }
    }
}
