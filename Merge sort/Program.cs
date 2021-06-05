/* 
 
Project by :
Name: Md Saniat Hossain
Id: 50045
 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Merge_sort

{

    class MergeSort

    {

        static public void merge(int[] num, int l, int cen, int r)

        {

            int[] t_new = new int[1000];

            int d, l_end, n_elem, t_p;

            l_end = (cen - 1);

            t_p = l;

            n_elem = (r - l + 1);

            while ((l <= l_end) && (cen <= r))

            {

                if (num[l] <= num[cen])

                    t_new[t_p++] = num[l++];

                else

                    t_new[t_p++] = num[cen++];

            }

            while (l <= l_end)

                t_new[t_p++] = num[l++];

            while (cen <= r)

                t_new[t_p++] = num[cen++];

            for (d = 0; d < n_elem; d++)

            {

                num[r] = t_new[r];

                r--;

            }

        }

        static public void sort(int[] num, int l, int r)

        {

            int cen;

            if (r > l)

            {

                cen = (r + l) / 2;

                sort(num, l, cen);

                sort(num, (cen + 1), r);

                merge(num, l, (cen + 1), r);

            }

        }
        static void PrintMergeSort()
        {

         int[] num = { 10,17,20 };

        int len_new = 3;

        Console.WriteLine("New Sorted numbers are :");

            sort(num, 0, len_new - 1);

            for (int d = 0; d< 3; d++)

                Console.WriteLine(num[d]);

            Console.Read();
         }
        static void Main(string[] args)
        {
            Task t1 = new Task(PrintMergeSort);
            t1.Start();
            
            Console.ReadLine();
        }


    }

}
