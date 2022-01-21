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
        public int work = 0; //the number that corresponds to the job a player has, prospector-1, policeman-2, doctor-3, deep sea diver-4, not working:-1
        public int pay =0; //if working then the salary amount for the job the player has
        public int meeting; // 1 means in meeting, 2 means not in meeting
        public string work_name; //the name of the work
        public Board_Square position; // the current postion of the player
        public int position_num; // the current postion num in the array
        private readonly Board_Square[] board = new Board_Square[49];
        private readonly Start_Board Prospector = new Start_Board(1);
        private readonly Start_Board Policeman = new Start_Board(2);
        private readonly Start_Board Doctor = new Start_Board(3);
        private readonly Start_Board Deep_Sea_Diver = new Start_Board(4);
        public void Move_position() 
        {
            int num = roll[0] + roll[1];
            while (num > 0)
            {
                if (position.movement == 1)
                {
                    position_num--;
                }
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
        public void Show() 
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
        public void Roll() 
        {
            // creates an array containing two random numbers(1-6) to act as our dice. Displays the two numbers to the player. Then calls player_move to move the player around the board.
            var rand = new Random();
            roll[0] = rand.Next(1,6);
            roll[1] = rand.Next(1,6);
            Console.WriteLine("{0}, {1} rolled {2} {3}.\n", name,color_name, roll[0], roll[1]);
            //player_move(size, p,sm);  //lets make it separte 
        } //check 1/21
        public void Work_pay(int size, Player[] p, int work)
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
        public void Change_job() 
        { 
            //give the options on what the player can switch to, then displays the changed information.
            int choice = 0;
            while (choice == 0)
            {
                Console.WriteLine("What job do you want? The new job must be different then the one you had before.\n " +
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
                        Prospector.show();
                        Policeman.show();
                        Doctor.show();
                        Deep_Sea_Diver.show();
                        choice = 0;
                        break;
                    case 6:
                        work_name = "Done";
                        work = -1;
                        pay = 0;
                        choice = 6;
                        break;
                    default:
                        Console.WriteLine("Enter a wrong number.\n");
                        choice = 0;
                        break;
                 }
            }
            Console.WriteLine("{0}, {1} changed jobs successfully.\n", name, color_name);
        } //done 1/21
        public int Check_roll()
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
        public void Player_move(Market sm)
        {
            int choice;
            //if player is still in "work"
            if (work == 1 || work == 2 || work == 3 || work == 4)
            {
                //check if the player has made enough money to get kick out of "work",
                //the rule is that once you hit 1000 or more you can only collect salary until your next turn,
                //mine only allows you to collect if you got more than 1000 on someones elses turn
                if (money >= 1000) 
                {
                    int check = 0;
                    while (check == 0)
                    { 
                        // 1 with woolworth next, gen mills 13 int shoe, am motors 25 western publishing, ji case 37 maytag
                        Console.WriteLine("{0}: You have passed the limit for working. Pick which starting square you want.\n" +
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
                                position = board[25];
                                check = 1;
                                break;
                            case 2:
                                position = board[37];
                                check = 1;
                                break;
                            case 3:
                                position = board[1];
                                check = 1;
                                break;
                            case 4:
                                position = board[13];
                                check = 1;
                                break;
                            default:
                                Console.WriteLine("Enter wrong number\n");
                                break;
                        }
                    }
                    Console.WriteLine("{0} is moving out of the work phase of the game and is now on the board!\n",color_name);
                }
            }
            //if the player is  not work
            if(work == -1)
            {
                //check if on a starting square
                if (position == board[1] || position == board[13] || position == board[37] || position == board[25])
                {
                    //check if the roll was even
                    if ((roll[0] + roll[1]) % 2 == 0)
                    {
                        //move the direction of the even arrow, move right
                        position.movement = 2;
                        Move_position();
                    }
                    //the roll was not even so its odd
                    else
                    {
                        //move the direction of the odd arrow, move left
                        position.movement = 1;
                        Move_position();
                    }
                }
                //on a normal square
                else
                {
                    //move in the direction of the arrow
                    Move_position(); 
                }
                //move stock market
                sm.Inc(position.move, position.direction);
            }
        }
        public int Check_stock(int stock_num, int num) 
        {
            if(stocks[stock_num] >= num)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        } //check 1/21, stock_num is which stock you want to check, and num is the number of shares that you want to make sure the player has
        public int Sell_stock(Market sm) 
        {
            //forced selling

            //for normal selling
            int choice, cost=0, num, check=0;
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
                        if (Check_stock(1,num)== 1)
                        {
                            cost = num * sm.woolwth[sm.current_place];
                            money += cost;
                            //stocks[0] = stocks[0] - num;
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
                        check = 0;
                        break;
                    default:
                        Console.WriteLine("Entered wrong number\n");
                        check = 0;
                        break;
                }
                if (check == 1)
                {
                    Show();
                    Console.WriteLine("You gained %d\n", cost);
                }
            }
            return 0;
        } //check 1/21, not done, need forced selling
        public void Buy_stock(Market sm)
        {
            int cost, current_price, bought = 0, shares = 0, choice=0;
            while (choice == 0)
            {
                //show the player the current stock market price for the stock
                Console.WriteLine("The current price of {0} is %d\n", position.title, sm.Find(position_num));
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
                                Console.WriteLine("Player: {0], {1}, you wanted to buy %d shares of {2}, with the current stock price of %d, which will cost you %d.\n", name, color_name, shares, position.title, current_price, cost);
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
            while (work == 0)
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
                    switch (work)
                    {
                        case 1:
                            work_name = "Prospector";
                            break;
                        case 2:
                            work_name = "Policeman";
                            break;
                        case 3:
                            work_name = "Doctor";
                            break;
                        case 4:
                            work_name = "Deep Sea Diver";
                            break;
                        default:
                            work_name = "None";
                            break;
                    }
                    for (int loop = 0; loop < 8; loop++)
                    {
                        stocks[loop] = 0;
                    }
                    Console.WriteLine("Player {0}, {1}:", name, color_name);
                    Show();
                }
                else
                {
                    Prospector.show();
                    Policeman.show();
                    Doctor.show();
                    Deep_Sea_Diver.show();
                }
            }
        }
    }
}
