using System;
using System.Collections.Generic;
using System.Text;

namespace stock_market
{
    public class Player
    {
        public int money = 0; //how much money a player has
        public readonly string color_name; //the color of the pawn 
        public readonly string name; //the name of the player
        public int[] stocks = new int[8]; //an array of stocks for the player
        public int[] roll = new int[2]; // an array to hold the two numbers that a dice would roll
        public int work = -1; //the number that corresponds to the job a player has, prospector-1, policeman-2, doctor-3, deep sea diver-4, not working:-1
        public int pay = 0; //if working then the salary amount for the job the player has
        public int meeting = 2; // 1 means in meeting, 2 means not in meeting
        public string work_name; //the name of the work
        public Board_Square position; // the current postion of the player
        public int position_num; // the current postion num in the array
        public int stockhold_num = -2; // num to show where the player is in the stockhold, -2 not in , -1 in but haven't moved
        private readonly Board_Square[] board = new Board_Square[49];
        private readonly Start_Board Prospector = new Start_Board(1);
        private readonly Start_Board Policeman = new Start_Board(2);
        private readonly Start_Board Doctor = new Start_Board(3);
        private readonly Start_Board Deep_Sea_Diver = new Start_Board(4);
        private void Show()
        {
            Console.WriteLine("{0}, {1}, here is your stats\n", color_name, name);
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Money: {0}\n", money);
            Console.WriteLine("Work Status: {0}\n", work_name);
            Console.WriteLine("Meeting Status(1:yes 2:no): {0}\n", meeting);
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Stocks: \n");
            Console.WriteLine("        Woolwth: {0}\n", stocks[0]);
            Console.WriteLine("        Aloca: {0}\n", stocks[1]);
            Console.WriteLine("        Int Shoe: {0}\n", stocks[2]);
            Console.WriteLine("        J.I. Case: {0}\n", stocks[3]);
            Console.WriteLine("        Maytag: {0}\n", stocks[4]);
            Console.WriteLine("        Gen Mills: {0}\n", stocks[5]);
            Console.WriteLine("        A.M. Motors: {0}\n", stocks[6]);
            Console.WriteLine("        Western Pub: {0}\n", stocks[7]);
            Console.WriteLine("----------------------\n\n");
        } //check 1/21
        private void Reset()
        {
            //reset the player information
            money = 0;
            for(int x = 0; x < 8; x++)
            {
                stocks[x] = 0;
            }
            Change_job();
            position_num = 0;
        }
        public void Ending(Market sm)
        {
            //ending credits, show each players stats at the end of game
            Console.WriteLine("{0}, {1}, here is your stats\n", color_name, name);
            Console.WriteLine("--------------------------\n");
            Console.WriteLine("Money: {0}\n", money);
            Console.WriteLine("--------------------------\n");
            Console.WriteLine("Stocks: \n");
            Console.WriteLine("        Woolwth: {0} = {1}\n", stocks[0], stocks[0] * sm.Find(1));
            Console.WriteLine("        Aloca: {0} = {1}\n", stocks[1], stocks[1] * sm.Find(2));
            Console.WriteLine("        Int Shoe: {0} = {1}\n", stocks[2], stocks[2] * sm.Find(3));
            Console.WriteLine("        J.I. Case: {0} = {1}\n", stocks[3], stocks[3] * sm.Find(4));
            Console.WriteLine("        Maytag: {0} = {1}\n", stocks[4], stocks[4] * sm.Find(5));
            Console.WriteLine("        Gen Mills: {0} = {1}\n", stocks[5], stocks[5] * sm.Find(6));
            Console.WriteLine("        A.M. Motors: {0} = {1}\n", stocks[6], stocks[6] * sm.Find(7));
            Console.WriteLine("        Western Pub: {0} = {1}\n", stocks[7], stocks[7] * sm.Find(8));
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Total: {0}\n",Total(sm));
            Console.WriteLine("------------------------------\n");
        }
        private void Done_working()
        {
            work = -1;
            work_name = "None";
            pay = 0;
            int check = 0, choice;
            while (check == 0)
            {
                // 1 with woolworth next, gen mills 13 int shoe, am motors 25 western publishing, ji case 37 maytag
                Console.WriteLine("{0}: You have passed the limit for working or have decided to quit working. Pick which starting square you want.\n" +
                "1) which is by Western Publ. and AM. Motors Stockholders Meeting\n" +
                "2) which is by J.I. Case and Maytag Stockholders Meeting\n" +
                "3) which is by Aloca and Woolworth Stockholders Meeting\n" +
                "4) which is by Int. Shoe and Gen Mills Stockholders Meeting\n", color_name);
                choice = Convert.ToInt32(Console.ReadLine());
                work = -1;
                work_name = "none";
                switch (choice)
                {
                    case 1:
                        position = board[13];
                        position_num = 13;
                        check = 1;
                        break;
                    case 2:
                        position = board[1];
                        position_num = 1;
                        check = 1;
                        break;
                    case 3:
                        position = board[37];
                        position_num = 37;
                        check = 1;
                        break;
                    case 4:
                        position = board[25];
                        position_num = 25;
                        check = 1;
                        break;
                    default:
                        Console.WriteLine("Enter wrong number\n");
                        break;
                }
            }
            Console.WriteLine("{0} is moving out of the work phase of the game and is now on the board!\n", color_name);
        }
        public int Total(Market sm)
        {
            int sum = money;
            for(int x=0; x<8; x++)
            {
                //sum = sum + ( # of shares * current price of stock)
                sum += (stocks[x] * sm.Find(x + 1));
            }
            return sum;
        }
        private void Roll() 
        {
            // creates an array containing two random numbers(1-6) to act as our dice. Displays the two numbers to the player. Then calls player_move to move the player around the board.
            var rand = new Random();
            roll[0] = rand.Next(1,6);
            roll[1] = rand.Next(1,6);
            //if not in a stockholders meeting, roll both
            if (meeting == 2)
            {
                Console.WriteLine("{0}, {1} rolled {2} {3}.\n", name, color_name, roll[0], roll[1]);
            }
            //if in a stockholders meeting, roll 1
            else if(meeting == 1)
            {
                Console.WriteLine("{0}, {1} rolled {2}.\n", name, color_name, roll[0]);
                roll[1] = 0;
            }
        } //check 1/21
        private void Pay(int size, Player[] p, int work)
        {
            //set pay to the right amount of money based on which work was sent to this function.
            //Use this function when some has rolled and you need to pay every player who is in a certian occupation.
            switch (work)
            {
                case 0:
                    Console.WriteLine("Nobody who is working got paid this round.\n");
                    break;
                case 1:  //Prospector
                    pay = 400;
                    Console.WriteLine("Players working as prospectors got paid\n");
                    break;
                case 2: //Policeman
                    pay = 100;
                    Console.WriteLine("Players working as policemans got paid\n");
                    break;
                case 3: // Doctor
                    pay = 200;
                    Console.WriteLine("Players working as Doctors got paid\n");
                    break;
                case 4: // Deep Sea Diver
                    pay = 300;
                    Console.WriteLine("Players working as Deep Sea Divers got paid\n");
                    break;
            }
            // for loop the number of players in the game, add the pay to their money if they are in the right occupation.
            // Display whoever got pay
            for (int x = 0; x < size; x++)
            {
                if (p[x].work == work)
                {
                    p[x].money = p[x].money + pay;
                    Console.WriteLine("{0}, {1} got paid this amount {2}.\n",p[x].name,p[x].color_name , pay);
                }
            }
        }//check 1/21
        private void Change_job()
        { 
            //give the options on what the player can switch to, then displays the changed information.
            int choice = 0;
            while (choice == 0)
            {
                Console.WriteLine("What job do you want?\n " +
                "Options:\n" +
                "1-Prospector\n" +
                "2-Policeman\n" +
                "3-Doctor\n" +
                "4-Deep Sea Diver\n " +
                "5-Description of the jobs\n" +
                "6-Quit Working\n");
                 choice = Convert.ToInt32(Console.ReadLine());
                 switch (choice)
                 {
                    case 1:
                        work = 1;
                        work_name = "Prospector";
                        choice = 7;
                        break;
                    case 2:
                        work = 2;
                        work_name = "Policeman";
                        choice = 7;
                        break;
                    case 3:
                        work = 3;
                        work_name = "Doctor";
                        choice = 7;
                        break;
                    case 4:
                        work = 4;
                        work_name = "Deep Sea Diver";
                        choice = 7;
                        break;
                    case 5:
                        Prospector.Show();
                        Policeman.Show();
                        Doctor.Show();
                        Deep_Sea_Diver.Show();
                        choice = 0;
                        break;
                    case 6:
                        Done_working();
                        choice = 6;
                        break;
                    default:
                        Console.WriteLine("Enter a wrong number.\n");
                        choice = 0;
                        break;
                 }
            }
        } 
        private int Check_roll()
        {
            // for each job it checks if the two random numbers meet the job requirements, returns the number corresponding to job

            //prospector
            if ((roll[0] + roll[1]) == 2 || (roll[0] + roll[1]) == 12)
            {
                //players working as prospector get paid
                return 1;
            }
            //policeman
            else if ((roll[0] + roll[1]) == 5 || (roll[0] + roll[1]) == 9)
            {
                //players working as policeman get paid
                return 2;
            }
            //Doctor 
            else if ((roll[0] + roll[1]) == 4 || (roll[0] + roll[1]) == 10)
            {
                //players working as a Doctor
                return 3;
            }
            //Deep Sea Diver
            else if ((roll[0] + roll[1]) == 3 || (roll[0] + roll[1]) == 11)
            {
                //players working as a Deep Sea Diver
                return 4;
            }
            else
            {
                return 0;
            }
        } //return the num for the job that is getting paid. check 1/21
        private void Move(int num)
        {
            while (num > 0)
            {
                //going to the left
                if (position.movement == 1)
                {
                    position_num--;
                }
                //going to the right
                else if (position.movement == 2)
                {
                    position_num++;
                }
                if (position_num > 48)
                {
                    position_num = 1;
                }
                else if (position_num < 1)
                {
                    position_num = 48;
                }
                num--;
            }
            position = board[position_num];
        }
        private void Move()
        {
            //if the player is not working
            if(work == -1)
            {
                //check if the player is in a stockholders meeting
                if (meeting == 1)
                {
                    int num = roll[0];
                    while (num > 0)
                    {
                        stockhold_num++;
                        num--;
                        //if the rolled number puts the player outside of the stockholder track then reset stockhold meeting 
                        if (stockhold_num > 8)
                        {
                            //reset stockhold vars
                            stockhold_num = -2;
                            meeting = 2;
                            //set positon to be the board square that is at the oppiside of the meeting track
                            //move 6 board squares
                            int number = 6;
                            while (number > 0)
                            {
                                if (position.stockhold.move == 1)
                                {
                                    position_num++;
                                }
                                else if (position.stockhold.move == 2)
                                {
                                    position_num--;
                                }
                                if (position_num > 48)
                                {
                                    position_num = 1;
                                }
                                else if (position_num < 1)
                                {
                                    position_num = 48;
                                }
                                number--;
                            }
                            //if there is more of the roll left over move that much
                            if (num > 0)
                            {
                                Move(num);
                            }
                        }
                    }
                }
                //check if on a starting square
                else if (position == board[1] || position == board[13] || position == board[37] || position == board[25])
                {
                    //if the roll was even
                    if ((roll[0] + roll[1]) % 2 == 0)
                    {
                        //move the direction of the even arrow, move right
                        position.movement = 2;
                    }
                    //if the roll was odd
                    else
                    {
                        //move the direction of the odd arrow, move left
                        position.movement = 1;
                    }
                    // move like normal
                    int num = roll[0] + roll[1];
                    Move(num);
                }
                else 
                {
                    int num = roll[0] + roll[1];
                    Move(num);
                }
            }
        } //check 1/21
        private int Check_stock(int stock_num, int num) 
        {
            if(stocks[stock_num-1] >= num)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        } //check 1/21, stock_num is which stock you want to check, and num is the number of shares that you want to make sure the player has
        private int Sell_stock(Market sm) 
        {
            int choice = 0, cost=0, num, check=0;
            //forced selling
            if (position.unqiue == 1)
            {
                num = stocks[position.stock_name_num - 1];
                //cost =         lowest stock market price   * the number of shares the player has of that stock
                cost = sm.Find_base(position.stock_name_num) * num;
                //add the money the player made by selling to their money var
                money += cost;
                //reset the stock var to show that they do not have any shares of the stock they just sold
                stocks[position.stock_name_num - 1] = 0;
                //display the information to the player
                Console.WriteLine("You had {0} shares of {1}, selling those share(s) you gained {2}", num, position.title, cost);
            }
            //broke selling
            else if(money <= 0)
            {
                Show();
                //show the player their stats
                //then ask which stock the player wants to sell
                //and how much of the stock they want to sell
                Console.WriteLine("Sell shares of stock until you have money.\n");
                while (money <= 0)
                {
                    Console.WriteLine("Which stock would you like to sell?\n" +
                                      "     1) Woolworth\n" +
                                      "     2) Aloca\n" +
                                      "     3) Int. Shoe\n" +
                                      "     4) J.I. Case\n" +
                                      "     5) Maytag\n" +
                                      "     6) Gen Mills\n" +
                                      "     7) A.M. Motors\n" +
                                      "     8) Western Pub\n");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many shares of that stock do you want to sell?\n");
                    num = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            if (Check_stock(1, num) == 1)
                            {
                                cost = num * sm.Find_base(1); //sm.woolwth[sm.current_place];
                                money += cost;
                                stocks[0] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough Woolworth stock.\n");
                                check = 0;
                            }
                            break;
                        case 2:
                            if (Check_stock(2, num) == 1)
                            {
                                cost = num * sm.Find_base(2);
                                money += cost;
                                stocks[1] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough Aloca stock.\n");
                                check = 0;
                            }
                            break;
                        case 3:
                            if (Check_stock(3, num) == 1)
                            {
                                cost = num * sm.Find_base(3);
                                money += cost;
                                stocks[2] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough Int. Shoe stock.\n");
                                check = 0;
                            }
                            break;
                        case 4:
                            if (Check_stock(4, num) == 1)
                            {
                                cost = num * sm.Find_base(4);
                                money += cost;
                                stocks[3] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough J.I. Case stock.\n");
                                check = 0;
                            }
                            break;
                        case 5:
                            if (Check_stock(5, num) == 1)
                            {
                                cost = num * sm.Find_base(5);
                                money += cost;
                                stocks[4] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough Maytag stock.\n");
                                check = 0;
                            }
                            break;
                        case 6:
                            if (Check_stock(6, num) == 1)
                            {
                                cost = num * sm.Find_base(6);
                                money += cost;
                                stocks[5] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough Gen Mills stock.\n");
                                check = 0;
                            }
                            break;
                        case 7:
                            if (Check_stock(7, num) == 1)
                            {
                                cost = num * sm.Find_base(7);
                                money += cost;
                                stocks[6] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough A.M. Motors stock.\n");
                                check = 0;
                            }
                            break;
                        case 8:
                            if (Check_stock(8, num) == 1)
                            {
                                cost = num * sm.Find_base(8);
                                money += cost;
                                stocks[7] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough Western Pub stock.\n");
                                check = 0;
                            }
                            break;
                        default:
                            Console.WriteLine("Entered wrong number\n");
                            check = 0;
                            break;
                    }
                    if (check == 1)
                    {
                        Show();
                        Console.WriteLine("You gained {0}\n", cost);
                        check = 0;
                    }
                }
            }
            //for normal selling 
            else
            {
                Show();
                //show the player their stats
                //then ask which stock the player wants to sell
                //and how much of the stock they want to sell
                while (check == 0)
                {
                    Console.WriteLine("Which stock would you like to sell?\n" +
                                      "     1) Woolworth\n" +
                                      "     2) Aloca\n" +
                                      "     3) Int. Shoe\n" +
                                      "     4) J.I. Case\n" +
                                      "     5) Maytag\n" +
                                      "     6) Gen Mills\n" +
                                      "     7) A.M. Motors\n" +
                                      "     8) Western Pub\n" +
                                      "     9) Cancel\n");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many shares of that stock do you want to sell?\n");
                    num = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            if (Check_stock(1, num) == 1)
                            {
                                cost = num * sm.woolwth[sm.current_place];
                                money += cost;
                                stocks[0] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough Woolworth stock.\n");
                                check = 0;
                            }
                            break;
                        case 2:
                            if (Check_stock(2, num) == 1)
                            {
                                cost = num * sm.aloca[sm.current_place];
                                money += cost;
                                stocks[1] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough Aloca stock.\n");
                                check = 0;
                            }
                            break;
                        case 3:
                            if (Check_stock(3, num) == 1)
                            {
                                cost = num * sm.intshoe[sm.current_place];
                                money += cost;
                                stocks[2] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough Int. Shoe stock.\n");
                                check = 0;
                            }
                            break;
                        case 4:
                            if (Check_stock(4, num) == 1)
                            {
                                cost = num * sm.j_i_case[sm.current_place];
                                money += cost;
                                stocks[3] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough J.I. Case stock.\n");
                                check = 0;
                            }
                            break;
                        case 5:
                            if (Check_stock(5, num) == 1)
                            {
                                cost = num * sm.maytag[sm.current_place];
                                money += cost;
                                stocks[4] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough Maytag stock.\n");
                                check = 0;
                            }
                            break;
                        case 6:
                            if (Check_stock(6, num) == 1)
                            {
                                cost = num * sm.gen_mills[sm.current_place];
                                money += cost;
                                stocks[5] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough Gen Mills stock.\n");
                                check = 0;
                            }
                            break;
                        case 7:
                            if (Check_stock(7, num) == 1)
                            {
                                cost = num * sm.am_motors[sm.current_place];
                                money += cost;
                                stocks[6] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough A.M. Motors stock.\n");
                                check = 0;
                            }
                            break;
                        case 8:
                            if (Check_stock(8, num) == 1)
                            {
                                cost = num * sm.western_pub[sm.current_place];
                                money += cost;
                                stocks[7] -= num;
                                check = 1;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough Western Pub stock.\n");
                                check = 0;
                            }
                            break;
                        case 9:
                            Console.WriteLine("Canceling the choice of selling stock.\n");
                            check = 2;
                            break;
                        default:
                            Console.WriteLine("Entered wrong number\n");
                            check = 0;
                            break;
                    }
                    if (check == 1)
                    {
                        Show();
                        Console.WriteLine("You gained {0}\n", cost);
                    }
                }
                check = 0;
            }
            return 0;
        } 
        private void Buy_stock(Market sm)
        {
            int cost, current_price, bought = 0, shares = 0, choice=0;
            while (choice == 0)
            {
                //show the player the current stock market price for the stock
                Console.WriteLine("The current price of {0} is {1}\n", position.title, sm.Find(position.stock_name_num));
                //then ask if they wannt to buy
                Console.WriteLine("Do you want to buy shares of {0}? Yes(1) or No(2)\n", position.title);
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //yes
                        while (bought == 0)
                        {
                            //if the player tried to buy more shares than they had money to buy, need to ask again how many shares do they want to buy,
                            //and show them the stock market price
                            if (shares == 0)
                            {
                                sm.Show();
                                if (position.meeting != 1)
                                {
                                    Console.WriteLine("How many shares of {0} do you want to buy? Enter a number.\n", position.title);
                                    shares = Convert.ToInt32(Console.ReadLine());
                                }
                                else
                                {
                                    shares = 1;
                                }
                            }
                            //calcuate the current price of the stock that the player wants to buy
                            current_price = sm.Find(position.stock_name_num);
                            //cost = the # of stock the players wants to buy * the current stock price from the stock market
                            cost = shares * current_price;
                            //check if the player can afford to pay
                            if (money < cost)
                            {
                                //tell the player they can not afford the number of share they ask to buy
                                Console.WriteLine("You do not have enough money to buy the amount of shares that you wanted.\n");
                                //if they are on a stock holders meeting square and can't afford to buy one share, exit the loop and tell them they can't afford it
                                if (position.meeting == 1)
                                {
                                    Console.WriteLine("You can only buy one share because you are on a stockholders meeting entance square, but do not have enough money to buy one share.\n");
                                    bought = 1;
                                }
                                //if not on a stock holder meeting square then reset the share var to 0
                                //then the while loop goes again and will go into the if statment based on shares and ask how many shares again
                                else
                                {
                                    shares = 0;
                                }

                            }
                            //the player can afford to buy the number of shares they asked for
                            else
                            {
                                //charge the player the right amount of money, I know I could use compound statement but I find that I can read this better, personal perference
                                money -= cost;
                                //add the right amount of shares to the players stock
                                //stocks[position.stock_name_num - 1] = stocks[position.stock_name_num - 1] + shares;
                                stocks[position.stock_name_num - 1] += shares;
                                //show the player what happen
                                Console.WriteLine("Player: {0}, {1}, you wanted to buy {2} shares of {3}, with the current stock price of {4}, which will cost you {5}.\n", name, color_name, shares, position.title, current_price, cost); //input string was not in a correct format
                                Show();
                                //set bought to 1 to break the while loop
                                bought = 1;
                            }
                        }
                        break;
                    case 2:
                        //no
                        Console.WriteLine("You choose to not buy any.\n");
                        break;
                    default:
                        Console.WriteLine("Entered wrong number yes(1) or no(2)\n");
                        choice = 0;
                        break;
                }
            }
        } //check 1/21
        private void Broker_fee()
        {
            int sum = 0;
            for (int y = 0; y < 8; y++)
            {
                sum += stocks[y];
            }
            Console.WriteLine("You have {0} shares in total, the broker fee will cost you {1}.", sum, sum * 10);
            money -= (sum * 10);
        }
        private void Broke(Market sm)
        {
            //broke
            int choice = 0;
            if(money < 0)
            {
                while (choice == 0)
                {
                    //need to sell
                    Console.WriteLine("You have gone broke.\n" +
                                  "Here are your options:\n" +
                                  "1) Sell shares inorder to get out of the hole\n" +
                                  "2) Go back to the working phase of the game, you lose everything, reset back to the start of the game.\n");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Sell_stock(sm);
                            break;
                        case 2:
                            Reset();
                            break;
                        default:
                            Console.WriteLine("Entered wrong number.\n");
                            choice = 0;
                            break;
                    }
                }
            }
        }
        public void Turn(Market sm, Player[] p, int size, ref int working)
        {
            int choice, end_turn = 0;
            while (end_turn == 0)
            {
                //The options during a players turn, which is stored into choice
                Console.WriteLine("It's {0},{1} turn!\n" +
                    "Here are your options: \n" +
                    "1)Roll\n" +
                    "2)Change Jobs/Quit Working - only allowed before rolling\n" +
                    "3)Sell Stock - ONLY ALLOWED BEFORE ROLLING\n" +
                    "4)Show the Stock Market - only allowed before rolling\n" +
                    "5)Show My Stock - only allowed before rolling\n", name, color_name);
                choice = Convert.ToInt32(Console.ReadLine());
                //the switch will handle each option that a player can choose during a turn
                switch (choice)
                {
                    case 1:
                        //roll
                        Roll();
                        //if working, check if the player has made enough money to get kick out of "work"
                        if(work == 1 || work == 2 || work == 3 || work == 4)
                        {
                            if (money >= 1000)
                            {
                                Done_working();
                                working--;
                            }
                        }
                        //check if any of the players are still in the working phase
                        if (working != 0)
                        {
                            Pay(size, p, Check_roll());
                        }
                        Move();
                        //if not working 
                        if (work == -1)
                        {
                            //show the player the square they landed on
                            //if they are in stockholder meeting track
                            if (stockhold_num >= -1)
                            {
                                Console.WriteLine("Player: {0},{1}, you landed on {2} for 1 in the stockholders meeting.\n", name, color_name, position.stockhold.stockholder[stockhold_num]);
                                int add = stocks[position.stock_name_num - 1] * position.stockhold.stockholder[stockhold_num];
                                stocks[position.stock_name_num - 1] += add;
                                Console.WriteLine("You have gained, {0} shares! Now you have {1} shares.\n", add, stocks[position.stock_name_num - 1]);
                            }
                            //if they are not actively in stockholder meeting track
                            else if (stockhold_num == -2)
                            {
                                Console.WriteLine("Player: {0},{1}, here is where you are on the board.\n", name, color_name);
                                position.Show();

                                //if the square is a sell all
                                if (position.unqiue == 1)
                                {
                                    Sell_stock(sm);
                                    //move the stock market
                                    sm.Move(position);
                                    Show();
                                }
                                //broker fee
                                else if (position.unqiue == 2)
                                {
                                    Broker_fee();
                                    Broke(sm);
                                    //move the stock market
                                    sm.Move(position);
                                    Show();
                                }
                                //100 fee
                                else if (position.unqiue == 3)
                                {
                                    Console.WriteLine("You landed on a $100 fee square.\n");
                                    money -= 100;
                                    Broke(sm);
                                    Show();
                                }
                                //normal square
                                else
                                {
                                    //move the stock market
                                    sm.Move(position);
                                    //check if the player gets a div
                                    if (stocks[position.stock_name_num-1] > 0)
                                    {
                                        // ( div           *    the amount of stock the player has )
                                        money += (position.div * stocks[position.stock_name_num-1]);
                                        Console.WriteLine("Player: {0},{1} you got {2} in dividends\n", name, color_name, (position.div * stocks[position.stock_name_num-1]) );
                                        Show();
                                    }
                                    //give the player the option to buy
                                    Buy_stock(sm);
                                    //ask if the player wants to go inot the stockholders meeting
                                    if (position.meeting == 1)
                                    {
                                        choice = 0;
                                        while (choice == 0)
                                        {
                                            Console.WriteLine("Do you want to go into the stockholders meeting? Yes(1) or No(2)\n");
                                            choice = Convert.ToInt32(Console.ReadLine());
                                            switch (choice)
                                            {
                                                case 1:
                                                    //check if the player can go into the meeting,
                                                    //check if they have at least one stock of the stock meeting they are wanting to go into
                                                    if (stocks[position.stock_name_num - 1] > 0)
                                                    {
                                                        //go into the meeting 
                                                        meeting = 1;
                                                        stockhold_num = -1;
                                                    }
                                                    else
                                                    {
                                                        //can't go into the meeting
                                                        meeting = 2;
                                                        Console.WriteLine("Sorry, you do not have at least one stock which is required to be able to go into the stockholders meeting.\n");
                                                        Show();
                                                    }
                                                    break;
                                                case 2:
                                                    //not going into the meeting
                                                    meeting = 2;
                                                    Console.WriteLine("You are not going into the stockholders meeting.\n");
                                                    break;
                                                default:
                                                    //error message
                                                    Console.WriteLine("Entered wrong number yes(1) or no(2)\n");
                                                    choice = 0;
                                                    break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        end_turn = 1;
                        break;
                    case 2:
                        //Change Jobs or Quit Job, players can do this before rolling only
                        Change_job();
                        break;
                    case 3:
                        //Sell Stock, a player can only do this before rolling
                        Sell_stock(sm);
                        break;
                    case 4:
                        //Show Stock Market
                        sm.Show();
                        break;
                    case 5:
                        //Show players hand
                        Show();
                        break;
                    default:
                        //Error message
                        Console.WriteLine("Enter wrong number or invalid character, try again\n");
                        break;
                }
            }

        }
        public Player()
        {
            //seting up the player's information
            for (int d = 1; d <= 48; d++)
            {
                board[d] = new Board_Square(d);
            }
            Console.WriteLine("Welcome to Stock Market the board game!\n");
            Console.WriteLine("What is your name?\n");
            name = Console.ReadLine();
            Console.WriteLine("What color do you want to be?\n");
            color_name = Console.ReadLine();
            while (work == -1)
            {
                Console.WriteLine("What job do you want?\n" +
                    "1) Prospector\n" +
                    "2) Policeman\n" +
                    "3) Doctor\n" +
                    "4) Deep Sea Diver\n" +
                    "5) Want a description of the jobs?\n");
                int temp = Convert.ToInt32(Console.ReadLine());
                if (temp != 5)
                {
                    work = temp;
                    money = 0;
                    work_name = work switch
                    {
                        1 => "Prospector",
                        2 => "Policeman",
                        3 => "Doctor",
                        4 => "Deep Sea Diver",
                        _ => "None",
                    };
                    for (int loop = 0; loop < 8; loop++)
                    {
                        stocks[loop] = 0;
                    }
                    Console.WriteLine("Player {0}, {1}:", name, color_name);
                    Show();
                }
                else
                {
                    Prospector.Show();
                    Policeman.Show();
                    Doctor.Show();
                    Deep_Sea_Diver.Show();
                }
            }
        }
    }
}
