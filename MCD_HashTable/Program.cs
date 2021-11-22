using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace MCD_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();

            #region Yeni Değer Ekleme

            H1.Add("Car", "Araba");
            H1.Add("House", "Ev");

            H1.Add("Cars", "Arabalar");
            //H1.Add("Cars", "Arabalar"); Key değeri benzersiz olmak zorundadır.

            foreach (var item in H1.Keys)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Yardımcı Metotlar

            bool Kontrol1 = H1.ContainsKey("House");
            bool Kontrol2 = H1.ContainsKey("Door");
            Console.WriteLine(Kontrol1);
            Console.WriteLine(Kontrol2);

            bool Kontrol3 = H1.ContainsKey("House");
            bool Kontrol4 = H1.ContainsKey("Araba");

            Console.WriteLine(Kontrol3);
            Console.WriteLine(Kontrol4);

            foreach (DictionaryEntry de in H1)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }

            H1["House"] = "Villa";

            H1.Remove("Cars");

            Console.WriteLine("**************");

            foreach (var item in H1.Keys)
            {
                Console.WriteLine(H1[item] + " " + item);
            }

            int koleksiyonIcindekiToplamDeger = H1.Count;
            Console.WriteLine(koleksiyonIcindekiToplamDeger);

            H1.Clear(); // Koleksiyon içerisindeki tüm datayı temizleriz.

            int koleksiyonIcındekiToplamDeger2 = H1.Count;
            Console.WriteLine(koleksiyonIcındekiToplamDeger2);


            #endregion



            Console.ReadLine();
        }
    }
}
