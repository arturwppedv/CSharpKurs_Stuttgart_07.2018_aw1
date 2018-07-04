using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arr = new string[10, 5];
            Hashtable ht = new Hashtable();

            ht.Add(12, new List<DateTime>());
            ht.Add("555", 124566);
            ht.Add(arr, new int[] { 66, 77, 88 });
            //ht.Add(arr, new int[] { 5, 7789, 234 });

            List<string> list = new List<string>();
            List<List<string>> list2 = new List<List<string>>();    //2. Dim.
            List<string[]> list3 = new List<string[]>();

            //string s = list2[1][2];
            string s1 = arr[1, 2];

            //In Liste hinzufügen
            list2.Add(list);
            list2[0].Add("neuer String");
            list2.Add(list);
            list2[2].Add("anderer neuer String");

            //Aus Liste entfernen
            list.Remove("Heinz");
            list.RemoveAt(3);

            //Liste leeren
            list.Clear();

            //Alle Elemente, die Peter heißen entfernen
            list.RemoveAll(element => element == "Peter");

            //In der Liste suchen
            List<string> sucheList = list.Where(element => element == "Peter").ToList();

            int[] arr2 = (int[])ht[arr];
            Console.WriteLine(arr2[1]);
            Console.WriteLine(list2[0][0]);

            Console.ReadKey();
        }
    }
}
