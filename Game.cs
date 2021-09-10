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
            int[] arr = new int[6] { 1, 12, 18, 58, 69, 72 };
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
        void PrintSmallLarge()
        {

        }
    }
}
