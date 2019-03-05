using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace FindDuplicatePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the total number of matching pairs 

            /*
             Question

            John works at a clothing store. He has a large pile of socks that he must pair by color for sale. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

            For example, there are socks with colors . There is one pair of color and one of color . There are three odd socks left, one of each color. The number of pairs is .

            Function Description

            Complete the sockMerchant function in the editor below. It must return an integer representing the number of matching pairs of socks that are available.

            sockMerchant has the following parameter(s):

            n: the number of socks in the pile
            ar: the colors of each sock


            Sample Input

                  n:  9
                  ar:  10 20 20 10 10 30 50 10 20

                    Sample Output

                    3

             */
            int n = 15;
            int[] array = { 5, 7, 8, 9, 5, 10, 12, 8, 5, 10, 15, 12, 3, 2, 8 };

            var numberOfMatchingPairs = GetMatchingPairs(n, array);
            Console.WriteLine("total number of matching pairs is {0}", numberOfMatchingPairs);
            Console.ReadLine();
        }

        private static object GetMatchingPairs(int n, int[] array)
        {
            int matchCount=0;
            var list = new List<int>();
            for(int i=0;i<array.Length;i++)
            {
                if(list.Contains(array[i]))
                {
                    matchCount++;
                    list.Remove(array[i]);

                }
                else
                {
                    list.Add(array[i]);
                }
            }
            return matchCount;
        }
    }
}
