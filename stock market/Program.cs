using System;

namespace stock_market
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int end_game = 0, end_turn = 0, x = 0;
            Market sm = new Market();
            Console.WriteLine("Welcome to Stock Market the board game!\n");
            Console.WriteLine("How many players are going to play?\n");
            int size = Convert.ToInt32(Console.ReadLine());
            Player[] players = new Player[size];
            /*Start_Board Prospector = new Start_Board(1);
            Start_Board Policeman = new Start_Board(2);
            Start_Board Doctor = new Start_Board(3);
            Start_Board Deep_Sea_Diver = new Start_Board(4);
            Board start1 = new Board(1);
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
            Board fourty_one = new Board(40) ;
            Board fourty_two = new Board(41);
            Board fourty_three = new Board(42) ;
            Board fourty_four = new Board(43) ;
            Board fourty_five = new Board(44) ;
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
            fourty_nine.left = fourty_eight;*/
            for (x = 0; x < size; x++)
            {
                players[x] = new Player();
            }
            Console.WriteLine("Ok, so there is {0} players.\n", size);
            x = 0;
            while (end_game != 1)
            {
                if(end_turn == 0)
                {
                    Console.WriteLine("It's {0},{1} turn!\n Here are your options: \n 1)Roll\n 2)Change Jobs/Quit Working\n 3)Sell Stock\n 4)Show the Stock Market\n 5)Show My Stock\n", players[x].name,players[x].color_name);
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            //roll
                            players[x].rolling(size,players);
                            end_turn = 1;
                            break;
                        case 2:
                            //Change Jobs or Quit Job
                            players[x].change_job();
                            end_turn = 1;
                            break;
                        case 3:
                            //Sell Stock
                            players[x].sell_stock(sm);
                            break;
                        case 4:
                            //Show Stock Market
                            sm.show();
                            break;
                        case 5:
                            //Show players hand
                            players[x].show();
                            break;
                        default:
                            //Error message
                            Console.WriteLine("Enter wrong number or invalid character, try again\n");
                            break;
                    }
                    if (end_turn == 1)
                    {
                        x++;
                        end_turn = 0;
                        if(x >= size)
                        {
                            x = 0;
                        }
                        Console.WriteLine("\n\n\n\n");
                    }
                }
            }
        }
    }
}
