
using System;

namespace SnakesAndLaders
{
    class Program
    {
        static void Main(string[] args)
        {


            var game = new Game(100);
            game.Initialize();


            //game.SetLadder(8, 52);
            //game.SetLadder(6, 80);
            //game.SetLadder(26, 42);
            //game.SetLadder(2, 72);

            //game.SetSnake(51, 19);
            //game.SetSnake(39, 11);
            //game.SetSnake(37, 29);
            //game.SetSnake(81, 3);
            //game.SetSnake(59, 5);
            //game.SetSnake(79, 23);
            //game.SetSnake(53, 7);
            //game.SetSnake(43, 33);
            //game.SetSnake(77, 21);


            //game.SetLadder(3, 54);
            //game.SetLadder(37, 100);

            //game.SetSnake(56, 33);

            //game.SetLadder(3, 57);
            //game.SetLadder(8, 100);

            //game.SetSnake(88, 44);

            //game.SetLadder(7, 98);

            //game.SetLadder(99, 1);

            //game.SetLadder(3, 5);
            //game.SetLadder(7, 8);
            //game.SetLadder(44, 56);
            //game.SetLadder(36, 54);
            //game.SetLadder(88, 91);
            //game.SetLadder(77, 83);
            //game.SetLadder(2, 4);
            //game.SetLadder(9 ,99);
            //game.SetLadder(45 ,78);
            //game.SetLadder(31 ,75);


            //game.SetSnake(10 ,6);
            //game.SetSnake(95, 90);
            //game.SetSnake(96 ,30);
            //game.SetSnake(97, 52);
            //game.SetSnake(98 ,86);

            game.SetLadder(5, 6);
            game.SetSnake(97, 95);

            game.VisitNodes();


            Console.WriteLine(game.GetSolution());
            Console.ReadLine();

            
        }
        
    }
}
