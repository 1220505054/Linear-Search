
using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
        //dizi boyutu girilir
            Console.Write("Dizinin boyutunu giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[n];
            //dizinin elemanlari girilir
            Console.WriteLine("Dizinin elemanlarını giriniz:");
            for (int i = 0; i < n; i++)
            {
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            //bulunmak istenen deger girilir
            Console.Write("Aranacak elemanı giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int result = LinearSearch(dizi, x);
            if (result == -1)
            //girilen eleman dizide yoksa
                Console.WriteLine("Aranan eleman dizide bulunamadı.");
            else
                Console.WriteLine("Aranan eleman dizinin {0}. indeksinde bulundu.", result);
        }
// Linear Search algoritması kullanarak arama işlemi yapılır.
        public static int LinearSearch(int[] dizi, int x)
        {
            for (int i = 0; i < dizi.Length; i++)
                if (dizi[i] == x)
                    return i;
            return -1;
        }
    }
}
