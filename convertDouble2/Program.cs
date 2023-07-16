using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertDouble2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen ondalıklı iki sayiyi toplayan kod blogu
            double sayi1, sayi2, toplam;
            Console.WriteLine("Lütfen toplamak istediğiniz iki ondalıklı sayidan ilkini girin : ");
            Console.WriteLine();
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("lütfen ikinci sayiyi giriniz : ");
            Console.WriteLine();
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            toplam = sayi1 + sayi2;
            Console.WriteLine("Girmis oldugunuz ondalıklı sayilarin toplami : " + toplam);

            Console.Read();
        }
    }
}
