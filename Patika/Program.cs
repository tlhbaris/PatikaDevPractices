//int n = Convert.ToInt32(Console.ReadLine());
//int sonuc = 0;

//for (int i = 1; i <= 10; i++)
//{
//    sonuc = i * n;
//    Console.WriteLine(n.ToString() + " x " + i.ToString() + " = " + sonuc);
//}



//Console.WriteLine("Sayı Gir");
//int n = int.Parse(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("#");

//    }
//    Console.WriteLine("");


//}

int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++)
    Console.WriteLine(new String('#', i + 1).PadLeft(N, ' '));


