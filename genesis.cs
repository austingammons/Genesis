// Q.3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function to combine 2 arrays of string
            // removing duplicates. (Use any language or pseudo-code).

            List<string> list1 = new List<string>()
            {
                "a",
                "b",
                "c",
                "d",
            };

            List<string> list2 = new List<string>()
            {
                "a",
                "b",
                "j",
                "f",
            };

           
            List<string> result = new ResolveDuplicate().ResolveDuplicateList(list1, list2);
            // List<string> result_v2 = new ResolveDuplicate().ResolveDuplicateList_v2(list1, list2);

            foreach (var item in result)
            {
                Console.WriteLine(item + " \n");
            }

            Console.ReadLine();
        }
    }

    interface IResolveDuplicate<T>
    {
        List<T> ResolveDuplicateList(List<T> list1, List<T> list2);
    }

    class ResolveDuplicate : IResolveDuplicate<string>
    {
        public List<string> ResolveDuplicateList(List<string> list1, List<string> list2)
        {
            List<string> collection = list1.Concat(list2).ToList();

            collection = collection.GroupBy(x => x).Where(x => !x.Skip(1).Any()).Select(x => x.Key).ToList();

            return collection;
        }
        
        public List<string> ResolveDuplicateList_v2(List<string> list1, List<string> list2)
        {
            List<string> collection = new List<string>();

            foreach (string listItem1 in list1)
            {
                if (!list2.Contains(listItem1))
                {
                    collection.Add(listItem1);
                }
            }

            foreach (string listItem2 in list2)
            {
                if (!list1.Contains(listItem2))
                {
                    collection.Add(listItem2);
                }
            }

            return collection;
        }
    }
}
