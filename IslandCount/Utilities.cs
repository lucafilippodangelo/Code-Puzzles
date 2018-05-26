using System;
using System.Collections.Generic;
using System.Text;

namespace IslandCount
{
    public static class Utilities
    {
        static bool[,] visited;
        public static int biggestIsland;
        public static int tempBiggestIsland;

        #region Multimensional array creation
        
        public static int[,] createArray5x5with6Islands()
        {
            //LD create
            int[,] anArray = new int[5, 5] {
                { 1,1,0,0,0 },
                { 0,1,0,0,1 },
                { 1,0,0,1,1 },
                { 0,0,0,0,0 },
                { 1,0,1,0,1 } };

            consolePrintBidimensionalArray(anArray, 5);
            //LD return
            return anArray;
        }

        public static int[,] createArray4x5with3Islands()
        {
            //LD create
            int[,] anArray = new int[4, 5] {
                { 1,1,0,0,0 },
                { 1,1,0,0,0 },
                { 0,0,1,0,0 },
                { 0,0,0,1,1 } };

            consolePrintBidimensionalArray(anArray, 5);
            //LD return
            return anArray;
        }

        public static int[,] createArray4x5with1Island()
        {
            //LD create
            int[,] anArray = new int[4, 5] {
                { 1,1,1,1,0 },
                { 1,1,0,1,0 },
                { 1,1,0,0,0 },
                { 0,0,0,0,0 } };

            consolePrintBidimensionalArray(anArray, 5);
            //LD return
            return anArray;
        }

        #endregion

        #region output at console
        
        private static void consolePrintBidimensionalArray(int [,] anArray, int colNumber)
        {
            //LD console print
            int rowSplit = 0;
            foreach (int i in anArray)
            {
                if (rowSplit % colNumber == 0) { Console.WriteLine(); }
                System.Console.Write("{0} ", i);
                rowSplit++;
            }
        }

        #endregion

        public static int countNumOfIslands(int[,] ldArray)
        {
            int count = 0;

            var rows = ldArray.GetLength(0);
            var columns = ldArray.GetLength(1);

            visited = new bool[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (ldArray[r, c] == 1 && !visited[r, c]) //if specific position is 1 and not visited yet
                    {
                        //LD discover recursevely and mark as visited all the closer "1" 
                        exploreAndMarkTheAllLandsCloser(ldArray, r, c);
                        count++;
                    }
                }
            }

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine("Number of Islands: " + count);

            return count;
        }

        public static int countNumOfIslandsAndFindBiggest(int[,] ldArray)
        {
            int count = 0;

            var rows = ldArray.GetLength(0);
            var columns = ldArray.GetLength(1);

            visited = new bool[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (ldArray[r, c] == 1 && !visited[r, c]) //if specific position is 1 and not visited yet
                    {
                        tempBiggestIsland = 0;
                        //LD discover recursevely and mark as visited all the closer "1" 
                        exploreAndMarkTheAllLandsCloser(ldArray, r, c);
                        
                        if (tempBiggestIsland > biggestIsland)
                            biggestIsland = tempBiggestIsland;
                        count++;
                    }
                }
            }

            Console.WriteLine();  Console.WriteLine("Number of Islands: " + count + " of which the biggest is large: " + biggestIsland);
            return count;
        }

        private static void exploreAndMarkTheAllLandsCloser(int[,] ldArray, int r, int c)
        {
            //LD return if:
            if (r < 0 || r >= ldArray.GetLength(0)) return;// "r" index bigger or smaller than grid row dimension
            if (c < 0 || c >= ldArray.GetLength(1)) return;// "c" index bigger or smaller than grid column dimension
            if (visited[r, c]) return;// the node is already visited
            if (ldArray[r, c] != 1) return;// the node is zero

            visited[r, c] = true;//mark the node as visited
            tempBiggestIsland++;

            //LD visit recursively:
            exploreAndMarkTheAllLandsCloser(ldArray, r - 1, c); // above
            exploreAndMarkTheAllLandsCloser(ldArray, r + 1, c); // below
            exploreAndMarkTheAllLandsCloser(ldArray, r, c - 1); // left
            exploreAndMarkTheAllLandsCloser(ldArray, r, c + 1); // right
        }
    }
}
