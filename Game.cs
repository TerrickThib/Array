using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Game
    {
        public void Run()
        {
            
            //Prints all numbers in a Array
            int[] arr = new int[] { 1, 12, 18, 58, 69, 72 };
            PrintSmallLarge(arr);
            PrintArray(arr);
        }
        //Varibles
        int input = 0;
        
        void PrintArray(int[]arr)
        {
            for (int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        void PrintSmallLarge(int[]arr)
        {
            //VAribles for the smallest and largest numbers
            int largest = arr[0];
            int smallest = arr[0];
            //This will cycle through the array by one.It also finds the Largest and smallest numbers
            for (int i = 0; i<arr.Length; i++)
            {
                if(arr[i]>largest)
                {
                    largest = arr[i];
                }

                else if(arr[i]<smallest)
                {
                    smallest = arr[i];
                }
            }
            Console.WriteLine("Largest; " +largest);
            Console.WriteLine("Smallest: " +smallest);
        }
    }
}
