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