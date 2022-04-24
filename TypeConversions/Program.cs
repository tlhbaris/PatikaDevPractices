//Implicit Conversion (Bilinçsiz Dönüşüm)

byte a = 5;
sbyte b = 30;
short c = 10;

int m = a;
int d = a+b+c;
Console.WriteLine("d:" + d);

long h = d;
Console.WriteLine("h:"+h);

float i = h;
Console.WriteLine("i:" + i);

string e = "Talha";
char f = 'k';
object g = e + f + d;
Console.WriteLine("g:"+g);




//Explicit Conversion (Bilinçli Dönüşüm)

int x = 4;
byte y = (byte)x;
Console.WriteLine("y:"+y) ;

int z = 100;
byte t = (byte)z;
Console.WriteLine("t:"+t);

float w = 10.3f;
byte v = (byte)w;
Console.WriteLine("v:" + v);


// *** ToString Methodu ***

int xx = 6;
string yy = xx.ToString();
Console.WriteLine("yy:"+yy);

string zz = 12.5f.ToString();
Console.WriteLine("zz:" + zz);

//System.Convert 

string s1 = "10", s2 = "20";

int sayi1, sayi2;
int Toplam;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);

Toplam = sayi1 + sayi2;
Console.WriteLine(Toplam);


// Parse Method

string metin1 = "10", metin2 = "10,25";
int rakam1;
double double1;

rakam1= Int32.Parse(metin1);
double1 =Double.Parse(metin2);

Console.WriteLine(rakam1);
Console.WriteLine(double1);

int ab = 5;

DateTime ac = Convert.ToDateTime(ab);





