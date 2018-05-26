using System;

namespace IslandCount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             LD EXERCISE "Count Number of Islands"
                 Given a 2d grid map of '1's (land) and '0's (water), find the biggest one.
                 An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.
             */

            islandsQueries();
            Console.ReadLine();

         }//main

        private static void islandsQueries() {

            //LD test 3 islands

            int[,] ldArray;
            ldArray = Utilities.createArray4x5with3Islands();
            Utilities.biggestIsland = 0;
            Utilities.countNumOfIslandsAndFindBiggest(ldArray);


            //LD test 1 island
            int[,] ldArray002;
            ldArray002 = Utilities.createArray4x5with1Island();
            Utilities.biggestIsland = 0;
            Utilities.countNumOfIslandsAndFindBiggest(ldArray002);

            //LD test 1 island
            int[,] ldArray003;
            ldArray003 = Utilities.createArray5x5with6Islands();
            Utilities.biggestIsland = 0;
            Utilities.countNumOfIslandsAndFindBiggest(ldArray003);

        }


    }//program
}//namespace

