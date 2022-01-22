using System;
using System.Collections.Generic;
using System.Text;

namespace stock_market
{
    public class Market
    {
        public int current_place;
        public int[] woolwth = new int[51];  //1
        public int[] aloca = new int[51];    //2
        public int[] intshoe = new int[51];  //3
        public int[] j_i_case = new int[51]; //4
        public int[] maytag = new int[51];   //5
        public int[] gen_mills = new int[51]; //6
        public int[] am_motors = new int[51]; //7
        public int[] western_pub = new int[51]; //8

        public void Move(Board_Square b)
        {
            int x;
            //move the stock market to the new place
            if (b.direction == 1)
            {
                current_place -= b.move;
            }
            else
            {
                current_place += b.move;
            }
            //check if current_place is out of bounds
            if (current_place < 0)
            {
                for (x = 0; current_place < 0; x++)
                {
                    current_place++;
                }
                current_place += x;
            }
            if (current_place > 50)
            {
                for (x = 0; current_place > 50; x++)
                {
                    current_place--;
                }
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
            for (int x = 0; x < 51; x++)
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
            }
        } //done, calls fill because a new market was created
    }
}
