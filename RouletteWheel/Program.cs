using System;

namespace RouletteWheel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Roulette! Press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Place your bets and press enter when you are ready!");
            Console.ReadLine();
            Console.WriteLine("And the winner is..." +
                "\n(hit enter to see results)");
            Console.ReadLine();
            doWork();
        }


        public static void doWork()
        {

            //--------------------------------------------------------------------------
            //creating the roulette wheel. binNum[37] will represent the "00" on the wheel
            //--------------------------------------------------------------------------

            int[] binNum = new int[38];
            for (int i = 0; i < 38; i++)
            {
                binNum[i] = i;
            }

            char[] binColor = { 'g', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'b',
                                'r', 'b', 'r', 'b', 'r', 'b', 'r', 'r', 'b', 'r', 'b', 'r',
                                'b', 'r', 'b', 'r', 'b', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'g' };

            
            Random rand = new Random();
            int randomIndex = rand.Next(0, 37);

            //--------------------------------------------------------------------------
            //          Bin number and color winner
            //--------------------------------------------------------------------------

            int winningNum = binNum[randomIndex];
            if (winningNum == 37)
            {
                Console.WriteLine("The winning number is 00!");
            }
            else
            {
                Console.WriteLine($"The winning number is {winningNum}!");
            }


            char winningColor = binColor[randomIndex];
            if (winningColor == 'b')
            {
                Console.WriteLine("The winning color is BLACK!");
            }
            else if (winningColor == 'r')
            {
                Console.WriteLine("The winning color is RED!");
            }
            else
            {
                Console.WriteLine("Neither red or black won.");
            }

            //--------------------------------------------------------------------------
            //             Even/odd winner
            //--------------------------------------------------------------------------

            int eoRemainder = winningNum % 2;

            if (winningNum == 0 || winningNum == 37)
            {
                Console.WriteLine("There is no even/odd winner.");
            }
            else if (eoRemainder == 0)
            {
                Console.WriteLine("The even/odd winner is EVEN!");
            }
            else
            {
                Console.WriteLine("The even/odd winner is ODD!");
            }

            //--------------------------------------------------------------------------
            //             Low/high winner
            //--------------------------------------------------------------------------

            if (winningNum >= 1 && winningNum <= 18)
            {
                Console.WriteLine("The low/high winner is LOW!");
            }
            else if (winningNum >= 19 && winningNum <= 36)
            {
                Console.WriteLine("The low/high winner is HIGH!");
            }
            else
            {
                Console.WriteLine("There is no low/high winner.");
            }

            //--------------------------------------------------------------------------
            //             Dozens winner
            //--------------------------------------------------------------------------

            if (winningNum >= 1 && winningNum <= 12)
            {
                Console.WriteLine("The dozens winner is the 1st 12!");
            }
            else if (winningNum >= 13 && winningNum <= 24)
            {
                Console.WriteLine("The dozens winner is the 2nd 12!");
            }
            else if (winningNum >= 25 && winningNum <= 37)
            {
                Console.WriteLine("The dozens winner is the 3rd 12!");
            }
            else
            {
                Console.WriteLine("There is no low/high winner.");
            }

            //--------------------------------------------------------------------------
            //             Columns winner
            //--------------------------------------------------------------------------






            //--------------------------------------------------------------------------
            //             Streets winner
            //--------------------------------------------------------------------------

            double streetQuotient = (double)winningNum / 3;

            if (winningNum == 0 || winningNum == 37)
            {
                Console.WriteLine("There is no street winner.");
            }
            else if (streetQuotient <= 1)
            {
                Console.WriteLine("The street winner is ROW 1!");
            }
            else if (streetQuotient <= 2)
            {
                Console.WriteLine("The street winner is ROW 2!");
            }
            else if (streetQuotient <= 3)
            {
                Console.WriteLine("The street winner is ROW 3!");
            }
            else if (streetQuotient <= 4)
            {
                Console.WriteLine("The street winner is ROW 4!");
            }
            else if (streetQuotient <= 5)
            {
                Console.WriteLine("The street winner is ROW 5!");
            }
            else if (streetQuotient <= 6)
            {
                Console.WriteLine("The street winner is ROW 6!");
            }
            else if (streetQuotient <= 7)
            {
                Console.WriteLine("The street winner is ROW 7!");
            }
            else if (streetQuotient <= 8)
            {
                Console.WriteLine("The street winner is ROW 8!");
            }
            else if (streetQuotient <= 9)
            {
                Console.WriteLine("The street winner is ROW 9!");
            }
            else if (streetQuotient <= 10)
            {
                Console.WriteLine("The street winner is ROW 10!");
            }
            else if (streetQuotient <= 11)
            {
                Console.WriteLine("The street winner is ROW 11!");
            }
            else
            {
                Console.WriteLine("The street winner is ROW 12!");
            }

            //--------------------------------------------------------------------------
            //             Double row winner
            //--------------------------------------------------------------------------

            double drQuotient = (double)winningNum / 3;

            if (winningNum == 0 || winningNum == 37)
            {
                Console.WriteLine("There is no double row winner.");
            }
            else if (drQuotient <= 1)
            {
                Console.WriteLine("The double row winner is ROWS 1 & 2!");
            }
            else if (drQuotient <= 2)
            {
                Console.WriteLine("The double row winners are ROWS 1 & 2 and ROWS 2 & 3!");
            }
            else if (drQuotient <= 3)
            {
                Console.WriteLine("The double row winners are ROWS 2 & 3 and ROWS 3 & 4!");
            }
            else if (drQuotient <= 4)
            {
                Console.WriteLine("The double row winners are ROWS 3 & 4 and ROWS 4 & 5!");
            }
            else if (drQuotient <= 5)
            {
                Console.WriteLine("The double row winners are ROWS 4 & 5 and ROWS 5 & 6!");
            }
            else if (drQuotient <= 6)
            {
                Console.WriteLine("The double row winners are ROWS 5 & 6 and ROWS 6 & 7!");
            }
            else if (drQuotient <= 7)
            {
                Console.WriteLine("The double row winners are ROWS 6 & 7 and ROWS 7 & 8!");
            }
            else if (drQuotient <= 8)
            {
                Console.WriteLine("The double row winners are ROWS 7 & 8 and ROWS 8 & 9!");
            }
            else if (drQuotient <= 9)
            {
                Console.WriteLine("The double row winners are ROWS 8 & 9 and ROWS 9 & 10!");
            }
            else if (drQuotient <= 10)
            {
                Console.WriteLine("The double row winners are ROWS 9 & 10 and ROWS 10 & 11!");
            }
            else if (drQuotient <= 11)
            {
                Console.WriteLine("The double row winners are ROWS 10 & 11 and ROWS 11 & 12!");
            }
            else
            {
                Console.WriteLine("The double row winner is ROWS 11 & 12!");
            }
        }
    }
}
