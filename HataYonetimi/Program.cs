//try
//{
//    Console.WriteLine("Bir Sayı Giriniz");
//    int sayi = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Girmiş Olduğunuz Sayı :" + sayi);

//}
//catch (Exception ex )
//{
//    Console.WriteLine("Hata:" + ex.Message.ToString());

//}
//finally
//{
//    Console.Write("İşlem Tamanlandı.");

//}


try
{

    //int a = int.Parse(null);
   // int a = int.Parse("test");
    int a = int.Parse("-20000000000");
    


}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş Değer Girdiniz");
    Console.WriteLine(ex);
}
catch(FormatException ex )
{
    Console.WriteLine("Veri Tipi Uygun Değil");
    Console.WriteLine(ex);

}
catch(OverflowException ex)
{
    Console.WriteLine("Çok büyük ya da çok küçük değer girdiniz.");
    Console.WriteLine(ex);

}

finally
{
    Console.WriteLine("İşlem Başarıyla Tamamlandı.");

}

