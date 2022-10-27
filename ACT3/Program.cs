using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ACT3
{
    class Program
    {
        //array to be searched
        int[] arr = new int[20];
        // number of element in the array
        int n;
        //get the number of element to strore in the array
        int i;


        public void input()
        {
            while (true)
            {
                Console.Write("enter the number of element in the array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("/nArray should have minimum 1 and maximum 20 element. \n");
            }
            //accept array element
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Enter Array Element ");
            Console.WriteLine("---------------------");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = int.Parse(s1);

            }
        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                //accept the number to be search
                Console.Write("\nEnter the element you want to search");
                int item = Convert.ToInt32(Console.ReadLine());

                //apply binary search 
                int lowerbound = 0;
                int upperbounnd = 0;

                //obtain the index of the middle element
                int mid = (lowerbound + upperbounnd) / 2;
                int ctr = 1;

                //loop to search for the element in the array
                while ((item != arr[mid]) && (ctr <= upperbounnd))
                {
                    if (item == arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbounnd = mid - 1;

                    mid = (lowerbound + upperbounnd) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position" + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "not found in the array\n");
                Console.WriteLine("\nNumberr of comparasion : " ctr);

                Console.WriteLine("\nContinue search (y/n): ");
                ch = char.Parse(Console.ReadLine().ToUpper();

            } while ((ch == 'y'));
        }
    }
}
