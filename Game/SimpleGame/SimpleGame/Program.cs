using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Numerics;
using System.Threading;

namespace SimpleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Random randomizer = new Random();
            int upperObstacleY = randomizer.Next(1, 16);
            int points = 0;
            int hp = 3;
            int firstObstacleX = 30;
            int firstUpperObstacleY = randomizer.Next(1, 16);
            int firstLowerObstacleY = firstUpperObstacleY + 4;
            int secondObstacleX = 60;
            int secondUpperObstacleY = randomizer.Next(1, 16);
            int secondLowerObstacleY = secondUpperObstacleY + 4;
            int thirdObstacleX = 90;
            int thirdUpperObstacleY = randomizer.Next(1, 16);
            int thirdLowerObstacleY = thirdUpperObstacleY + 4;
            int fourthObstacleX = 120;
            int fourthUpperObstacleY = randomizer.Next(1, 16);
            int fourthLowerObstacleY = fourthUpperObstacleY + 4;
            int myObjectX = 9;
            int myObjectY = 10;
            string myObject = ">";

            do
            {
                Console.Clear();

                for (int y = 0; y < 20; y++)
                {
                    for (int x = 0; x < 120; x++)
                    {
                        if (y == 0)
                            Console.Write("▓");
                        else if (y == myObjectY && x == myObjectX)
                            Console.Write(myObject);
                        else if (y > 0 && y <= firstUpperObstacleY && x == firstObstacleX || y > 0 && y <= secondUpperObstacleY && x == secondObstacleX || y > 0 && y <= thirdUpperObstacleY && x == thirdObstacleX || y > 0 && y <= fourthUpperObstacleY && x == fourthObstacleX)
                            Console.Write("░");
                        else if (y < 20 && y >= firstLowerObstacleY && x == firstObstacleX || y < 20 && y >= secondLowerObstacleY && x == secondObstacleX || y < 20 && y >= thirdLowerObstacleY && x == thirdObstacleX || y < 20 && y >= fourthLowerObstacleY && x == fourthObstacleX)
                            Console.Write("░");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                for (int border = 0; border < 120; border++)
                    Console.Write("▓");
                Console.WriteLine();

                Console.Write("Score: ");
                Console.WriteLine(points);
                Console.Write("Health: ");
                Console.WriteLine(hp);


                if (firstObstacleX == 0)
                {
                    firstObstacleX = 120;
                    int randomObstacleY = randomizer.Next(1, 16);
                    firstUpperObstacleY = randomObstacleY;
                    firstLowerObstacleY = firstUpperObstacleY + 4;
                }
                else if (secondObstacleX == 0)
                {
                    secondObstacleX = 120;
                    int randomObstacleY = randomizer.Next(1, 16);
                    secondUpperObstacleY = randomObstacleY;
                    secondLowerObstacleY = secondUpperObstacleY + 4;
                }
                else if (thirdObstacleX == 0)
                {
                    thirdObstacleX = 120;
                    int randomObstacleY = randomizer.Next(1, 16);
                    thirdUpperObstacleY = randomObstacleY;
                    thirdLowerObstacleY = thirdUpperObstacleY + 4;
                }
                else if (fourthObstacleX == 0)
                {
                    fourthObstacleX = 120;
                    int randomObstacleY = randomizer.Next(1, 16);
                    fourthUpperObstacleY = randomObstacleY;
                    fourthLowerObstacleY = fourthUpperObstacleY + 4;
                }

                firstObstacleX = firstObstacleX - 2;
                secondObstacleX = secondObstacleX - 2;
                thirdObstacleX = thirdObstacleX - 2;
                fourthObstacleX = fourthObstacleX - 2;

                if (myObjectY <= firstUpperObstacleY && myObjectX + 1 == firstObstacleX || myObjectY >= firstLowerObstacleY && myObjectX + 1 == firstObstacleX)
                    hp--;
                else if (myObjectY <= secondUpperObstacleY && myObjectX + 1 == secondObstacleX || myObjectY >= secondLowerObstacleY && myObjectX + 1 == secondObstacleX)
                    hp--;
                else if (myObjectY <= thirdUpperObstacleY && myObjectX + 1 == thirdObstacleX || myObjectY >= thirdLowerObstacleY && myObjectX + 1 == thirdObstacleX)
                    hp--;
                else if (myObjectY <= fourthUpperObstacleY && myObjectX + 1 == fourthObstacleX || myObjectY >= fourthLowerObstacleY && myObjectX + 1 == fourthObstacleX)
                    hp--;
                else if (myObjectX + 1 == firstObstacleX || myObjectX + 1 == secondObstacleX || myObjectX + 1 == thirdObstacleX || myObjectX + 1 == fourthObstacleX)
                    points++;

                Thread.Sleep(200);

                char myMovement = Console.ReadKey().KeyChar;
                if (myMovement == 'W' && myObjectY != 1 || myMovement == 'w' && myObjectY != 1)
                    myObjectY--;
                else if (myMovement == 'S' && myObjectY != 19 || myMovement == 's' && myObjectY != 19)
                    myObjectY++;

            } while (hp > 0);
            timer.Stop();
            Console.WriteLine("You lost...");
        }
    }
}
