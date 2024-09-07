// See https://aka.ms/new-console-template for more information


// Değişkenler : 

// Bir yazılımda, yazılımın içerisinde değer girme iki şekilde olur.

// 1- kullanıcıdan değer alma
// 2- direk değeri yazılım içine girmek
// 3- değeri, bir veri kaynağından çekmek


// her 3 senaryoda da, bir şekilde yazılım veriye ulaşır. 
// Yazılım içerisindeki her türlü veri, eğer bir kaynağı yoksa(veri tabanı) tüm verileri, memory'de tutar.

// değişken tanımlanırken, türkçe karakter kullanılmamalıdır.
// degisken tanımlanırken, değişken isminde, boşluk olmamalıdır. 
// değişlen isimlendirilirken, kesinlikle rakam ile başlamamalıdır.
// değişken isimlendirilirken, değişken ismi, iki kelimeden olaşacaksa, camel case şeklinde yazılmalıdır.  Örnek :  wissenDegisken Örnek : wissenDegiskenBesiktas
// değişken isimlendirilirken, çok uzun isim koyulmamalıdır.
// değişken isimlendirilirken, taşıdığı değer ile ilgili bir isim bulunmalıdır.
// değişken isimlendirilirken, asla saçma isimler verilmemelidir. Örnek : x,y,asd,xyz
// değişken isimlendirilirken, büyük harf kullanılmamalıdır.
// değişken tek kelime ise, küçük harf kullanılmalıdır.

// değişken tanımlarken, syntax şu şekilde olmalıdır.

// değişkenin tipi değişkenin adı = değişkenin taşıyacağı değer

// int tipinde bir değişken tanımladım
int intDegisken = 8;

// byte değişken tanımladık
byte byteDegisken = 244;

// Ondalık değişken tanımlayalım
decimal ondalikDegisken = 9.7M;

// Tek Karakter değişken
char charDegisken = 'E';

// değişken isimleri aynı isimde olmamalıdır. Zaten olması durumunda uygulama hata verecektir.

//string değişken tanımlarken değer, çift tırnak "" içerisine yazılmalıdır..
string stringDegisken = "ben bir string değişkenim";




// herkes 10'ar tane farklı tipte değişken tanımlayınız!!


// tanımladığımız değişkenleri, intelisence ekranından görebilirsiniz.


// Tanımlamış olduğumuz değişkenleri ekrana yazdıralım

Console.WriteLine(stringDegisken);

// int tipinde bir değişkenin değerini ekrana yazdıralım

Console.WriteLine(intDegisken);

// ondalık değişkeni ekrana yazdıralım

Console.WriteLine(ondalikDegisken);


// Console.Writeline içerisinde matematiksel işlem yapılabilir.

//operatörler : (+,-,*,/,%)

int birinciSayi = 10;
int ikinciSayi = 35;

Console.WriteLine("Toplama :"+birinciSayi+ikinciSayi);
//Console.WriteLine("Çıkarma : "ikinciSayi-birinciSayi);
Console.WriteLine("Çarpma :"+birinciSayi*ikinciSayi);
Console.WriteLine("Bölme :"+ikinciSayi/birinciSayi);
Console.WriteLine("Mod:"+ikinciSayi%birinciSayi);



// + operatörü ne yaptı ? 
// + operatörü, iki matematiksel veriyi birbiri ile toplar.!!
// + operatörü iki metinsel veriyi birbiri ile birleştirir
// metinsel veri ile rakamsal veri arasındaki + operatörü birleştirme işlemi yapar.

// Örnek : string wissen ="wissen"
//         string besiktas = "besiktaş"

// wissen+besiktas;
// Çıktı : wissenbesiktas

// Cumertesi konusu , metinsel işler operatörler..


int age = 30;

// değişkenin farklı bir tanımlama şekli yokmu ?

// degiskeni tanımladım ama değerini vermedim
string city;

// değerini bir alt satırda verebiliriz.
city="ben metinsel bir değişkenim";

// farklı bir tanımlama şekli

int birinciDegisken,ikinciDegisken,ucuncuDegisken;

// değer atayalım
birinciDegisken=5;
ikinciDegisken=15;
ucuncuDegisken=20;

// yukarıda değerleri verilen değişkenin değerini değiştirelim
birinciDegisken=50;


// bir değişkene farklı zamanlarda iki değer atandığında, her zaman son değeri taşıyacaktır.


// farklı tiplerdeki verileri farklı tip değişkene atmaya çalışalım.

int stringAtananInt="int tipine string değer vermek";

// farklı bir tipte veriyi, farklı bir tip taşıyabilen bir değişkene atamak istediğimizde, derleme zamanı hatası alırız.

// derleme zamanı hatası, kodun derleyici tarafından derleyemesi, dolayısıyla çalışmaması anlamına gelir.



//int icerinsindeRakamOlanString = "10";


// bilinçli ve bilinçsiz tip dönüşümlerinde bu konuyu göreceğiz.(Burada büyük tipin, küçük tipe atanması konusunu gördük.)

// büyük tip, küçük tipe atanmaya çalışıldığı için, veri kaybı olabilir endişesi ile, derleyici bizim onay verip, tip dönüşümü yapmamızı istedi.
//byte byteAtanacak;
//int  intAtanmis=100;
//byteAtanacak=intAtanmis;


// küçük tip, büyük tipe atanmaya çalışıldığı için, derleyici bu işlemi kendi kendine yaptı
//int buyukSayi ;
//byte kucukSayi = 155;
//buyukSayi=kucukSayi;



/*

Çoklu satır yorum satırı yapmak için, bu yapıyı kullanabilirsiniz.

*/