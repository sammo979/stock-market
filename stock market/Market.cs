using System;
using System.Collections.Generic;
using System.Text;

namespace stock_market
{
    public class Market
    {
        public int CurrentPlaceMarket = 25;
        public readonly int[] Woolwth = new int[51]{30,34,38,42,46,50,54,58,62,66,70,74,78,82,86,90,94,98,102,106,110,114,118,122,126,130,134,138,142,146,150,154,158,162,166,170,174,178,182,186,190,194,198,202,206,210,214,218,222,236,230};  //1
        public readonly int[] Aloca = new int[51]{230,226,222,218,214,210,206,202,198,194,190,186,182,178,174,170,166,162,158,154,150,146,142,138,134,130,126,122,118,114,110,106,102,98,94,90,86,82,78,74,70,66,62,58,54,50,46,42,38,34,30};    //2
        public readonly int[] IntShoe = new int[51]{18,18,19,19,20,20,21,21,22,22,23,23,24,24,25,25,26,26,27,27,28,28,29,29,30,30,30,31,31,32,32,33,33,34,34,35,35,36,36,37,37,38,38,39,39,40,40,41,41,42,42};  //3
        public readonly int[] JICase = new int[51]{75,74,73,72,71,70,69,68,67,66,65,64,63,62,61,60,59,58,57,56,55,53,51,49,47,45,43,41,39,37,35,34,33,32,31,30,29,28,27,26,25,24,23,22,21,20,19,18,17,16,15}; //4
        public readonly int[] Maytag = new int[51]{15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,37,39,41,43,45,47,49,51,53,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75};   //5
        public readonly int[] GenMills = new int[51]{42,42,41,41,40,40,39,39,38,38,37,37,36,36,35,35,34,34,33,33,32,32,31,31,30,30,30,29,29,28,28,27,27,26,26,25,25,24,24,23,23,22,22,21,21,20,20,19,19,18,18}; //6
        public readonly int[] AmMotors = new int[51]{110,108,106,104,102,100,98,96,94,92,90,88,86,84,82,80,78,76,74,72,70,68,66,64,62,60,58,56,54,52,50,48,46,44,42,40,38,36,34,32,30,28,26,24,22,20,18,16,14,12,10}; //7
        public readonly int[] WesternPub = new int[51]{10,12,14,16,18,20,22,24,26,28,30,32,34,36,38,40,42,44,46,48,50,52,54,56,58,60,62,64,66,68,70,72,74,76,78,80,82,84,86,88,90,92,94,96,98,100,102,104,106,108,110}; //8

        public void Move(Board_Square b)
        {
            int x;
            //move the stock market to the new place
            //down
            if (b.StockDirection == 1)
            {
                CurrentPlaceMarket += b.StockMove;
            }
            //up
            else
            {
                CurrentPlaceMarket -= b.StockMove;
            }
            //check if current_place is out of bounds
            if (CurrentPlaceMarket < 0)
            {
                x = CurrentPlaceMarket * -1;
                CurrentPlaceMarket = 0;
                CurrentPlaceMarket += x;
            }
            if (CurrentPlaceMarket > 50)
            {
                x = CurrentPlaceMarket - 50;
                CurrentPlaceMarket = 50;
                CurrentPlaceMarket -= x;
            }
            //debugging statment
            //Console.WriteLine("Stock Market current place is {0}.\n", CurrentPlaceMarket);
        } //done, move the current place of the stock market
        public int Find(int stockNameNum)
        {
            switch(stockNameNum)
            {
                case 1:
                    return Woolwth[CurrentPlaceMarket];
                case 2:
                    return Aloca[CurrentPlaceMarket];
                case 3:
                    return IntShoe[CurrentPlaceMarket];
                case 4:
                    return JICase[CurrentPlaceMarket];
                case 5:
                    return Maytag[CurrentPlaceMarket];
                case 6:
                    return GenMills[CurrentPlaceMarket];
                case 7:
                    return AmMotors[CurrentPlaceMarket];
                case 8:
                    return WesternPub[CurrentPlaceMarket];
                default:
                    Console.WriteLine("Enter wrong number!\n");
                    return -1;
            }
        }//returns the current price of the stock num you have given the function
        public int Find_base(int stockNameNum)
        {
            switch (stockNameNum)
            {
                case 1:
                    return Woolwth[0];
                 case 2:
                    return Aloca[50];
                case 3:
                    return IntShoe[0];
                case 4:
                    return JICase[50];
                case 5:
                    return Maytag[0];
                case 6:
                    return GenMills[50];
                case 7:
                    return AmMotors[50];
                case 8:
                    return WesternPub[0];
                default:
                    Console.WriteLine("Enter wrong number!\n");
                    return -1;
            }
        }
        public void Show()
        {
            Console.WriteLine("############################################\n");
            Console.WriteLine("#                                          #\n");
            Console.WriteLine("#  Here is the Stocket Market right now:   #\n");
            Console.WriteLine("#------------------------------------------#\n");
            Console.WriteLine("#              Woolwth:     {0}            #\n", Woolwth[CurrentPlaceMarket]);
            Console.WriteLine("#              Aloca:       {0}            #\n", Aloca[CurrentPlaceMarket]);
            Console.WriteLine("#              Int Shoe:    {0}            #\n", IntShoe[CurrentPlaceMarket]);
            Console.WriteLine("#              J.I. Case:   {0}            #\n", JICase[CurrentPlaceMarket]);
            Console.WriteLine("#              Maytag:      {0}            #\n", Maytag[CurrentPlaceMarket]);
            Console.WriteLine("#              Gen Mills:   {0}            #\n", GenMills[CurrentPlaceMarket]);
            Console.WriteLine("#              A.M. Motors: {0}            #\n", AmMotors[CurrentPlaceMarket]);
            Console.WriteLine("#              Western Pub: {0}            #\n", WesternPub[CurrentPlaceMarket]);
            Console.WriteLine("#------------------------------------------#\n");
            Console.WriteLine("############################################\n");
        } //done, shows the current price of each stock

    }
}
