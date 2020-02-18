using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInteraktywnie
{
    class Program
    {
        static void Main(string[] args)
        {
            // tu piszemy kod
            Console.WriteLine("Program EMERYTURA");
            Console.Write("Podaj swoje imie: ");
            string imie;
            imie = Console.ReadLine().Trim().ToUpper(); //toupper zamien na wielkie litery
            //imie = imie.Trim(); //weż stare imie przytnij i zapamietaj trimend(przycina koniec) i trim start (przycina poczatek)


            Console.Write("Podaj swoje nazwisko: ");
            string nazwisko = Console.ReadLine().Trim();

            string pierwszaLitera = nazwisko.Substring(0,1);
            string reszta = nazwisko.Substring(1); // substring to podnapis czyli wyciagnij z napisu kawałek
            nazwisko = pierwszaLitera.ToUpper() + reszta.ToLower();


           //Console.WriteLine("Witaj, " + imie + " " + nazwisko + "!");
           //Console.WriteLine("Witaj, {0} {1}!", nazwisko, imie); //formatted string
            Console.WriteLine($"Witaj, {imie} {nazwisko}!");

            Console.Write("Podaj swój wiek: ");
            int wiek;
            string s = Console.ReadLine();
            wiek = int.Parse(s);
            Console.WriteLine($"Masz {wiek} lat.");

            //jeżeli wiek jest > 67 to jesteś emerytem
            // a w przeciwnym przypadku do emerytury zostało ci 67 - wiek lat

            if ( wiek >= 67)
            {
                Console.WriteLine("jesteś emerytem");
            }
            else
            {
                Console.WriteLine($"Do emerytury zostało ci {67-wiek} lat");
            }


         

        }
    }
}
