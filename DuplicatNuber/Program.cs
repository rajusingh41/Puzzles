using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatNuber
{
    class Program
    {
        static void Main(string[] args)
        {
            // find duplicate number from integer arrya [1,2,3,5,6,2,6,5]
            // nubers of duplicate data is 3 ie. 2, 5,and 6 occure more than one time 

            //  first approch without linq  using Dictionary

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 5, 12, 8, 4, 20, 25, 12 };
            #region using Dictionary
            var dict = new Dictionary<int, int>();
            foreach (var item in array)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }
            int totalDuplicateRecord = 0;
            foreach (var duplicate in dict)
            {
                if (duplicate.Value > 1)
                {
                    totalDuplicateRecord++;
                    Console.WriteLine("value {0} occured {1} times \t\n ", duplicate.Key, duplicate.Value);
                }
            }
            Console.WriteLine("Total duplicate record is {0} \t\n ", totalDuplicateRecord);
            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Using two for loop 
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                var thisCount = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        thisCount++;
                    }
                }
                if (thisCount > 1)
                {
                    Console.WriteLine("value {0} occured {1} times \t\n ", array[i], thisCount);
                }
            }

            Console.WriteLine("Total duplicate record is {0} \t\n ", count);
            #endregion
            #region Using Linq 

            var duplicates = array.GroupBy(x => x);
            int _duplicates = 0;
            foreach (var item in duplicates)
            {
                if (item.Count() > 1)
                {
                    _duplicates++;
                    Console.WriteLine("Number {0} occurred {1} times.\t\n", item.Key, item.Count());
                }
            }

            Console.WriteLine("Total duplicate record is {0} \t\n ", _duplicates);
            #endregion
            Console.ReadLine();
        }
    }
}
