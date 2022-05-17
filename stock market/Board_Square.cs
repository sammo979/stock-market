using System;
using System.Collections.Generic;
using System.Text;

namespace stock_market
{
    public class Board_Square
    {
        public string Title; // the name or message of the square
        public string Description; // the details of the square
        public int Div; // the div that the person gets if they have the stock
        public int StockNameNum; // the number which corresponds to the stock name
        public int StockDirection; // 1 means down, 2 means up, for the stock market
        public int PlayerMovement; //1 means left, 2 means right, for player movement
        public int StockMove; // how much to move the stock market
        public int Meeting; // if the square allows for a meeting 1 for yes, -1 for no
        public int Type; // 1 if sell all square, 2 if pay broker fee, 3 if 100 fee
        public Stockholders_Meeting_Square Stockhold; //if the square has a stock holder meeting then this will have that track
        
        public void Show()
        {
            //display
            Console.WriteLine("Title: {0}\n",Title);
            Console.WriteLine("Description: {0}\n", Description);
            Console.WriteLine("Div: {0}\n",Div);
            Console.WriteLine("Direction: {0}\n", StockDirection);
            Console.WriteLine("Move: {0}\n", StockMove);
            Console.WriteLine("Movement: {0}\n",PlayerMovement);
            Console.WriteLine("Meeting: {0}\n",Meeting);
            
            /*// better looking show for players
            Console.WriteLine("#                                        #\n" +
                              "#                   {0}                  #\n" +
                              "#                   {1}                  #\n" +
                              "#                   {2}                  #\n" +
                              "#                                        #\n", Title, Description, Div);*/

        } 
        public Board_Square(int num)
        {
            switch(num)
            {
                case 1:
                    Title = "START\n";
                    Description = "Pay $100 FEE\n";
                    Div = -1;
                    StockNameNum = -1;
                    StockDirection = -1;
                    PlayerMovement = -1;
                    StockMove = 0;
                    Meeting = -1;
                    Type = 3;
                    break;
                case 2:
                    Title = "Woolworth\n";
                    Description = "None\n";
                    Div = 4;
                    StockNameNum = 1;
                    StockDirection = 1; //down
                    PlayerMovement = 1;
                    StockMove = 1;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 3:
                    Title = "Western Publishing\n";
                    Description = "None\n";
                    Div = 3;
                    StockNameNum = 8;
                    StockDirection = 2; //up
                    PlayerMovement = 1;
                    StockMove = 2;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 4:
                    Title = "Maytag\n";
                    Description = "Purchase Limit One Share\n";
                    Div = 2;
                    StockNameNum = 5;
                    StockDirection = 1; //down
                    PlayerMovement = 2;
                    StockMove = 3;
                    Meeting = 1;
                    Type = -1;
                    Stockhold = new Stockholders_Meeting_Square(5);
                    break;
                case 5:
                    Title = "Int. Shoe\n";
                    Description = "None\n";
                    Div = 1;
                    StockNameNum = 3;
                    StockDirection = 2; //up
                    PlayerMovement = 2;
                    StockMove = 4;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 6:
                    Title = "J.I. Case\n";
                    Description = "Sell all, At $15 Per Share\n";
                    Div = -1;
                    StockNameNum = 4;
                    StockDirection = 1; //down
                    PlayerMovement = 2;
                    StockMove = 5;
                    Meeting = -1;
                    Type = 1;
                    break;
                case 7:
                    Title = "Pay - Broker Fee $10 Per Share\n";
                    Description = "None\n";
                    Div = -2;
                    StockNameNum = -2;
                    StockDirection = 1; //down
                    PlayerMovement = 2;
                    StockMove = 20;
                    Meeting = -2;
                    Type = 2;
                    break;
                case 8:
                    Title = "Western Publishing\n";
                    Description = "Sell All, At $10 Per Share\n";
                    Div = -1;
                    StockNameNum = 8;
                    StockDirection = 2; //up
                    PlayerMovement = 1;
                    StockMove = 5;
                    Meeting = -1;
                    Type = 1;
                    break;
                case 9:
                    Title = "Alcoa\n";
                    Description = "None\n";
                    Div = 4;
                    StockNameNum = 2;
                    StockDirection = 1; //down
                    PlayerMovement = 1;
                    StockMove = 4;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 10:
                    Title = "A.M. Motors\n";
                    Description = "Purchase Limit One Share\n";
                    Div = 3;
                    StockNameNum = 7;
                    StockDirection = 2; //up
                    PlayerMovement = 1;
                    StockMove = 3;
                    Meeting = 1;
                    Stockhold = new Stockholders_Meeting_Square(7);
                    Type = -1;
                    break;
                case 11:
                    Title = "Maytag\n";
                    Description = "None\n";
                    Div = 2;
                    StockNameNum = 5;
                    StockDirection = 1; //down
                    PlayerMovement = 1;
                    StockMove = 2;
                    Meeting = -1;
                    break;
                case 12:
                    Title = "Gen. Mills\n";
                    Description = "None\n";
                    Div = 1;
                    StockNameNum = 6;
                    StockDirection = 2; //up
                    PlayerMovement = 1;
                    StockMove = 1;
                    Meeting = -1;
                    break;
                case 13:
                    Title = "Start\n";
                    Description = "Pay $100 Fee\n";
                    Div = -1;
                    StockNameNum = -1;
                    StockDirection = -1;
                    PlayerMovement = -1;
                    StockMove = 0;
                    Meeting = -1;
                    Type = 3;
                    break;
                case 14:
                    Title = "Int. Shoe\n";
                    Description = "None\n";
                    Div = 1;
                    StockNameNum = 3;
                    StockDirection = 2;//up
                    PlayerMovement = 1;
                    StockMove = 1;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 15:
                    Title = "J.I. Case\n";
                    Description = "None\n";
                    Div = 2;
                    StockNameNum = 4;
                    StockDirection = 1;//down
                    PlayerMovement = 1;
                    StockMove = 2;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 16:
                    Title = "Western Publishing\n";
                    Description = "Purchase Limit One Share\n";
                    Div = 3;
                    StockNameNum = 8;
                    StockDirection = 2;//up
                    PlayerMovement = 2;
                    StockMove = 3;
                    Meeting = 1;
                    Stockhold = new Stockholders_Meeting_Square(8);
                    Type = -1;
                    break;
                case 17:
                    Title = "Woolworth\n";
                    Description = "None\n";
                    Div = 4;
                    StockNameNum = 1;
                    StockDirection = 1;//down
                    PlayerMovement = 2;
                    StockMove = 4;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 18:
                    Title = "A.M. Motors\n";
                    Description = "Sell All, At $10 Per Share\n";
                    Div = -1;
                    StockNameNum = 7;
                    StockDirection = 2;//up
                    PlayerMovement = 2;
                    StockMove = 5;
                    Meeting = -1;
                    Type = 1;
                    break;
                case 19:
                    Title = "Pay Broker Fee $10 Per Share\n";
                    Description = "None\n";
                    Div = -2;
                    StockNameNum = -2;
                    StockDirection = 2;//up
                    PlayerMovement = 2;
                    StockMove = 20;
                    Meeting = -2;
                    Type = 2;
                    break;
                case 20:
                    Title = "Int. Shoe\n";
                    Description = "Sell All, At $18 Per Share\n";
                    Div = -1;
                    StockNameNum = 3;
                    StockDirection = 1;//down
                    PlayerMovement = 1;
                    StockMove = 5;
                    Meeting = -1;
                    Type = 1;
                    break;
                case 21:
                    Title = "Maytag\n";
                    Description = "None\n";
                    Div = 2;
                    StockNameNum = 5;
                    StockDirection = 2;//up
                    PlayerMovement = 1;
                    StockMove = 4;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 22:
                    Title = "Gen. Mills\n";
                    Description = "Purchase Limit One Share\n";
                    Div = 1;
                    StockNameNum = 6;
                    StockDirection = 1;//down
                    PlayerMovement = 1; //left
                    StockMove = 3;
                    Meeting = 1;
                    Stockhold = new Stockholders_Meeting_Square(6);
                    Type = -1;
                    break;
                case 23:
                    Title = "Alcoa\n";
                    Description = "None\n";
                    Div = 4;
                    StockNameNum = 2;
                    StockDirection = 2;//up
                    PlayerMovement = 1;//left
                    StockMove = 2;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 24:
                    Title = "A.M. Motors\n";
                    Description = "None\n";
                    Div = 3;
                    StockNameNum = 7;
                    StockDirection = 1;//down
                    PlayerMovement = 1;
                    StockMove = 1;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 25:
                    Title = "Start\n";
                    Description = "Pay $100 Fee\n";
                    Div = -1;
                    StockNameNum = -1;
                    StockDirection = -1;
                    PlayerMovement = -1;
                    StockMove = 0;
                    Meeting = -1;
                    Type = 3;
                    break;
                case 26:
                    Title = "Western Publishing\n";
                    Description = "None\n";
                    Div = 3;
                    StockNameNum = 8;
                    StockDirection = 1;//down
                    PlayerMovement = 1;
                    StockMove = 1;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 27:
                    Title = "Woolworth\n";
                    Description = "None\n";
                    Div = 4;
                    StockNameNum = 1;
                    StockDirection = 2;//up
                    PlayerMovement = 1;
                    StockMove = 2;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 28:
                    Title = "Int. Shoe\n";
                    Description = "Purchase Limit One Share\n";
                    Div = 1;
                    StockNameNum = 3;
                    StockDirection = 1;//down
                    PlayerMovement = 2;
                    StockMove = 3;
                    Meeting = 1;
                    Stockhold = new Stockholders_Meeting_Square(3);
                    Type = -1;
                    break;
                case 29:
                    Title = "J.I. Case\n";
                    Description = "None\n";
                    Div = 2;
                    StockNameNum = 4;
                    StockDirection = 2;//up
                    PlayerMovement = 2;
                    StockMove = 4;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 30:
                    Title = "Gen. Mills\n";
                    Description = "Sell All, At $18 Per Share\n";
                    Div = -1;
                    StockNameNum = 6;
                    StockDirection = 1;//down
                    PlayerMovement = 2;
                    StockMove = 5;
                    Meeting = -1;
                    Type = 1;
                    break;
                case 31:
                    Title = "Pay Broker Fee $10 Per Share\n";
                    Description = "None\n";
                    Div = -2;
                    StockNameNum = -2;
                    StockDirection = 1;//down
                    PlayerMovement = 2;
                    StockMove = 20;
                    Meeting = -2;
                    Type = 2;
                    break;
                case 32:
                    Title = "Aloca\n";
                    Description = "Sell All, At $30 Per Share\n";
                    Div = -1;
                    StockNameNum = 2;
                    StockDirection = 2;//up
                    PlayerMovement = 1;
                    StockMove = 5;
                    Meeting = -1;
                    Type = 1;
                    break;
                case 33:
                    Title = "Western Publishing\n";
                    Description = "None\n";
                    Div = 3;
                    StockNameNum = 8;
                    StockDirection = 1;//down
                    PlayerMovement = 1;
                    StockMove = 4;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 34:
                    Title = "Woolworth\n";
                    Description = "Purchase Limit One Share\n";
                    Div = 4;
                    StockNameNum = 1;
                    StockDirection = 2;//up
                    PlayerMovement = 1;
                    StockMove = 3;
                    Meeting = 1;
                    Stockhold = new Stockholders_Meeting_Square(1);
                    Type = -1;
                    break;
                case 35:
                    Title = "Int. Shoe\n";
                    Description = "None\n";
                    Div = 1;
                    StockNameNum = 3;
                    StockDirection = 1;//down
                    PlayerMovement = 1;
                    StockMove = 2;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 36:
                    Title = "J.I. Case\n";
                    Description = "None\n";
                    Div = 2;
                    StockNameNum = 4;
                    StockDirection = 2;//up
                    PlayerMovement = 1;
                    StockMove = 1;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 37:
                    Title = "Start\n";
                    Description = "Pay $100 Fee\n";
                    Div = -1;
                    StockNameNum = -1;
                    StockDirection = -1;
                    PlayerMovement = -1;
                    StockMove = 0;
                    Meeting = -1;
                    Type = 3;
                    break;
                case 38:
                    Title = "Maytag\n";
                    Description = "None\n";
                    Div = 2;
                    StockNameNum = 5;
                    StockDirection = 2;//up
                    PlayerMovement = 1;
                    StockMove = 1;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 39:
                    Title = "Gen. Mills\n";
                    Description = "None\n";
                    Div = 1;
                    StockNameNum = 6;
                    StockDirection = 1;//down
                    PlayerMovement = 1;
                    StockMove = 2;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 40:
                    Title = "Alcoa\n";
                    Description = "Purchase Limit One Share\n";
                    Div = 4;
                    StockNameNum = 2;
                    StockDirection = 2;//up
                    PlayerMovement = 2;
                    StockMove = 3;
                    Meeting = 1;
                    Stockhold = new Stockholders_Meeting_Square(2);
                    Type = -1;
                    break;
                case 41:
                    Title = "A.M. Motors\n";
                    Description = "None\n";
                    Div = 3;
                    StockNameNum = 7;
                    StockDirection = 1;//down
                    PlayerMovement = 2;
                    StockMove = 4;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 42:
                    Title = "Sell All Woolworth - At $30 Per Share\n";
                    Description = "Sell All, At $30 Per Share\n";
                    Div = -1;
                    StockNameNum = 1;
                    StockDirection = 2;//up
                    PlayerMovement = 2;
                    StockMove = 5;
                    Meeting = -1;
                    Type = 1;
                    break;
                case 43:
                    Title = "Pay Broker Fee $10 Per Share\n";
                    Description = "None\n";
                    Div = -2;
                    StockNameNum = -2;
                    StockDirection = 2;//up
                    PlayerMovement = 2;
                    StockMove = 20;
                    Meeting = -2;
                    Type = 2;
                    break;
                case 44:
                    Title = "Maytag\n";
                    Description = "Sell All, At $15 Per Share\n";
                    Div = -1;
                    StockNameNum = 5;
                    StockDirection = 1;//down
                    PlayerMovement = 1;
                    StockMove = 5;
                    Meeting = -1;
                    Type = 1;
                    break;
                case 45:
                    Title = "Gen. Mills\n";
                    Description = "None\n";
                    Div = 1;
                    StockNameNum = 6;
                    StockDirection = 2;//up
                    PlayerMovement = 1;
                    StockMove = 4;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 46:
                    Title = "J.I. Case\n";
                    Description = "Purchase Limit One Share\n";
                    Div = 2;
                    StockNameNum = 4;
                    StockDirection = 1;//down
                    PlayerMovement = 1;
                    StockMove = 3;
                    Meeting = 1;
                    Stockhold = new Stockholders_Meeting_Square(4);
                    Type = -1;
                    break;
                case 47:
                    Title = "A.M. Motors\n";
                    Description = "None\n";
                    Div = 3;
                    StockNameNum = 7;
                    StockDirection = 2;//up
                    PlayerMovement = 1;
                    StockMove = 2;
                    Meeting = -1;
                    Type = -1;
                    break;
                case 48:
                    Title = "Alcoa\n";
                    Description = "None\n";
                    Div = 4;
                    StockNameNum = 2;
                    StockDirection = 1;//down
                    PlayerMovement = 1;
                    StockMove = 1;
                    Meeting = -1;
                    Type = -1;
                    break;
                default:
                    Console.WriteLine("Error\n");
                    break;
            }
        } //filling the board square with the right information at the start, when a Board square is created


    }
}
