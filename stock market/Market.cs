using System;
using System.Collections.Generic;
using System.Text;

namespace stock_market
{
    public class Market
    {
        public int current_place;
        public int[] woolwth = new int[51]{30,34,38,42,46,50,54,58,62,66,70,74,78,82,86,90,94,98,102,106,110,114,118,122,126,130,134,138,142,146,150,154,158,162,166,170,174,178,182,186,190,194,198,202,206,210,214,218,222,236,230};  //1
        public int[] aloca = new int[51]{230,226,222,218,214,210,206,202,198,194,190,186,182,178,174,170,166,162,158,154,150,146,142,138,134,130,126,122,118,114,110,106,102,98,94,90,86,82,78,74,70,66,62,58,54,50,46,42,38,34,30};    //2
        public int[] intshoe = new int[51]{18,18,19,19,20,20,21,21,22,22,23,23,24,24,25,25,26,26,27,27,28,28,29,29,30,30,30,31,31,32,32,33,33,34,34,35,35,36,36,37,37,38,38,39,39,40,40,41,41,42,42};  //3
        public int[] j_i_case = new int[51]{75,74,73,72,71,70,69,68,67,66,65,64,63,62,61,60,59,58,57,56,55,53,51,49,47,45,43,41,39,37,35,34,33,32,31,30,29,28,27,26,25,24,23,22,21,20,19,18,17,16,15}; //4
        public int[] maytag = new int[51]{15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,37,39,41,43,45,47,49,51,53,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75};   //5
        public int[] gen_mills = new int[51]{42,42,41,41,40,40,39,39,38,38,37,37,36,36,35,35,34,34,33,33,32,32,31,31,30,30,30,29,29,28,28,27,27,26,26,25,25,24,24,23,23,22,22,21,21,20,20,19,19,18,18}; //6
        public int[] am_motors = new int[51]{110,108,106,104,102,100,98,96,94,92,90,88,86,84,82,80,78,76,74,72,70,68,66,64,62,60,58,56,54,52,50,48,46,44,42,40,38,36,34,32,30,28,26,24,22,20,18,16,14,12,10}; //7
        public int[] western_pub = new int[51]{10,12,14,16,18,20,22,24,26,28,30,32,34,36,38,40,42,44,46,48,50,52,54,56,58,60,62,64,66,68,70,72,74,76,78,80,82,84,86,88,90,92,94,96,98,100,102,104,106,108,110}; //8

        public void Move(Board_Square b)
        {
            int x;
            //move the stock market to the new place
            //down
            if (b.direction == 1)
            {
                current_place += b.move;
            }
            //up
            else
            {
                current_place -= b.move;
            }
            //check if current_place is out of bounds
            if (current_place < 0)
            {
                x = current_place * -1;
                current_place = 0;
                current_place += x;
            }
            if (current_place > 50)
            {
                x = current_place - 50;
                current_place = 50;
                current_place -= x;
            }
        } //done, move the current place of the stock market
        public int Find(int stock_name_num)
        {
            switch(stock_name_num)
            {
                case 1:
                    return woolwth[current_place];
                case 2:
                    return aloca[current_place];
                case 3:
                    return intshoe[current_place];
                case 4:
                    return j_i_case[current_place];
                case 5:
                    return maytag[current_place];
                case 6:
                    return gen_mills[current_place];
                case 7:
                    return am_motors[current_place];
                case 8:
                    return western_pub[current_place];
                default:
                    Console.WriteLine("Enter wrong number!\n");
                    return -1;
            }
        }//returns the current price of the stock num you have given the function
        public int Find_base(int stock_name_num)
        {
            switch (stock_name_num)
            {
                case 1:
                    return woolwth[0];
                 case 2:
                    return aloca[50];
                case 3:
                    return intshoe[0];
                case 4:
                    return j_i_case[50];
                case 5:
                    return maytag[0];
                case 6:
                    return gen_mills[50];
                case 7:
                    return am_motors[50];
                case 8:
                    return western_pub[0];
                default:
                    Console.WriteLine("Enter wrong number!\n");
                    return -1;
            }
        }
        public void Show()
        {
            Console.WriteLine("Here is the Stocket Market right now: \n");
            Console.WriteLine("------------------\n");
            Console.WriteLine("        Woolwth: {0}\n", woolwth[current_place]);
            Console.WriteLine("        Aloca: {0}\n", aloca[current_place]);
            Console.WriteLine("        Int Shoe: {0}\n", intshoe[current_place]);
            Console.WriteLine("        J.I. Case: {0}\n", j_i_case[current_place]);
            Console.WriteLine("        Maytag: {0}\n", maytag[current_place]);
            Console.WriteLine("        Gen Mills: {0}\n", gen_mills[current_place]);
            Console.WriteLine("        A.M. Motors: {0}\n", am_motors[current_place]);
            Console.WriteLine("        Western Pub: {0}\n", western_pub[current_place]);
            Console.WriteLine("------------------\n\n");
        } //done, shows the current price of each stock
        public Market()
        {
            current_place = 25;
            /*for (int x = 0; x < 51; x++)
            {
                woolwth[x] = 30 + (x * 4);
                aloca[x] = 230 - (x * 4);
                if (x == 0)
                {
                    intshoe[x] = 18;
                    gen_mills[x] = 42;
                }
                else if (x % 2 == 0)
                {
                    intshoe[x] = intshoe[x - 1] + 1;
                    gen_mills[x] = gen_mills[x - 1] - 1;
                }
                else
                {
                    intshoe[x] = intshoe[x - 1];
                    gen_mills[x] = gen_mills[x - 1];
                }
                if (x <= 20)
                {
                    maytag[x] = 15 + x;
                    j_i_case[x] = 75 - x;
                }
                else
                {
                    maytag[x] = maytag[x - 1] + 2;
                    j_i_case[x] = j_i_case[x - 1] - 2;
                }
                am_motors[x] = 110 - (x * 2);
                western_pub[x] = 10 + (x * 2);
            }*/
        } //done, calls fill because a new market was created
    }
}
