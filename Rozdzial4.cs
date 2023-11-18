using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdzial4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 4.1

            /*
            Console.Write("Podaj liczbę elementów tablicy: ");
            int n = int.Parse(Console.ReadLine());

            // Deklaracja i inicjalizacja tablicy o rozmiarze n
            int[] tablica = new int[n];

            // Wypełnianie tablicy wartościami podanymi przez użytkownika
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Podaj wartość dla elementu {i + 1}: ");
                tablica[i] = int.Parse(Console.ReadLine());
            }

            // Wyświetlanie zawartości tablicy
            Console.WriteLine("\nZawartość tablicy:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Element {i + 1}: {tablica[i]}");
            }

            Console.ReadLine();
            */

            // Zadanie 4.2
            /*

            int[] tab1 = { -2, 5, -8, 10, -3, 7, 1, -6, 4, -9 };
            int[] tab2 = new int[10];

            int indeksTab2 = 0;

            foreach (int liczba in tab1)
            {
                if (liczba > 0)
                {
                    tab2[indeksTab2++] = liczba;

                    if (indeksTab2 == tab2.Length)
                        break;
                }
            }

            Console.WriteLine("Zawartość tablicy tab1:");
            foreach (int liczba in tab1)
                Console.Write(liczba + " ");

            Console.WriteLine("\nZawartość tablicy tab2 (wartości dodatnie z tab1):");
            foreach (int liczba in tab2)
                Console.Write(liczba + " ");

            Console.ReadLine();
            */

            //Zadanie 4.3

            /*
            Console.Write("Podaj liczbę elementów tablicy: ");
            int n = int.Parse(Console.ReadLine());

            // Deklaracja i inicjalizacja tablicy o rozmiarze n
            int[] tablica = new int[n];

            // Wypełnianie tablicy wartościami podanymi przez użytkownika
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Podaj wartość dla elementu {i + 1}: ");
                tablica[i] = int.Parse(Console.ReadLine());
            }

            // Wyszukiwanie największego i najmniejszego elementu oraz sumy wszystkich elementów
            int najwiekszy = tablica[0];
            int najmniejszy = tablica[0];
            int suma = tablica[0];
            int liczbaDodatnich = (tablica[0] > 0) ? 1 : 0;

            for (int i = 1; i < n; i++)
            {
                suma += tablica[i];

                if (tablica[i] > najwiekszy)
                    najwiekszy = tablica[i];

                if (tablica[i] < najmniejszy)
                    najmniejszy = tablica[i];

                if (tablica[i] > 0)
                    liczbaDodatnich++;
            }

            // Wyświetlanie informacji
            Console.WriteLine($"\nNajwiększy element: {najwiekszy}, na pozycji: {Array.IndexOf(tablica, najwiekszy) + 1}");
            Console.WriteLine($"Najmniejszy element: {najmniejszy}, na pozycji: {Array.IndexOf(tablica, najmniejszy) + 1}");
            Console.WriteLine($"Średnia wartość: {(double)suma / n}");
            Console.WriteLine($"Liczba dodatnich elementów: {liczbaDodatnich}");

            
            Console.ReadLine();
            */

            //Zadanie 4.5

            /*
            Console.Write("Podaj rozmiar tablicy: ");
            int n = int.Parse(Console.ReadLine());

            // Inicjalizacja tablicy źródłowej
            int[] tab1 = new int[n];

            Console.WriteLine("Podaj elementy tablicy źródłowej:");

            // Wypełnianie tablicy źródłowej
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i}: ");
                tab1[i] = int.Parse(Console.ReadLine());
            }

            // Inicjalizacja tablicy docelowej
            int[] tab2 = new int[n];

            // Kopiowanie z przesunięciem o jedną pozycję
            for (int i = 0; i < n; i++)
            {
                tab2[(i + 1) % n] = tab1[i];
            }

            // Wyświetlanie tablicy źródłowej
            Console.WriteLine("\nTablica źródłowa:");
            foreach (var element in tab1)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();

            // Wyświetlanie tablicy docelowej
            Console.WriteLine("\nTablica docelowa (z przesunięciem o jedną pozycję):");
            foreach (var element in tab2)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();

            // Zatrzymywanie programu przed zamknięciem konsoli
            Console.ReadLine();
            */
        }
    }
}
