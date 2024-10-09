using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double değişkenler
            /*apple14,85 orange20,95 strawberry45 potato9,74 tomato6,88
             price gram
            totalprice
            shoppingtotalprice
             */
            /*
            Console.WriteLine("----- Fiyat Listesi ----- ");
            Console.WriteLine();

            double applePrice = 14.85, orangePrice = 20.95, strawberryPrice = 45, potatoPrice = 9.74, tomatoPrice = 6.88;
            Console.WriteLine("----Elma birim fiyatı: " + applePrice + "TL");
            Console.WriteLine("----Portakal birim fiyatı: " + orangePrice + "TL");
            Console.WriteLine("----Çilek birim fiyatı: " + strawberryPrice + "TL");
            Console.WriteLine("----Patates birim fiyatı: " + potatoPrice + "TL");
            Console.WriteLine("----Domates birim fiyatı: " + tomatoPrice + "TL");

            Console.WriteLine();
            Console.WriteLine();

            double appleGram = 1.245, orangeGram = 2.65, strawberryGram = 0.75, potatoGram = 4.859, tomatoGram = 3.745;
            double appleTotal = appleGram * applePrice;
            double orangeTotal = orangeGram * orangePrice;
            double strawberryTotal = strawberryGram * strawberryPrice;
            double potatoTotal = potatoGram * potatoPrice;
            double tomatoTotal = tomatoGram * tomatoPrice;

            Console.WriteLine("Alınan ürün Elma - Birim Fiyatı:" + applePrice + " - Gramaj:" + appleGram + " - Toplam Tutar:" + appleTotal);
            Console.WriteLine("Alınan ürün Portakal - Birim Fiyatı:" + orangePrice + " - Gramaj:" + orangeGram + " - Toplam Tutar:" + orangeTotal);
            Console.WriteLine("Alınan ürün Çilek - Birim Fiyatı:" + strawberryPrice + " - Gramaj:" + strawberryGram + " - Toplam Tutar:" + strawberryTotal);
            Console.WriteLine("Alınan ürün Patates - Birim Fiyatı:" + potatoPrice + " - Gramaj:" + potatoGram + " - Toplam Tutar:" + potatoTotal);
            Console.WriteLine("Alınan ürün Domates - Birim Fiyatı:" + tomatoPrice + " - Gramaj:" + tomatoGram + " - Toplam Tutar:" + tomatoTotal);
            double shoppingTotalPrice = appleTotal + orangeTotal + strawberryTotal + potatoTotal + tomatoTotal;
            Console.WriteLine("Toplam Alışveriiş Tutarı: " + shoppingTotalPrice + " TL");
            Console.Read();*/
            #endregion

            #region char 
            /*
            char symbol = 'a';
            Console.WriteLine(symbol);
            Console.Read();
            */
            #endregion

            #region klavyeden girilen string değişkenler 
            /*
            Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            Console.WriteLine();
            Console.WriteLine();
            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            Console.WriteLine("Yolcu Adı: ");
            passengerName = Console.ReadLine();
            Console.WriteLine("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();
            Console.WriteLine("İlçe: ");
            passengerDistrict = Console.ReadLine();
            Console.WriteLine("Şehir: ");
            passengerCity = Console.ReadLine();
            Console.WriteLine("Yaş: ");
            passengerAge = Console.ReadLine();
            Console.WriteLine("Kimlik Numarası: ");
            passengerIdentityNumber = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Yolcu Kimlik Numarası " + passengerIdentityNumber + "- Yolcu Ad Soyad " + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge);
            Console.Read();
            */
            #endregion

            #region klavyeden girilen tam sayı girişleri ve dönüşümler 
            /*
            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;
            int shoesCount, computerCount, chairCount, tvCount;
            Console.Write("alınan ayakkabı adeti: ");
            shoesCount = int.Parse(Console.ReadLine());
            Console.Write("alınan bilgisayar adeti: ");
            computerCount = int.Parse(Console.ReadLine());
            Console.Write("alınan sandelye adeti: ");
            chairCount = int.Parse(Console.ReadLine());
            Console.Write("alınan televizyon adeti: ");
            tvCount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int totalPrice = (shoesPrice * shoesCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);
            Console.WriteLine("Toplam Alışveriş Tutarı: " + totalPrice);
            Console.Read(); */
            #endregion

            #region klavyeden girilen ondalıklı sayı işlemleri 
            /*double exam1, exam2, exam3, result;
            Console.WriteLine("1.sınav notu: ");
            exam1 = double.Parse(Console.ReadLine());
            Console.WriteLine("2.sınav notu: ");
            exam2 = double.Parse(Console.ReadLine());
            Console.WriteLine("3.sınav notu: ");
            exam3 = double.Parse(Console.ReadLine());
            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("sınav ortalaması: "+result);
            Console.Read();*/
            #endregion

            #region klavyeden girilen char değişkenleri 
            /*char gender;
            Console.WriteLine("cinsiyet: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Seçilen cinsiyet: " + gender);
            Console.Read();*/
            #endregion


        }
    }
}
