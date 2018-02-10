using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nechetniWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string[] words = word.Split(' ').ToArray();
            var counts = new SortedDictionary<string, int>();
            foreach (var key in words)
            {
                if (counts.ContainsKey(key))
                {
                    counts[key]++;
                }
                else
                {
                    counts[key] = 1;
                }
            }
            //counts.Keys.ToList().Sort();
            Console.WriteLine(string.Join("- ", counts));
            var result = new List<string>();
            foreach (var item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
