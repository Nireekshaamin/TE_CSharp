using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Assignment18
    {
        public static void dictionaryExample()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "mick");
            dic.Add(2, "ben");
            dic.Add(3, "cal");
            dic.Add(4, "olive");
            dic.Add(5, "grace");
            Console.WriteLine("Names in the dictionary");
            foreach (var obj in dic)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            var key = new List<int>(dic.Keys);
            foreach (var obj in key)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            var values = new List<string>(dic.Values);
            foreach (var obj in values)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Key: {dic[1]}");
            //  Console.WriteLine($"Key: {dic[10]}");//If the key is not found ->exception

        }


        public static void hashtableExample()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "jared");
            ht.Add(2, 576105);
            ht.Add(3, "sanvi");
            ht.Add(4, 9141931635);
            ht.Add(5, "siri");
            ht.Add(6, 2581635);
            Console.WriteLine("HASHTABLE");
            //ICollection Interface
            ICollection key = ht.Keys;
            foreach (var obj in key)
            {
                Console.WriteLine(ht[obj]);
            }
            Console.WriteLine($"Key: {ht[1]}");
            Console.WriteLine($"Key: {ht[9]}");//If the key is not found -> null value
        }

        public static void Main()
        {
            dictionaryExample();
            Console.WriteLine("-----------------------------------------");
            hashtableExample();
        }

    }
}