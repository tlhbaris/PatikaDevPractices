// atama ve işlemli atama

int x = 3;
int y = 3;

y = y + 2;
y += 2;

y /= 1;
x *= 2;

Console.WriteLine(y);
Console.WriteLine(x);

//mantıksal opratörler
// ||, &&, ! 

bool isSuccess = true;
bool isCompleted = false;

if (isSuccess && isCompleted)
    Console.WriteLine("Perfect!");

if (isSuccess || isCompleted)
    Console.WriteLine("Great!");

if(isSuccess && !isCompleted)
    Console.WriteLine("Fine!");

//ilişkisel operatörler
//<, >, <=, >=, ==, !=

int a = 3;
int b = 4;
bool sonuc = a < b;

Console.WriteLine(sonuc);
sonuc = a > b;
Console.WriteLine(sonuc); 
sonuc = a != b;
Console.WriteLine(sonuc);

//Aritmetik operatorler
// /, *, +, -  
// % : mod alır

int sayi = 10;
int sonuc1;
sonuc1 = sayi++;
Console.WriteLine(sayi);




