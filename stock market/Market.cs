using System;
using System.Collections.Generic;
using System.Text;

namespace stock_market
{
    public class Market
    {
        public int current_place;
        public int[] woolwth = new int[51];
        public int[] aloca = new int[51];
        public int[] intshoe = new int[51];
        public int[] j_i_case = new int[51];
        public int[] maytag = new int[51];
        public int[] gen_mills = new int[51];
        public int[] am_motors = new int[51];
        public int[] western_pub = new int[51];

        public int inc(int move, int direction)
        {
            int x;
            //move the stock market to the new place
            if (direction == 1)
            {
                this.current_place = this.current_place - move;
            }
            else
            {
                this.current_place = this.current_place + move;
            }
            //check if current_place is out of bounds
            if (this.current_place < 0)
            {
                for (x = 0; this.current_place < 0; x++)
                {
                    this.current_place++;
                }
                this.current_place = this.current_place + x;
            }
            if (this.current_place > 50)
            {
                for (x = 0; this.current_place > 50; x++)
                {
                    this.current_place--;
                }
                this.current_place = this.current_place - x;
            }
            return this.current_place;
        }
        public void show()
        {
            Console.WriteLine("Here is the Stocket Market right now: \n");
            Console.WriteLine("------------------\n");
            Console.WriteLine("Woolwth: {0}\n", this.woolwth[this.current_place]);
            Console.WriteLine("Aloca: {0}\n", this.aloca[this.current_place]);
            Console.WriteLine("Int Shoe: {0}\n", this.intshoe[this.current_place]);
            Console.WriteLine("J.I. Case: {0}\n", this.j_i_case[this.current_place]);
            Console.WriteLine("Maytag: {0}\n", this.maytag[this.current_place]);
            Console.WriteLine("Gen Mills: {0}\n", this.gen_mills[this.current_place]);
            Console.WriteLine("A.M. Motors: {0}\n", this.am_motors[this.current_place]);
            Console.WriteLine("Western Pub: {0}\n", this.western_pub[this.current_place]);
            Console.WriteLine("------------------\n\n");
        }
        public void fill()
        {
            this.current_place = 25;
            for (int x = 0; x < 51; x++)
            {
                this.woolwth[x] = 30 + (x * 4);
                this.aloca[x] = 230 - (x * 4);
                if (x == 0)
                {
                    this.intshoe[x] = 18;
                    this.gen_mills[x] = 42;
                }
                else if (x % 2 == 0)
                {
                    this.intshoe[x] = this.intshoe[x - 1] + 1;
                    this.gen_mills[x] = this.gen_mills[x - 1] - 1;
                }
                else
                {
                    this.intshoe[x] = this.intshoe[x - 1];
                    this.gen_mills[x] = this.gen_mills[x - 1];
                }
                if (x <= 20)
                {
                    this.maytag[x] = 15 + x;
                    this.j_i_case[x] = 75 - x;
                }
                else
                {
                    this.maytag[x] = this.maytag[x - 1] + 2;
                    this.j_i_case[x] = this.j_i_case[x - 1] - 2;
                }
                this.am_motors[x] = 110 - (x * 2);
                this.western_pub[x] = 10 + (x * 2);
            }
        }
        public Market()
        {
            fill();
        }
    }
}
