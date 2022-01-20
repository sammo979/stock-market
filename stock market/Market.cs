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

        public void inc(int move, int direction)
        {
            int x;
            //move the stock market to the new place
            if (direction == 1)
            {
                current_place = current_place - move;
            }
            else
            {
                current_place = current_place + move;
            }
            //check if current_place is out of bounds
            if (current_place < 0)
            {
                for (x = 0; current_place < 0; x++)
                {
                    current_place++;
                }
                current_place = current_place + x;
            }
            if (current_place > 50)
            {
                for (x = 0; current_place > 50; x++)
                {
                    current_place--;
                }
                current_place = current_place - x;
            }
        } //done, move the current place of the stock market
        public int find(int stock_name_num)
        {
            int found;
            switch(stock_name_num)
            {
                case 1:
                    found = woolwth[current_place];
                    break;
                case 2:
                    found = aloca[current_place];
                    break;
                case 3:
                    found = intshoe[current_place];
                    break;
                case 4:
                    found = j_i_case[current_place];
                    break;
                case 5:
                    found = maytag[current_place];
                    break;
                case 6:
                    found = gen_mills[current_place];
                    break;
                case 7:
                    found = am_motors[current_place];
                    break;
                case 8:
                    found = western_pub[current_place];
                    break;
                default:
                    Console.WriteLine("Enter wrong number!\n");
                    found = -1;
                    break;
            }
            return found;
        }//returns the current price of the stock num you have given the function
        public void show()
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
        public void fill()
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
        } //done, fill the stock market with the right numbers at the start of the game
        public Market()
        {
            fill();
        } //done, calls fill because a new market was created
    }
}
