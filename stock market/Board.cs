using System;
using System.Collections.Generic;
using System.Text;

namespace stock_market
{
    public class Board_Square
    {
        public string title; // the name or message of the square
        public string description; // the details of the square
        public int div; // the div that the person gets if they have the stock
        public int stock_name_num; // the number which corresponds to the stock name
        public int direction; // 1 means down, 2 means up, for the stock market
        public int movement; //1 means left, 2 means right, for player movement
        public int move; // how much to move the stock market
        public int meeting; // if the square allows for a meeting 1 for yes, -1 for no
        public int unqiue; // 1 if sell all square, 2 if pay broker fee, 3 if 100 fee
        public Stockholders_Meeting stockhold; //if the square has a stock holder meeting then this will have that track
        
        public void Show()
        {
            Console.WriteLine("Title: {0}\n",title);
            Console.WriteLine("Description: {0}\n", description);
            Console.WriteLine("Div: {0}\n",div);
            Console.WriteLine("Direction: {0}\n", direction);
            Console.WriteLine("Move: {0}\n",move);
            Console.WriteLine("Movement: {0}\n",movement);
            Console.WriteLine("Meeting: {0}\n",meeting);
        } //need to convert most things to words for the players to be able to read,
          //right now it is showing numbers which the computer can read and manage
        public Board_Square(int num)
        {
            switch(num)
            {
                case 1:
                    title = "START\n";
                    description = "Pay $100 FEE\n";
                    div = -1;
                    stock_name_num = -1;
                    direction = -1;
                    movement = -1;
                    move = 0;
                    meeting = -1;
                    unqiue = 3;
                    break;
                case 2:
                    title = "Woolworth\n";
                    description = "None\n";
                    div = 4;
                    stock_name_num = 1;
                    direction = 1; //down
                    movement = 1;
                    move = 1;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 3:
                    title = "Western Publishing\n";
                    description = "None\n";
                    div = 3;
                    stock_name_num = 8;
                    direction = 2; //up
                    movement = 1;
                    move = 2;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 4:
                    title = "Maytag\n";
                    description = "Purchase Limit One Share\n";
                    div = 2;
                    stock_name_num = 5;
                    direction = 1; //down
                    movement = 2;
                    move = 3;
                    meeting = 1;
                    unqiue = -1;
                    stockhold = new Stockholders_Meeting(5);
                    break;
                case 5:
                    title = "Int. Shoe\n";
                    description = "None\n";
                    div = 1;
                    stock_name_num = 3;
                    direction = 2; //up
                    movement = 2;
                    move = 4;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 6:
                    title = "J.I. Case\n";
                    description = "Sell all, At $15 Per Share\n";
                    div = -1;
                    stock_name_num = 4;
                    direction = 1; //down
                    movement = 2;
                    move = 5;
                    meeting = -1;
                    unqiue = 1;
                    break;
                case 7:
                    title = "Pay - Broker Fee $10 Per Share\n";
                    description = "None\n";
                    div = -2;
                    stock_name_num = -2;
                    direction = 1; //down
                    movement = 2;
                    move = 20;
                    meeting = -2;
                    unqiue = 2;
                    break;
                case 8:
                    title = "Western Publishing\n";
                    description = "Sell All, At $10 Per Share\n";
                    div = -1;
                    stock_name_num = 8;
                    direction = 2; //up
                    movement = 1;
                    move = 5;
                    meeting = -1;
                    unqiue = 1;
                    break;
                case 9:
                    title = "Alcoa\n";
                    description = "None\n";
                    div = 4;
                    stock_name_num = 2;
                    direction = 1; //down
                    movement = 1;
                    move = 4;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 10:
                    title = "A.M. Motors\n";
                    description = "Purchase Limit One Share\n";
                    div = 3;
                    stock_name_num = 7;
                    direction = 2; //up
                    movement = 1;
                    move = 3;
                    meeting = 1;
                    stockhold = new Stockholders_Meeting(7);
                    unqiue = -1;
                    break;
                case 11:
                    title = "Maytag\n";
                    description = "None\n";
                    div = 2;
                    stock_name_num = 5;
                    direction = 1; //down
                    movement = 1;
                    move = 2;
                    meeting = -1;
                    break;
                case 12:
                    title = "Gen. Mills\n";
                    description = "None\n";
                    div = 1;
                    stock_name_num = 6;
                    direction = 2; //up
                    movement = 1;
                    move = 1;
                    meeting = -1;
                    break;
                case 13:
                    title = "Start\n";
                    description = "Pay $100 Fee\n";
                    div = -1;
                    stock_name_num = -1;
                    direction = -1;
                    movement = -1;
                    move = 0;
                    meeting = -1;
                    unqiue = 3;
                    break;
                case 14:
                    title = "Int. Shoe\n";
                    description = "None\n";
                    div = 1;
                    stock_name_num = 3;
                    direction = 2;//up
                    movement = 1;
                    move = 1;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 15:
                    title = "J.I. Case\n";
                    description = "None\n";
                    div = 2;
                    stock_name_num = 4;
                    direction = 1;//down
                    movement = 1;
                    move = 2;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 16:
                    title = "Western Publishing\n";
                    description = "Purchase Limit One Share\n";
                    div = 3;
                    stock_name_num = 8;
                    direction = 2;//up
                    movement = 2;
                    move = 3;
                    meeting = 1;
                    stockhold = new Stockholders_Meeting(8);
                    unqiue = -1;
                    break;
                case 17:
                    title = "Woolworth\n";
                    description = "None\n";
                    div = 4;
                    stock_name_num = 1;
                    direction = 1;//down
                    movement = 2;
                    move = 4;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 18:
                    title = "A.M. Motors\n";
                    description = "Sell All, At $10 Per Share\n";
                    div = -1;
                    stock_name_num = 7;
                    direction = 2;//up
                    movement = 2;
                    move = 5;
                    meeting = -1;
                    unqiue = 1;
                    break;
                case 19:
                    title = "Pay Broker Fee $10 Per Share\n";
                    description = "None\n";
                    div = -2;
                    stock_name_num = -2;
                    direction = 2;//up
                    movement = 2;
                    move = 20;
                    meeting = -2;
                    unqiue = 2;
                    break;
                case 20:
                    title = "Int. Shoe\n";
                    description = "Sell All, At $18 Per Share\n";
                    div = -1;
                    stock_name_num = 3;
                    direction = 1;//down
                    movement = 1;
                    move = 5;
                    meeting = -1;
                    unqiue = 1;
                    break;
                case 21:
                    title = "Maytag\n";
                    description = "None\n";
                    div = 2;
                    stock_name_num = 5;
                    direction = 2;//up
                    movement = 1;
                    move = 4;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 22:
                    title = "Gen. Mills\n";
                    description = "Purchase Limit One Share\n";
                    div = 1;
                    stock_name_num = 6;
                    direction = 1;//down
                    movement = 1; //left
                    move = 3;
                    meeting = 1;
                    stockhold = new Stockholders_Meeting(6);
                    unqiue = -1;
                    break;
                case 23:
                    title = "Alcoa\n";
                    description = "None\n";
                    div = 4;
                    stock_name_num = 2;
                    direction = 2;//up
                    movement = 1;//left
                    move = 2;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 24:
                    title = "A.M. Motors\n";
                    description = "None\n";
                    div = 3;
                    stock_name_num = 7;
                    direction = 1;//down
                    movement = 1;
                    move = 1;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 25:
                    title = "Start\n";
                    description = "Pay $100 Fee\n";
                    div = -1;
                    stock_name_num = -1;
                    direction = -1;
                    movement = -1;
                    move = 0;
                    meeting = -1;
                    unqiue = 3;
                    break;
                case 26:
                    title = "Western Publishing\n";
                    description = "None\n";
                    div = 3;
                    stock_name_num = 8;
                    direction = 1;//down
                    movement = 1;
                    move = 1;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 27:
                    title = "Woolworth\n";
                    description = "None\n";
                    div = 4;
                    stock_name_num = 1;
                    direction = 2;//up
                    movement = 1;
                    move = 2;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 28:
                    title = "Int. Shoe\n";
                    description = "Purchase Limit One Share\n";
                    div = 1;
                    stock_name_num = 3;
                    direction = 1;//down
                    movement = 2;
                    move = 3;
                    meeting = 1;
                    stockhold = new Stockholders_Meeting(3);
                    unqiue = -1;
                    break;
                case 29:
                    title = "J.I. Case\n";
                    description = "None\n";
                    div = 2;
                    stock_name_num = 4;
                    direction = 2;//up
                    movement = 2;
                    move = 4;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 30:
                    title = "Gen. Mills\n";
                    description = "Sell All, At $18 Per Share\n";
                    div = -1;
                    stock_name_num = 6;
                    direction = 1;//down
                    movement = 2;
                    move = 5;
                    meeting = -1;
                    unqiue = 1;
                    break;
                case 31:
                    title = "Pay Broker Fee $10 Per Share\n";
                    description = "None\n";
                    div = -2;
                    stock_name_num = -2;
                    direction = 1;//down
                    movement = 2;
                    move = 20;
                    meeting = -2;
                    unqiue = 2;
                    break;
                case 32:
                    title = "Aloca\n";
                    description = "Sell All, At $30 Per Share\n";
                    div = -1;
                    stock_name_num = 2;
                    direction = 2;//up
                    movement = 1;
                    move = 5;
                    meeting = -1;
                    unqiue = 1;
                    break;
                case 33:
                    title = "Western Publishing\n";
                    description = "None\n";
                    div = 3;
                    stock_name_num = 8;
                    direction = 1;//down
                    movement = 1;
                    move = 4;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 34:
                    title = "Woolworth\n";
                    description = "Purchase Limit One Share\n";
                    div = 4;
                    stock_name_num = 1;
                    direction = 2;//up
                    movement = 1;
                    move = 3;
                    meeting = 1;
                    stockhold = new Stockholders_Meeting(1);
                    unqiue = -1;
                    break;
                case 35:
                    title = "Int. Shoe\n";
                    description = "None\n";
                    div = 1;
                    stock_name_num = 3;
                    direction = 1;//down
                    movement = 1;
                    move = 2;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 36:
                    title = "J.I. Case\n";
                    description = "None\n";
                    div = 2;
                    stock_name_num = 4;
                    direction = 2;//up
                    movement = 1;
                    move = 1;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 37:
                    title = "Start\n";
                    description = "Pay $100 Fee\n";
                    div = -1;
                    stock_name_num = -1;
                    direction = -1;
                    movement = -1;
                    move = 0;
                    meeting = -1;
                    unqiue = 3;
                    break;
                case 38:
                    title = "Maytag\n";
                    description = "None\n";
                    div = 2;
                    stock_name_num = 5;
                    direction = 2;//up
                    movement = 1;
                    move = 1;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 39:
                    title = "Gen. Mills\n";
                    description = "None\n";
                    div = 1;
                    stock_name_num = 6;
                    direction = 1;//down
                    movement = 1;
                    move = 2;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 40:
                    title = "Alcoa\n";
                    description = "Purchase Limit One Share\n";
                    div = 4;
                    stock_name_num = 2;
                    direction = 2;//up
                    movement = 2;
                    move = 3;
                    meeting = 1;
                    stockhold = new Stockholders_Meeting(2);
                    unqiue = -1;
                    break;
                case 41:
                    title = "A.M. Motors\n";
                    description = "None\n";
                    div = 3;
                    stock_name_num = 7;
                    direction = 1;//down
                    movement = 2;
                    move = 4;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 42:
                    title = "Sell All Woolworth - At $30 Per Share\n";
                    description = "Sell All, At $30 Per Share\n";
                    div = -1;
                    stock_name_num = 1;
                    direction = 2;//up
                    movement = 2;
                    move = 5;
                    meeting = -1;
                    unqiue = 1;
                    break;
                case 43:
                    title = "Pay Broker Fee $10 Per Share\n";
                    description = "None\n";
                    div = -2;
                    stock_name_num = -2;
                    direction = 2;//up
                    movement = 2;
                    move = 20;
                    meeting = -2;
                    unqiue = 2;
                    break;
                case 44:
                    title = "Maytag\n";
                    description = "Sell All, At $15 Per Share\n";
                    div = -1;
                    stock_name_num = 5;
                    direction = 1;//down
                    movement = 1;
                    move = 5;
                    meeting = -1;
                    unqiue = 1;
                    break;
                case 45:
                    title = "Gen. Mills\n";
                    description = "None\n";
                    div = 1;
                    stock_name_num = 6;
                    direction = 2;//up
                    movement = 1;
                    move = 4;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 46:
                    title = "J.I. Case\n";
                    description = "Purchase Limit One Share\n";
                    div = 2;
                    stock_name_num = 4;
                    direction = 1;//down
                    movement = 1;
                    move = 3;
                    meeting = 1;
                    stockhold = new Stockholders_Meeting(4);
                    unqiue = -1;
                    break;
                case 47:
                    title = "A.M. Motors\n";
                    description = "None\n";
                    div = 3;
                    stock_name_num = 7;
                    direction = 2;//up
                    movement = 1;
                    move = 2;
                    meeting = -1;
                    unqiue = -1;
                    break;
                case 48:
                    title = "Alcoa\n";
                    description = "None\n";
                    div = 4;
                    stock_name_num = 2;
                    direction = 1;//down
                    movement = 1;
                    move = 1;
                    meeting = -1;
                    unqiue = -1;
                    break;
                default:
                    Console.WriteLine("Error\n");
                    break;
            }
        } //filling the board square with the right information at the start, when a Board square is created


    }
}
