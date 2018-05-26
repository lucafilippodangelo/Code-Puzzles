using System;

namespace IslandCount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             LD EXERCISE "Count Number of Islands"
                 Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. 
                 An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.
             SOLUTION "use visited array to store all the visited cell and use queue to expand islands"
             */

            islandsQueries();
            Console.ReadLine();

         }//main

        private static void islandsQueries() {

            //LD test 3 islands
            int[,] ldArray;
            ldArray = Utilities.createArray4x5with3Islands(); 
            Utilities.countNumOfIslandsAndFindBiggest(ldArray);


            //LD test 1 island
            int[,] ldArray002;
            ldArray002 = Utilities.createArray4x5with1Island();
            Utilities.countNumOfIslandsAndFindBiggest(ldArray002);


        }

    }//program
}//namespace

