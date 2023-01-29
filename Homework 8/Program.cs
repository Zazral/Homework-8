using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Homework_8
{
    class Program
    {
        static List<int> filing(List<int> lst)
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                lst.Add(rand.Next(100));
            }
            return lst;
        }
        static void listprint(List<int> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine("\t"+lst[i]);
            }
        }
        static List<int> remove(List<int> lst)
        {
            for(int i = 0; i < lst.Count; i++)
            {
                if (lst[i] > 25 && lst[i] < 50)
                {
                    lst.RemoveAt(i);
                    i--;
                }
            }
            return lst;
        }
        static void pz1()
        {
            List<int> lst = new List<int>();
            filing(lst);
            listprint(lst);
            Console.ReadKey();
            Console.WriteLine("---------------------");
            remove(lst);
            listprint(lst);
            Console.ReadKey();
        }
        static Dictionary<long, string> ReadDict(Dictionary<long, string> dict)
        {
            Console.WriteLine("write phone number and name throught a space");
            string[] str = new string[2];
            while(true)
            {
                try
                {
                    str = Console.ReadLine().Split(' ');
                    dict.Add(long.Parse(str[0]), str[1]);
                }
                catch
                {
                    break;
                }
            }
            return dict;
        }
        static void search(Dictionary<long, string> dict)
        {
            Console.WriteLine("what number search");
            long x = long.Parse(Console.ReadLine());
            if (dict.TryGetValue(x, out string value))
            {
                Console.WriteLine(x + "---" + value);
            }
            else Console.WriteLine($"{x} is not found");
        }
        static void pz2()
        {
            Dictionary<long, string> dict = new Dictionary<long, string>();
            ReadDict(dict);
            while(true)
            {
                Console.WriteLine("\nwant to search by phone nuber \n1-yes, 2-no");
                int x = byte.Parse(Console.ReadLine());
                if (x == 1) search(dict);
                else break;
            }
            Console.ReadKey();
        }
        static HashSet<int> hashRead(HashSet<int> hSet)
        {
            Console.WriteLine("fill hashset");
            int x = 0;
            while(true)
            {
                if (Int32.TryParse(Console.ReadLine(), out x))
                {
                    if (hSet.Contains(x)) Console.WriteLine("number exist");
                    else hSet.Add(x);
                }
                else break;
            }
            return hSet;
        }
        static void pz3()
        {
            HashSet<int> hSet = new HashSet<int>();
            hashRead(hSet);
            foreach(var e in hSet)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
        static void pz4()
        {
            List<string> lst = new List<string>();
            Console.WriteLine("введите имя, улицу, номер дома, номер квартиры," +
                "\n мобильный телефон и домашний телефон разделяя enter");
            for(int i = 0; i < 6; i++)
            {
                lst.Add(Console.ReadLine());
            }
            PhoneNumber PhNum = new PhoneNumber(Convert.ToInt64(lst[4]), Convert.ToInt64(lst[5]));
            Adres adr = new Adres(lst[1], Convert.ToInt32(lst[2]), Convert.ToInt32(lst[3]));
            Person Per = new Person(lst[0], adr, PhNum);
            XmlSerializer s = new XmlSerializer(typeof(Person));
            Stream fstream = new FileStream("Adres.txt", FileMode.Create, FileAccess.Write);
            s.Serialize(fstream, Per);
            fstream.Close();
        }
        static void Clear()
        {
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            pz1();
            Clear();
            pz2();
            Clear();
            pz3();
            Clear();
            pz4();
            Clear();
        }
    }
}
