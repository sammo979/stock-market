using System;
using System.Collections.Generic;
using System.Text;

/*Need to make shared spaced between one player and the whole group of players, 
which will include the stock market and the color choice left after someone has pick their color
and*/
namespace stock_market
{
    public class Player
    {
        public int money = 0;
        public int position;
        public string color_name;
        public string name;
        public int[] stocks = new int[8];
        public int[] roll = new int[2];
        public int work = 0;
        public int pay =0;
        public int meeting; // 1 means in meeting, 2 means not in meeting
        public string work_name;
        Start_Board Prospector = new Start_Board(1);
        Start_Board Policeman = new Start_Board(2);
        Start_Board Doctor = new Start_Board(3);
        Start_Board Deep_Sea_Diver = new Start_Board(4);
        LinkedList<Board> floor = new LinkedList<Board>();
        Board start1 = new Board(1);
        floor.AddFirst(Board start1);
        Board one = new Board(2);
        Board two = new Board(3);
        Board three = new Board(4);
        Board four = new Board(5);
        Board five = new Board(6);
        Board six = new Board(7);
        Board seven = new Board(8);
        Board eight = new Board(9);
        Board nine = new Board(10);
        Board ten = new Board(11);
        Board eleven = new Board(12);
        Board start2 = new Board(13);
        Board twelve = new Board(14);
        Board fourteen = new Board(15);
        Board fifthteen = new Board(16);
        Board sixteen = new Board(17);
        Board seventeen = new Board(18);
        Board eighteen = new Board(19);
        Board nineteen = new Board(20);
        Board twenty_one = new Board(21);
        Board twenty_two = new Board(22);
        Board twenty_three = new Board(23);
        Board twenty_four = new Board(24);
        Board start3 = new Board(25);
        Board twenty_six = new Board(26);
        Board twenty_seven = new Board(27);
        Board twenty_eight = new Board(28);
        Board twenty_nine = new Board(29);
        Board thirty_one = new Board(30);
        Board thirty_two = new Board(31);
        Board thirty_three = new Board(32);
        Board thirty_four = new Board(33);
        Board thirty_five = new Board(34);
        Board thirty_six = new Board(35);
        Board thirty_seven = new Board(36);
        Board start4 = new Board(37);
        Board thirty_nine = new Board(38);
        Board fourty = new Board(39);
        Board fourty_one = new Board(40);
        Board fourty_two = new Board(41);
        Board fourty_three = new Board(42);
        Board fourty_four = new Board(43);
        Board fourty_five = new Board(44);
        Board fourty_six = new Board(45);
        Board fourty_seven = new Board(46);
        Board fourty_eight = new Board(47);
        Board fourty_nine = new Board(48);
        
        start1.right = one;
        start1.left = fourty_nine;
        one.right = two;
        one.left = start1;
        two.right = three;
        two.left = one;
        three.right = four;
        three.left = two;
        four.right = five;
        four.left = three;
        five.right = six;
        five.left = four;
        six.right = seven;
        six.left = five;
        seven.right = eight;
        seven.left = six;
        eight.right = nine;
        eight.left = seven;
        nine.right = ten;
        nine.left = eight;
        ten.right = eleven;
        ten.left = nine;
        eleven.right = start2;
        eleven.left = ten;
        start2.right = twelve;
        start2.left = eleven;
        twelve.right = fourteen;
        twelve.left = start2;
        fourteen.right = fifthteen;
        fourteen.left = twelve;
        fifthteen.right = sixteen;
        fifthteen.left = fourteen;
        sixteen.right = seventeen;
        sixteen.left = fifthteen;
        seventeen.right = eighteen;
        seventeen.left = sixteen;
        eighteen.right = nineteen;
        eighteen.left = seventeen;
        nineteen.right = twenty_one;
        nineteen.left = eighteen;
        twenty_one.right = twenty_two;
        twenty_one.left = nineteen;
        twenty_two.right = twenty_three;
        twenty_two.left = twenty_one;
        twenty_three.right = twenty_four;
        twenty_three.left = twenty_two;
        twenty_four.right = start3;
        twenty_four.left = twenty_three;
        start3.right = twenty_six;
        start3.left = twenty_four;
        twenty_six.right = twenty_seven;
        twenty_six.left = start3;
        twenty_seven.right = twenty_eight;
        twenty_seven.left = twenty_six;
        twenty_eight.right = twenty_nine;
        twenty_eight.left = twenty_seven;
        twenty_nine.right = thirty_one;
        twenty_nine.left = twenty_eight;
        thirty_one.right = thirty_two;
        thirty_one.left = twenty_nine;
        thirty_two.right = thirty_three;
        thirty_two.left = thirty_one;
        thirty_three.right = thirty_four;
        thirty_three.left = thirty_two;
        thirty_four.right = thirty_five;
        thirty_four.left = thirty_three;
        thirty_five.right = thirty_six;
        thirty_five.left = thirty_four;
        thirty_six.right = thirty_seven;
        thirty_six.left = thirty_five;
        thirty_seven.right = start4;
        thirty_seven.left = thirty_six;
        start4.right = thirty_nine;
        start4.left = thirty_seven;
        thirty_nine.right = fourty;
        thirty_nine.left = start4;
        fourty.right = fourty_one;
        fourty.left = thirty_nine;
        fourty_one.right = fourty_two;
        fourty_one.left = fourty;
        fourty_two.right = fourty_three;
        fourty_two.left = fourty_one;
        fourty_three.right = fourty_four;
        fourty_three.left = fourty_two;
        fourty_four.right = fourty_five;
        fourty_four.left = fourty_three;
        fourty_five.right = fourty_six;
        fourty_five.left = fourty_four;
        fourty_six.right = fourty_seven;
        fourty_six.left = fourty_five;
        fourty_seven.right = fourty_eight;
        fourty_seven.left = fourty_six;
        fourty_eight.right = fourty_nine;
        fourty_eight.left = fourty_seven;
        fourty_nine.right = start1;
        fourty_nine.left = fourty_eight;
        public void show()
        {
            //this has been tested it is done
            Console.WriteLine("{0}, here is your stats\n", this.color_name);
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Money: {0}\n", this.money);
            Console.WriteLine("Work Status: {0}\n", this.work_name);
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Stocks: \n");
            Console.WriteLine("        Woolwth: {0}\n", this.stocks[0]);
            Console.WriteLine("        Aloca: {0}\n", this.stocks[1]);
            Console.WriteLine("        Int Shoe: {0}\n", this.stocks[2]);
            Console.WriteLine("        J.I. Case: {0}\n", this.stocks[3]);
            Console.WriteLine("        Maytag: {0}\n", this.stocks[4]);
            Console.WriteLine("        Gen Mills: {0}\n", this.stocks[5]);
            Console.WriteLine("        A.M. Motors: {0}\n", this.stocks[6]);
            Console.WriteLine("        Western Pub: {0}\n", this.stocks[7]);
            Console.WriteLine("----------------------\n\n");
        }
        public void rolling(int size,Player[] p)
        {
            var rand = new Random();
            this.roll[0] = rand.Next(1,6);
            this.roll[1] = rand.Next(1,6);
            Console.WriteLine("{0}, {1} rolled {2} {3}.\n", this.name,this.color_name, this.roll[0], this.roll[1]);
            this.player_move(size, p);
        }
        public void work_pay(int size, Player[] p, int work )
        {

            if (work == 1)
            {
                pay = 400;
            }
            else if (work == 2)
            {
                pay = 100;
            }
            else if (work == 3)
            {
                pay = 200;
            }
            else if (work == 4)
            {
                pay = 300;
            }
            for (int x = 0; x < size; x++)
            {
                if (p[x].work == work)
                {
                    p[x].money = p[x].money + pay;
                    Console.WriteLine("{0}, {1} got paid this amount {2}.\n",p[x].name,p[x].color_name , pay);
                }
            }
        }
        public void change_job()
        {
            int choice = 0;
            while (choice != 5)
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
                        this.work_name = "Prospector";
                        this.work = 1;
                        break;
                    case 2:
                        this.work_name = "Policeman";
                        this.work = 2;
                        break;
                    case 3:
                        this.work_name = "Doctor";
                        this.work = 3;
                        break;
                    case 4:
                        this.work_name = "Deep Sea Diver";
                        this.work = 4;
                        break;
                    case 5:
                        Prospector.show();
                        Policeman.show();
                        Doctor.show();
                        Deep_Sea_Diver.show();
                        break;
                    default:
                        this.work_name = "None";
                        break;
                }
            }
            this.show();
        }
        public void check_roll(int first, int second,int size,Player[] p)
        {
            //prospector
            if ((first + second) == 2 || (first + second) == 12)
            {
                //players working as prospector get paid
                work_pay(size,p,1);
                Console.WriteLine("Players working as prospectors got paid\n");
            }
            //policeman
            else if ((first + second) == 5 || (first + second) == 9)
            {
                //players working as policeman get paid
                work_pay(size,p,2);
                Console.WriteLine("Players working as policemans got paid\n");
            }
            //Doctor 
            else if ((first + second) == 4 || (first + second) == 10)
            {
                //players working as a Doctor
                work_pay(size,p,3);
                Console.WriteLine("Players working as Doctors got paid\n");
            }
            //Deep Sea Diver
            else if ((first + second) == 3 || (first + second) == 11)
            {
                //players working as a Deep Sea Diver
                work_pay(size,p,4);
                Console.WriteLine("Players working as Deep Sea Divers got paid\n");
            }
            else
            {
                Console.WriteLine("Nobody who is working got paid this round.\n");
            }
        }
        public void player_move(int size, Player[] p)//still a work in progress
        {
            int choice = 0;
            check_roll(this.roll[0], this.roll[1],size,p);
            if (this.work == 1)//if player is still in "work"
            {
                if (this.money >= 1000)//check if the player has made enough money to get kick out of "work"
                {
                    Console.WriteLine("{0}: You have passed the limit for working. Pick which starting square you want.\n" +
                        "1) which is by Western Publ. and AM. Motors Stockholders Meeting\n" +
                        "2) which is by J.I. Case and Maytag Stockholders Meeting\n" +
                        "3) which is by Aloca and Woolworth Stockholders Meeting\n" +
                        "4) which is by Int. Shoe and Gen Mills Stockholders Meeting\n",this.color_name);
                    choice = Convert.ToInt32(Console.ReadLine());
                    this.work = 0;
                    this.position = choice;
                    Console.WriteLine("{0} is moving out of the work phase of the game and is now on the board!\n",this.color_name);
                }
            }
            if(this.work != 1 && choice == 0)//if player not working and didn't just move out of working, take normal turn
            {
                switch(this.position)
                {
                    case 1:
                        
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            }
        }
        public int check_stock()
        {
            return 0;
        }
        public int sell_stock(Market sm)
        {
            if (check_stock() == 0)
            {
                Console.WriteLine("You do not have any stocks.\n");
                return -1;
            }
            int choice, cost=0, num, check=0;
            //show();
            this.show();
            while (check != 1)
            {
                Console.WriteLine("Which stock would you like to sell?\n");
                Console.WriteLine("1) Woolworth, 2) Aloca, 3) Int. Shoe, 4) J.I. Case, 5) Maytag, 6) Gen Mills, 7) A.M. Motors, 8) Western Pub\n");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many stock of that type do you want to sell?\n");
                num = Convert.ToInt32(Console.ReadLine());
                check = 1;
                switch (choice)
                {
                    case 1:
                        if (this.stocks[0] >= num)
                        {
                            cost = num * sm.woolwth[sm.current_place];
                            this.money = this.money + cost;
                            this.stocks[0] = this.stocks[0] - num;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough stocks.\n");
                            check = 0;
                        }
                        break;
                    case 2:
                        if (this.stocks[1] >= num)
                        {
                            cost = num * sm.aloca[sm.current_place];
                            this.money = this.money + cost;
                            this.stocks[1] = this.stocks[1] - num;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough stocks.\n");
                            check = 0;
                        }
                        break;
                    case 3:
                        if (this.stocks[2] >= num)
                        {
                            cost = num * sm.intshoe[sm.current_place];
                            this.money = this.money + cost;
                            this.stocks[2] = this.stocks[2] - num;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough stocks.\n");
                            check = 0;
                        }
                        break;
                    case 4:
                        if (this.stocks[3] >= num)
                        {
                            cost = num * sm.j_i_case[sm.current_place];
                            this.money = this.money + cost;
                            this.stocks[3] = this.stocks[3] - num;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough stocks.\n");
                            check = 0;
                        }
                        break;
                    case 5:
                        if (this.stocks[4] >= num)
                        {
                            cost = num * sm.maytag[sm.current_place];
                            this.money = this.money + cost;
                            this.stocks[4] = this.stocks[4] - num;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough stocks.\n");
                            check = 0;
                        }
                        break;
                    case 6:
                        if (this.stocks[5] >= num)
                        {
                            cost = num * sm.gen_mills[sm.current_place];
                            this.money = this.money + cost;
                            this.stocks[5] = this.stocks[5] - num;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough stocks.\n");
                            check = 0;
                        }
                        break;
                    case 7:
                        if (this.stocks[6] >= num)
                        {
                            cost = num * sm.am_motors[sm.current_place];
                            this.money = this.money + cost;
                            this.stocks[6] = this.stocks[6] - num;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough stocks.\n");
                            check = 0;
                        }
                        break;
                    case 8:
                        if (this.stocks[7] >= num)
                        {
                            cost = num * sm.western_pub[sm.current_place];
                            this.money = this.money + cost;
                            this.stocks[7] = this.stocks[7] - num;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough stocks.\n");
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
                    show();
                    Console.WriteLine("You gained %d\n", cost);
                }
            }
            return 0;
        }
        public Player()
        {
            Console.WriteLine("Welcome to Stock Market the board game!\n");
            Console.WriteLine("What is your name?\n");
            this.name = Console.ReadLine();
            Console.WriteLine("What color do you want to be?\n");
            this.color_name = Console.ReadLine();
            while (this.work == 0)
            {
                Console.WriteLine("What job do you want? ex 1-Prospector,2-Policeman,3-Doctor,4-Deep Sea Diver\n Want a description of the jobs? Press 5\n");
                int temp = Convert.ToInt32(Console.ReadLine());
                if (temp != 5)
                {
                    this.work = temp;
                    this.money = 0;
                    switch (this.work)
                    {
                        case 1:
                            this.work_name = "Prospector";
                            break;
                        case 2:
                            this.work_name = "Policeman";
                            break;
                        case 3:
                            this.work_name = "Doctor";
                            break;
                        case 4:
                            this.work_name = "Deep Sea Diver";
                            break;
                        default:
                            this.work_name = "None";
                            break;
                    }
                    for (int loop = 0; loop < 8; loop++)
                    {
                        this.stocks[loop] = 0;
                    }
                    Console.WriteLine("Player {0}, {1}:", this.name, this.color_name);
                    this.show();
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
