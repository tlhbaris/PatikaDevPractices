﻿int month = DateTime.Now.Month;


//Expression
switch (month)
{
    case 1:
        Console.WriteLine("Ocak");
        break;
    case2:
        Console.WriteLine("Şubat");
        break;
    case 4:
        Console.WriteLine("Nisan");
        break;
    case 3:
        Console.WriteLine("Mart");
        break;




    default:
        Console.WriteLine("Yanlış Veri Girdiniz");
        break;

}

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış Ayındasınız");
        break;

    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkBahar Ayındasınız");
        break;
    case 6:
    case 7: 
    case 8:
        Console.WriteLine("Yaz Ayındasınız");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("SonBahar Ayındasınız");
        break;





    default:
        break;
}