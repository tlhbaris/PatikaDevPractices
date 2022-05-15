//Console.WriteLine("Sayi Giriniz");
//int sayi = Convert.ToInt32(Console.ReadLine());
//int toplam = 0;

//for (int i = 1; i < sayi; i++)
//{
//    if (i % 2 == 1)
//    {
//        toplam = i + toplam;

//    }

//}
//Console.WriteLine(toplam);





//1 - 1000 arasında ki tek ve çift sayıların toplamı
//int tekToplam = 0;
//int ciftToplam = 0;

//for (int i = 1; i < 1000; i++)
//{
//    if (i % 2 == 1)
//    {
//        tekToplam = i + tekToplam;
//    }
//    else
//    {
//        ciftToplam = i + ciftToplam;
//    }


//}
//Console.WriteLine("Tek Sayıların Toplamı : " + tekToplam);
//Console.WriteLine("Çift Sayıların Toplamı : "+ ciftToplam);



//for (int i = 1; i < 10; i++)
//{
//    if (i == 4)
//    {
//        break;
//    }
//    Console.WriteLine(i);
//}

//for (int i = 1; i < 10; i++)
//{
//    if (i == 4)
//    {
//        continue;

//    }
//    Console.WriteLine(i);
//}


//While döngüsü

// 1 den başlayarak konsoldan girilen sayıya kadar sayı dahil ortalama hesaplama 

//int sayi = int.Parse(Console.ReadLine());
//int sayac = 1;
//int toplam = 0;
//while (sayac <= sayi)
//{
//    toplam += sayac;
//    sayac++;

//}
//Console.WriteLine(toplam / sayi);



// a dan z ye kadar tum harfleri yazdır.

//char character = 'a';
//while (character <= 'z')
//{
//    Console.WriteLine(character);
//    character++;
//}


//foreach

string[] arabalar = { "BMW", "Nissan", "Toyota" };

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}
