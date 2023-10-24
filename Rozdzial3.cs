using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rozdzial3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 3.1
            /*
            int rok;
            Console.WriteLine("Podaj rok: ");
            rok = int.Parse(Console.ReadLine());
            if (rok % 4 == 0)
                Console.WriteLine("To jest rok przestępny.");
            else
                Console.WriteLine("To nie jest rok przestępny.");
            Console.ReadKey();
            */


            // Zadanie 3.2
            /*
            int a,b;
            Console.WriteLine("Podaj pierszą cyfrę: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą cyfrę: ");
            b = int.Parse(Console.ReadLine());
            if (a%b==0)
                Console.WriteLine("Druga cyfra jest dzielnikiem pierwszej.");
            else
                Console.WriteLine("Druga cyfra nie jest dzielnikiem pierwszej.");
            Console.ReadKey();
            */

            // Zadanie 3.3
            /*
            int a,b,c;
            Console.WriteLine("Podaj pierszą cyfrę: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą cyfrę: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią cyfrę: ");
            c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                  if (a > c)
                {
                    Console.WriteLine("Cyfra {0} jest największa.", a);
                }

                else
                {
                    Console.WriteLine("Cyfra {0} jest największa.", c);
                }
             }

            else
            {
                if (b > c)
                {
                    Console.WriteLine("Cyfra {0} jest największa.", b);
                }

                else
                {
                    Console.WriteLine("Cyfra {0} jest największa.", c);
                }
            }
            Console.ReadKey();
            */

            // Zadanie 3.4
            /*
            double a, b, wynik;
            Console.WriteLine("Podaj pierszą cyfrę: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj znak działania (+, -, *, /): ");
            char znak = Console.ReadKey().KeyChar;
            Console.WriteLine("\r\nPodaj drugą cyfrę: ");
            b = double.Parse(Console.ReadLine());

            switch (znak)
            {
                
                case '+':
                    {
                        wynik = a + b;
                        Console.WriteLine("\nWynik: {0}", wynik);
                        break;
                    }
                    
                case '-':
                    {
                        wynik = a - b;
                        Console.WriteLine("\nWynik: {0}", wynik);
                        break;
                    }
                case '*':
                    {
                        wynik = a * b;
                        Console.WriteLine("\nWynik: {0}", wynik);
                        break;
                    }
                case '/':
                    {
                        wynik = a / b;
                        if (b != 0)
                        {
                            Console.WriteLine("Wynik: {0}", wynik);
                            
                        }
                        else
                        {
                            Console.WriteLine("\nNie można dzielić przez 0!");
                        }
                        break;
                    }

                default:
                    Console.WriteLine("Błąd: Nieprawidłowy znak operacji.");
                    break;
                
            }
           Console.ReadKey();
           */
            // Zadanie 3.5
            /*
            double a, b, c, delta;
            Console.Write("Podaj a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Podaj b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Podaj c: ");
            c = double.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                Console.WriteLine("Równanie ma dwa pierwiastki.");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Równanie ma jeden pierwiastek.");
            }
            else
            {
                Console.WriteLine("Równanie nie ma pierwiastków.");
            }
            Console.ReadLine();
            */

            // Zadanie 3.6
            /*
            double masa, wzrost, BMI;
            Console.WriteLine("Podaj masę w kilogramach: ");
            masa = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokość w metrach: ");
            wzrost = double.Parse(Console.ReadLine());
            BMI = masa / (wzrost*wzrost);
            Console.WriteLine("BMI wynosi {0}", BMI);

            if (BMI < 18.5)
            {
                Console.WriteLine("Masz niedowagę.");
            }
                
            else if (BMI>=18.5 && BMI <= 24.99)
            {
                Console.WriteLine("BMI prawidłowe.");
            }
                
            else
            {
                Console.WriteLine("Masz nadwagę.");
            }
                
            Console.ReadKey();
            */

            // Zadanie 3.7-3.8
            /*
            double srednia, kwota;

            Console.Write("Podaj średnią: ");
            srednia = double.Parse(Console.ReadLine());

            switch (srednia)
            {
                case double ocena when ocena >= 4.00 && ocena <= 4.79:
                    kwota = 350.00;
                    break;
                case double ocena when ocena >= 4.80 && ocena <= 5.00:
                    kwota = 550.00;
                    break;
                default:
                    kwota = 0.00;
                    break;
            }

            Console.WriteLine("Kwota stypendium wynosi: {0}", kwota);
            Console.ReadLine();
            */

            //Zadanie 3.10
            /*
            int n, wynik=1;
            Console.Write("Podaj liczbę n: ");
            n = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= n; i++)
            {
                wynik= wynik*i;
            }

            Console.WriteLine("n! jest równe {0}",wynik);
            Console.ReadLine();
            */
            //Zadanie 3.11
            /*
            int suma = 0;
            int liczba = 1;
            int ile = 0;

            while (suma <= 100)
            {
                suma += liczba;
                liczba++;
                ile++;
            }

            Console.WriteLine("Aby suma przekroczyła 100, trzeba dodać {0} kolejnych liczb całkowitych.", ile);
            Console.ReadLine();
            */
            //Zadanie 3.12
            /*
            int suma = 0, liczba;
            
            Console.WriteLine("Podawaj liczby całkowite (wprowadź 0, aby zakończyć):");

            for ( ; ; )
            {
                Console.Write("Podaj liczbę: ");
                if (int.TryParse(Console.ReadLine(), out liczba))
                {
                    suma += liczba;

                    if (liczba == 0)
                        break;
                }
                else
                {
                    Console.WriteLine("To nie jest liczba całkowita. Spróbuj ponownie.");
                }
            }

            Console.WriteLine("Suma wprowadzonych liczb to: {0}", suma);
            Console.ReadLine();
            */

            
        }
    }
}
