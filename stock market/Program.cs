using System;
using System.Collections.Generic;

namespace stock_market
{
    class Program
    {
        static void Main()
        {
            //intallizing variables
            int end_game = 0, x, size, total, working;
            Market sm = new Market();//making an instance of the class market to use for the game
            Console.WriteLine("############################################\n");
            Console.WriteLine("#                                          #\n");
            Console.WriteLine("# Welcome to Stock Market the board game!  #\n");
            // finding out the number of players
            Console.WriteLine("How many players are going to play?\n"); 
            size = Convert.ToInt32(Console.ReadLine());
            working = size;
            //create an array of players with the size=# of players
            Player[] players = new Player[size];
            //looping throught the array to create each induivual player, setting their job and color etc
            for (x = 0; x < size; x++)
            {
                players[x] = new Player();
            }
            x = 0;
            //starting the game, end_game var is to tell when the game is over
            while (end_game == 0)
            {
                total = players[x].Total(sm);
                if (total >= 100000)
                {
                    Console.WriteLine("Player: {0}, {1}, you have just won Stock Market Board Game!!!!!!!\n" +
                        "Ending with a total of {2}!\n", players[x].Name, players[x].ColorName, total);
                    end_game = 1;
                }
                else
                {
                    players[x].Turn(sm, players, size, ref working);
                    x++; // inc x var to go to the next player
                    if (x >= size) // check to make sure we don't go out of bounds when accessing the player array
                                   // ex: if there is only 2 players or size 2 the program should do player 0 turn(x=0),
                                   // then player 1 turn(x=1), when x=2 it should go back to player 0 turn(x=0).
                                   // And it would be one round of turns done.
                    {
                        x = 0;
                    }
                    Console.WriteLine("\n");//at the end of the turn make a new line to separate the players turns
                }
            }
            //show every players stats
            for(x=0; x<size; x++)
            {
                players[x].Ending(sm);
            }
            sm.Show();
            Console.WriteLine("Thank you for playing!\n");
        }
    }
}
