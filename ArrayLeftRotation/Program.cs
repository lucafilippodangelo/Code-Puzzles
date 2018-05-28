using System;

namespace ArrayLeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //LD test approach one
            int[] ldArray = { 1, 2, 3, 4, 5 };
            arrayLeftRotation(ldArray, 2);
            

            //LD test approach two
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            leftRotate(arr, 2, 7);
            printArray(arr, 7);

            Console.ReadLine();
        }

        #region Approach ONE- rotate one to one

        private static void arrayLeftRotation(int[] anArray, int d)
        {
            /*
             * https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
            //LD strategy 
            - for each rotation
              - take the last alement apart
              - move all the elements from "last-1" to "last"
                - do that decreasing until position 0
              - insert element apart in position 0
            */
            int itemToMove;
            int ldArrayLenght = anArray.Length;

            while (d > 0)
            {
                itemToMove = anArray[0];
                for (int ii = 1; ii <= ldArrayLenght -1; ii++)
                {
                    anArray[ii - 1] = anArray[ii];
                }
                anArray[ldArrayLenght - 1] = itemToMove;
                d--;
            }

            //LD OPPOSITE DIRECTION
            //while (d>0)
            //{
            //    itemToMove = anArray[ldArrayLenght - 1];
            //    for (int ii = ldArrayLenght; ii >= 2; ii--)
            //    {
            //        anArray[ii -1] = anArray[ii-2];
            //    }
            //    anArray[0] = itemToMove;
            //    d--;
            //}

            foreach (int i in anArray)
            {
                System.Console.Write("{0} ", i);
            }
        }

        #endregion

        #region Approach TWO(more performant) - divide the array in different sets before to rotate

        /*
          Instead of moving one by one, divide the array in different sets
          where number of sets is equal to GCD of n and d and move the elements within sets.
          If GCD is 1 as is for the above example array (n = 7 and d =2), then elements will be 
          moved within one set only, we just start with temp = arr[0] and keep moving arr[I+d] 
          to arr[I] and finally store temp at the right place.

          EXAMPLE - n =12 and d = 3. GCD is 3 and:
          - 1 2 3 4 5 6 7 8 9 10 11 12 (input)
          - 4 2 3 7 5 6 10 8 9 1 11 12 (first step)
          - 4 5 3 7 8 6 10 11 9 1 2 12 (second step)
          - 4 5 6 7 8 9 10 11 12 1 2 3 (thirth step)

         */

        private static void printArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
        }

        //LD determine how big has to be each sub array
        private static int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return gcd(b, a % b);
        }

        static void leftRotate(int[] arr, int d, int n) //array, num. of rotations, array size
        {
            int i, j, k, temp;
            for (i = 0; i < gcd(d, n); i++)
            {
                /* move i-th values of blocks */
                temp = arr[i];
                j = i;
                while (true)
                {
                    k = j + d;
                    if (k >= n)
                        k = k - n;
                    if (k == i)
                        break;
                    arr[j] = arr[k];
                    j = k;
                }
                arr[j] = temp;
            }
        }

        #endregion

    }
}
