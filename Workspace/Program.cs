
using Business.Concrete;
using Entities.Concrete;
using System.Collections.Generic;

SelamVer(isimm:"Muhammed");
SelamVer(isimm: "Muhammed");
SelamVer();
int sonuc = Topla(3,6);

static void SelamVer(string isimm="isimsiz")
{   
    Console.WriteLine("Merhaba" + isimm);
}
static int Topla(int sayi1, int sayi2)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam :" + sonuc);
    return sonuc;
}

// Diziler / Arrays
string ogrenci1 = "Muhammed";
string ogrenci2 = "Kerem";
string ogrenci3 = "Berkay";
string[] ogrenciler = new string[3];
ogrenciler[0] = "muhamemd";
ogrenciler[1] = "Engin";
ogrenciler[2] = "berkay";

ogrenciler = new string[4];
ogrenciler[3] = "İlker";

for(int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}
string[] sehirler1 = new[] { "Ankara", "İstanbul", "Bursa" };
string[] sehirler2 = new[] { "İzmir", "Aydın", "Marmaris" };
foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}
List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "Batman1" };
yeniSehirler1.Add("Adana1");
foreach(var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}
Person person1= new Person();
person1.FirstName = "Muhammed";

Person person2= new Person();
person2.FirstName = "Roges";






PttManager pttManager = new PttManager(new ForeignerManeger());
pttManager.GiveMask(person1); 









    















