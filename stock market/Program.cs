using System;
using System.Collections.Generic;

namespace stock_market
{
    class Program
    {
        static void Main(string[] args)
        {
            //intallizing variables
            int end_game = 0, end_turn = 0, x, choice;
            Market sm = new Market();//making an instance of the class market to use for the game
            Console.WriteLine("Welcome to Stock Market the board game!\n");
            Console.WriteLine("How many players are going to play?\n"); // finding out the number of players
            int size = Convert.ToInt32(Console.ReadLine());
            Player[] players = new Player[size];//create an array of players with the size=# of players
            //looping throught the array to create each induivual player, setting their job and color etc
            for (x = 0; x < size; x++)
            {
                players[x] = new Player();
            }
            //Console.WriteLine("Ok, so there is {0} players.\n", size); //testing to see how many players there are
            x = 0;
            //starting the game, end_game var is to tell when the game is over
            while (end_game != 1)
            {
                //Start of each players turn, end_turn is to tell when each players turn is over
                if(end_turn != 1)
                {
                    //The options during a players turn, which is stored into choice
                    Console.WriteLine("It's {0},{1} turn!\n" +
                        "Here are your options: \n" +
                        "1)Roll\n" +
                        "2)Change Jobs/Quit Working - only allowed before rolling\n" +
                        "3)Sell Stock - ONLY ALLOWED BEFORE ROLLING\n" +
                        "4)Show the Stock Market - only allowed before rolling\n" +
                        "5)Show My Stock - only allowed before rolling\n", players[x].name,players[x].color_name);
                    choice = Convert.ToInt32(Console.ReadLine());
                    //the switch will handle each option that a player can choose during a turn
                    switch (choice)
                    {
                        case 1:
                            //roll
                            players[x].Roll();
                            //once a players rolls, the player does what the square requires if not working and then their turn is done(end_turn is set to 1)
                            if (players[x].work == -1)//if not working do what the square requires
                            {
                                //show the player the square they landed on
                                players[x].position.show(players[x]);
                                //check if the player gets a div
                                if (players[x].stocks[players[x].position.stock_name_num] > 0)
                                {
                                    // ( div           *    the amount of stock the player has )
                                    players[x].money = players[x].money + (players[x].position.div * players[x].stocks[players[x].position.stock_name_num]);
                                    Console.WriteLine("Player: {0},{1} you got %d in dividends\n", players[x].name, players[x].color_name);
                                    players[x].Show();
                                }
                                //give the player the option to buy
                                // if there is no stock meeting
                                if (players[x].position.meeting == -1)
                                {
                                    //ask if the player wants to buy stock
                                    int choice_buy = 0;
                                    while (choice_buy == 0)
                                    {
                                        //show the player the current stock market price for the stock
                                        Console.WriteLine("The current price of {0} is %d\n", players[x].position.title, sm.Find(players[x].position_num));
                                        //then ask if they wannt to buy
                                        Console.WriteLine("Do you want to buy shares of {0}? Yes(1) or No(2)\n", players[x].position.title);
                                        choice_buy = Convert.ToInt32(Console.ReadLine());
                                        switch (choice_buy)
                                        {
                                            // they want to buy stock, need to now ask how many shares
                                            case 1:
                                                players[x].Buy_stock(sm);
                                                break;
                                            case 2:
                                                Console.WriteLine("You choose to not buy any.\n");
                                                break;
                                            default:
                                                Console.WriteLine("Entered wrong number yes(1) or no(2)\n");
                                                choice_buy = 0;
                                                break;
                                        }
                                    }
                                }
                                //if there is a stock meeting
                                else if (players[x].position.meeting == 1)
                                {
                                    //ask if they want to buy stock, while telling them that they can only buy one stock since it is a stock meeting square
                                    int choice_buy = 0;
                                    while (choice_buy == 0)
                                    {
                                        //show the player their stats
                                        players[x].Show();
                                        //show the player the current stock market price for the stock
                                        Console.WriteLine("The current price of {0} is %d\n", players[x].position.title, sm.Find(players[x].position_num));
                                        //ask the player if the want to buy a share
                                        Console.WriteLine("The square you landed on is a stockholders meeting, therefore there is a purchase limit of one share." +
                                        " Do you want to buy {0} stock? Yes(1) or No(2)\n", players[x].position.title);
                                        choice_buy = Convert.ToInt32(Console.ReadLine());
                                        switch (choice_buy)
                                        {
                                            //buy one stock
                                            case 1:
                                                players[x].Buy_stock(sm);
                                                break;
                                            // not buying anything
                                            case 2:
                                                Console.WriteLine("You choose to not buy any.\n");
                                                break;
                                            //error message
                                            default:
                                                Console.WriteLine("Entered wrong number yes(1) or no(2)\n");
                                                choice_buy = 0;
                                                break;
                                        }
                                    }
                                    //ask if the player wants to go inot the stockholders meeting
                                    choice_buy = 0;
                                    while (choice_buy == 0)
                                    {
                                        Console.WriteLine("Do you want to go into the stockholders meeting? Yes(1) or No(2)\n");
                                        choice_buy = Convert.ToInt32(Console.ReadLine());
                                        switch (choice_buy)
                                        {
                                            case 1:
                                                //check if the player can go into the meeting,
                                                //check if they have at least one stock of the stock meeting they are wanting to go into
                                                if (players[x].stocks[players[x].position.stock_name_num - 1] > 0)
                                                {
                                                    //go into the meeting 
                                                    players[x].meeting = 1;
                                                }
                                                else
                                                {
                                                    //can't go into the meeting
                                                    players[x].meeting = 2;
                                                    Console.WriteLine("Sorry, you do not have at least one stock which is required to be able to go into the stockholders meeting.\n");
                                                    players[x].Show();
                                                }
                                                break;
                                            case 2:
                                                //not going into the meeting
                                                players[x].meeting = 2;
                                                Console.WriteLine("You are not going into the stockholders meeting.\n");
                                                break;
                                            default:
                                                //error message
                                                Console.WriteLine("Entered wrong number yes(1) or no(2)\n");
                                                choice_buy = 0;
                                                break;
                                        }
                                    }
                                }
                            }
                            end_turn = 1;
                            break;
                        case 2:
                            //Change Jobs or Quit Job, players can do this before rolling only
                            players[x].Change_job();
                            break;
                        case 3:
                            //Sell Stock, a player can only do this before rolling
                            players[x].Sell_stock(sm); 
                            break;
                        case 4:
                            //Show Stock Market
                            sm.Show();
                            break;
                        case 5:
                            //Show players hand
                            players[x].Show();
                            break;
                        default:
                            //Error message
                            Console.WriteLine("Enter wrong number or invalid character, try again\n");
                            break;
                    }
                    if (end_turn == 1)
                    { 
                        x++; // inc x var to go to the next player
                        end_turn = 0; // reset end_turn var for the next player
                        if(x >= size) // check to make sure we don't go out of bounds when accessing the player array
                                      // ex: if there is only 2 players or size 2 the program should do player 0 turn(x=0),
                                      // then player 1 turn(x=1), when x=2 it should go back to player 0 turn(x=0).
                                      // And it would be one round of turns done.
                        {
                            x = 0;
                        }
                        Console.WriteLine("\n");//idk if we need this?, at the end of the turn make a new line to separate the players turns
                    }
                }
            }
        }
    }
}
