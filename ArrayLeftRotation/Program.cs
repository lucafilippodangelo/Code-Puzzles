using System;

namespace ArrayLeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ldArray = { 1, 2, 3, 4, 5 };
            arrayLeftRotation(ldArray, 2);
            Console.ReadLine();
        }

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
    }
}
