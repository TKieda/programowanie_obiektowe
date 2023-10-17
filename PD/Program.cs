using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PD
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 2.1
            /*
             double C, F;
             Console.WriteLine("Podaj temp. w stopniach Celsjusza: ");
             C = double.Parse(Console.ReadLine());
             F = 32 + (9d / 5);
             Console.WriteLine(F);
             Console.ReadKey();
            */

            // Zadanie 2.2
            /*
            double a, b, c, delta;
            Console.WriteLine("Podaj a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            c = double.Parse(Console.ReadLine());
            delta = (b * b) - (4 * a * c);
            Console.WriteLine(delta);
            Console.ReadKey();
            */

            // Zadanie 2.3
            /*
            double BMI, masa, wzrost;
            Console.WriteLine("Podaj swoją wagę w kilogramach: ");
            masa = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój wzrost w metrach: ");
            wzrost = double.Parse(Console.ReadLine());
            BMI = masa / (wzrost * wzrost);
            Console.WriteLine(BMI);
            Console.ReadKey();
            */

            // Zadanie 2.4 - wyświetlona wartość to 202, ponieważ ++x najpierw dodało 1 dla x a potem nastąpiło mnożenie 101*2
            /*
            int x = 100;
            Console.WriteLine(++x * 2);
            Console.ReadKey();
            */

            //Zadanie 2.5 -  wyświetlona wartość to 12, ponieważ x=2, y=3 przez co działanie wyglądało następująco 2*3*2=12
            /*
            int x = 2, y = 3;
            x *= y * 2;
            Console.WriteLine(x);
            Console.ReadKey();
            */

            //Zadanie 2.6 - wyświetlony wynik to 3, ponieważ wartość x najpierw została wyświetlona a dopiero później odjęto od niego 1 (x=y--;)
            /*
            int x, y = 4;
            x = (y -= 2);
            x = y++;
            x = y--;
            Console.WriteLine(x);
            Console.ReadKey();
            */

            //Zadanie 2.7 - wyświetlony wynik to 7 ponieważ na początku y przyjmuje wartość 5, po czym zostaje dwukrotnie dodana wartość 1, raz odjęta i jeszcze raz dodana przed wyświetleniem 
            /*
            int x, y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
            Console.WriteLine(++y);
            Console.ReadKey();
            */

            //Zadanie 2.8 wartości zmiennych to x=true, y=1, z=2, x jest zmienną typu bool (true/false), dla y ustalona wartość to 1 a dla z=1 została dodana 1 przed porównaniem
            /*
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadKey();
            */

            //Zadanie 2.9

            //a) wynik=False x=2 y=4 z=2

            /*
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
            */

            //b) wynik=False x=2 y=5 z=2
            /*
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
            */

            //c) wynik=False x=2 y=5 z=1

            /*
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
            */

            //d) wynik=True x=1 y=3 z=4

            /*
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 || y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
            */

            //e) wynik=True x=1 y=4 z=4

            /*
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
            */

            //f) wynik=True x=1 y=4 z=5

            /*
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
            */
            
            //Zadanie 2.10 - ponieważ zmienne osoby oraz powierzchnia były typu int, wynik był wyświetlany jako liczba całkowita. W celu poprawnienia wystarczyło jedną z nich zmienić na zmiennoprzecinkową(double)
            /*
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = (double)osoby / powierzchnia;
            Console.WriteLine(gestoscZaludnienia);
            Console.ReadKey();\
            */
        }
    }
}