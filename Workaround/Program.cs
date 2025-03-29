using Business.Concrete;
using Entities.Concrete;
using Business.Abstract;


Console.WriteLine("Engin Demiroğ ile Sahura Doğru");

Vatadas vatandas = new Vatadas();

SelamVer(isim: "Ali");
SelamVer(isim: "Efe");
SelamVer(isim: "Hüseyin");
SelamVer();




int sonuc = Topla(3,5);

//Diziler /Arrays 

string[] ogrenciler = new string[3];   //Dizi yerine ( [] ) teker teker öğrencileri string ile tanımlayıp yazdırmak amelelik olacaktır.
                                       //Diziler bizi bu tarz durumlarda kurtarır.
ogrenciler[0] = "Gandalf";
ogrenciler[1] = "The";
ogrenciler[2] = "Coder";

for (int i = 0; i < ogrenciler.Length; i++)  //Dizimizi bu for döngüsü ile yazdırıyoruz.
{
    Console.WriteLine(ogrenciler[i]);
  
}


string[] sehirler1 = new[] {"Ankara","İstanbul","İzmir"};
string[] sehirler2 = new[] {"Bursa","Antalya","Diyarbakır"};
        //sehirler 1 ve sehirler 2 ye atamlar yaptık fakat sonrasında sehirler2 = sehirler 1 dedik bu saydede 2 yi 1 e bağlamış olduk. 
sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);


Person person1 = new Person();
person1.FirstName = "Özlem";
person1.LastName = "Karabıyık";
person1.DateOfBirthYear = 1979;
person1.NationalIdentity = 26653218272;

Person person2 = new Person();
person2.FirstName = "Murat";

//foreach döngüleri ile sehirler1 dizimizi döndürüyoruz.

foreach (string sehir in sehirler1) 
{ 
    Console.WriteLine(sehir);
}




//MyList Diziler yerine daha kullanışlı Listler.

List<string> yeniSehirler1 = new List<string> {"Ankara 1" , "İstanbul 1" , "İzmir 1 " };
yeniSehirler1.Add("Adana 1");

foreach (var sehir in yeniSehirler1) 
{
    Console.WriteLine(sehir);
}



PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);



Console.ReadLine();




static void SelamVer(string isim="isimsiz")
{
    Console.WriteLine("Merhaba " + isim);


}


static int Topla(int sayi1 =5 , int sayi2 = 10) // default olarak atamalar yaparsak topla değerinin içerisinde bir şey olmadığı zaman bunları kabul eder.
{                                               //sayi1 e default bir atama yapmadan topla değişkenine bir sayı yazarak atabiliriz ama bunu sayi2 için yapamayız çünkü ilk olarak ilk değişkene atanır.                     
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam: " + sonuc);
    return sonuc;
}



static void Degiskeler()
{

    string mesaj = "Merhaba";
    double tutar = 100000;
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Özlem";
    string soyad = "Karabıyık";
    int dogumYili = 1977;
    long tcNo = 26653218272;

    Console.WriteLine(tutar * 1.18);



}


//pascal casing 
public class Vatadas
{
    public string Ad { get; set; }

    public string Soyad { get; set; }

    public int DogumYili { get; set; }

    public long TcNo { get; set; }
}
