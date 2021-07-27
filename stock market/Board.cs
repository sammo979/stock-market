using System;
using System.Collections.Generic;
using System.Text;

namespace stock_market
{
    public class Board
    {
        public string title;
        public int div;
        public int stock_name_num;
        public int direction;
        public int movement;
        public int move;
        public int meeting;
        public Board left;
        public Board right;
        public Board(int num)
        {
            switch(num)
            {
                case 1:
                    this.title = "START - Pay $100 FEE\n";
                    this.div = -1;
                    this.stock_name_num = -1;
                    this.direction = -1;
                    this.movement = -1;
                    this.move = -1;
                    this.meeting = -1;
                    break;
                case 2:
                    this.title = "Woolworth\n";
                    this.div = 4;
                    this.stock_name_num = 1;
                    this.direction = 1;
                    this.movement = 1;
                    this.move = 1;
                    this.meeting = 1;
                    break;
                case 3:
                    this.title = "Western Publishing\n";
                    this.div = 2;
                    this.stock_name_num = 2;
                    this.direction = 2;
                    this.movement = 1;
                    this.move = 2;
                    this.meeting = -1;
                    break;
                case 4:
                    this.title = "Maytag - Purchase Limit One Share\n";
                    this.div = 2;
                    this.stock_name_num = 3;
                    this.direction = 1;
                    this.movement = 2;
                    this.move = 3;
                    this.meeting = 1;
                    break;
                case 5:
                    this.title = "Int. Shoe\n";
                    this.div = 1;
                    this.stock_name_num = 4;
                    this.direction = 2;
                    this.movement = 2;
                    this.move = 4;
                    this.meeting = -1;
                    break;
                case 6:
                    this.title = "Int. Shoe\n";
                    this.div = 1;
                    this.stock_name_num = 4;
                    this.direction = 2;
                    this.movement = 2;
                    this.move = 4;
                    this.meeting = -1;
                    break;
                case 7:
                    this.title = "Sell all J.I. Case - At $15 Per Share\n";
                    this.div = -1;
                    this.stock_name_num = 5;
                    this.direction = 1;
                    this.movement = 2;
                    this.move = 5;
                    this.meeting = -1;
                    break;
                case 8:
                    this.title = "Pay - Broker Fee $10 Per Share\n";
                    this.div = -2;
                    this.stock_name_num = -2;
                    this.direction = 1;
                    this.movement = 2;
                    this.move = 20;
                    this.meeting = -2;
                    break;
                case 9:
                    this.title = "Sell All Western Publishing - At $10 Per Share\n";
                    this.div = -1;
                    this.stock_name_num = 2;
                    this.direction = 1;
                    this.movement = 1;
                    this.move = 5;
                    this.meeting = -1;
                    break;
                case 10:
                    this.title = "Aloca\n";
                    this.div = 4;
                    this.stock_name_num = 6;
                    this.direction = 1;
                    this.movement = 1;
                    this.move = 4;
                    this.meeting = -1;
                    break;
                case 11:
                    this.title = "A.M. Motors - Purchase Limit One Share\n";
                    this.div = 3;
                    this.stock_name_num = 7;
                    this.direction = 2;
                    this.movement = 1;
                    this.move = 3;
                    this.meeting = 1;
                    break;
                case 12:
                    this.title = "Maytag\n";
                    this.div = 2;
                    this.stock_name_num = 3;
                    this.direction = 1;
                    this.movement = 1;
                    this.move = 2;
                    this.meeting = -1;
                    break;
                case 13:
                    this.title = "Gen. Mills\n";
                    this.div = 1;
                    this.stock_name_num = 8;
                    this.direction = 2;
                    this.movement = 1;
                    this.move = 1;
                    this.meeting = -1;
                    break;
                case 14:
                    this.title = "Start - Pay $100 Fee\n";
                    this.div = -1;
                    this.stock_name_num = -1;
                    this.direction = -1;
                    this.movement = -1;
                    this.move = -1;
                    this.meeting = -1;
                    break;
                case 15:
                    this.title = "Int. Shoe\n";
                    this.div = 1;
                    this.stock_name_num = 5;
                    this.direction = 2;
                    this.movement = 1;
                    this.move = 1;
                    this.meeting = -1;
                    break;
                case 16:
                    this.title = "J.I. Case\n";
                    this.div = 2;
                    this.stock_name_num = 5;
                    this.direction = 1;
                    this.movement = 1;
                    this.move = 2;
                    this.meeting = -1;
                    break;
                case 17:
                    this.title = "Western Publishing  - Purchase Limit One Share\n";
                    this.div = 3;
                    this.stock_name_num = 2;
                    this.direction = 2;
                    this.movement = 2;
                    this.move = 3;
                    this.meeting = 1;
                    break;
                case 18:
                    this.title = "Woolworth\n";
                    this.div = 4;
                    this.stock_name_num = 1;
                    this.direction = 1;
                    this.movement = 2;
                    this.move = 4;
                    this.meeting = -1;
                    break;
                case 19:
                    this.title = "Sell All A.M. Motors - At $10 Per Share\n";
                    this.div = -1;
                    this.stock_name_num = 7;
                    this.direction = 2;
                    this.movement = 2;
                    this.move = 5;
                    this.meeting = -1;
                    break;
                case 20:
                    this.title = "Pay Broker Fee $10 Per Share\n";
                    this.div = -2;
                    this.stock_name_num = -2;
                    this.direction = 2;
                    this.movement = 2;
                    this.move = 20;
                    this.meeting = -2;
                    break;
                case 21:
                    this.title = "Sell All Int. Shoe - At $18 Per Share\n";
                    this.div = -1;
                    this.stock_name_num = 4;
                    this.direction = 1;
                    this.movement = 1;
                    this.move = 5;
                    this.meeting = -1;
                    break;
                case 22:
                    this.title = "Maytag\n";
                    this.div = 2;
                    this.stock_name_num = 3;
                    this.direction = 2;
                    this.movement = 1;
                    this.move = 4;
                    this.meeting = -1;
                    break;
                case 23:
                    this.title = "Gen. Mills - Purchase Limit One Share\n";
                    this.div = 1;
                    this.stock_name_num = 8;
                    this.direction = 1;
                    this.movement = 1;
                    this.move = 3;
                    this.meeting = 1;
                    break;
                case 24:
                    this.title = "Aloca\n";
                    this.div = 4;
                    this.stock_name_num = 6;
                    this.direction = 2;
                    this.movement = 1;
                    this.move = 2;
                    this.meeting = -1;
                    break;
                case 25:
                    this.title = "A.M. Motors\n";
                    this.div = 3;
                    this.stock_name_num = 7;
                    this.direction = 1;
                    this.movement = 1;
                    this.move = 1;
                    this.meeting = -1;
                    break;
                case 26:
                    this.title = "Start - Pay $100 Fee\n";
                    this.div = -1;
                    this.stock_name_num = -1;
                    this.direction = -1;
                    this.movement = -1;
                    this.move = -1;
                    this.meeting = -1;
                    break;
                case 27:
                    this.title = "Western Publishing\n";
                    this.div = 3;
                    this.stock_name_num = 2;
                    this.direction = 1;
                    this.movement = 1;
                    this.move = 1;
                    this.meeting = -1;
                    break;
                case 28:
                    this.title = "Woolworth\n";
                    this.div = 4;
                    this.stock_name_num = 1;
                    this.direction = 2;
                    this.movement = 1;
                    this.move = 2;
                    this.meeting = -1;
                    break;
                case 29:
                    this.title = "Int. Shoe - Purchase Limit One Share\n";
                    this.div = 2;
                    this.stock_name_num = 4;
                    this.direction = 1;
                    this.movement = 2;
                    this.move = 3;
                    this.meeting = 1;
                    break;
                case 30:
                    this.title = "J.I. Case\n";
                    this.div = 2;
                    this.stock_name_num = 5;
                    this.direction = 2;
                    this.movement = 2;
                    this.move = 4;
                    this.meeting = -1;
                    break;
                case 31:
                    this.title = "Sell all Gen. Mills - at $18 Per Share\n";
                    this.div = -1;
                    this.stock_name_num = 8;
                    this.direction = 1;
                    this.movement = 2;
                    this.move = 5;
                    this.meeting = -1;
                    break;
                case 32:
                    this.title = "Pay Broker Fee $10 Per Share\n";
                    this.div = -2;
                    this.stock_name_num = -2;
                    this.direction = 1;
                    this.movement = 2;
                    this.move = 20;
                    this.meeting = -2;
                    break;
                case 33:
                    this.title = "Sell All Aloca - At $30 Per Share\n";
                    this.div = -1;
                    this.stock_name_num = 6;
                    this.direction = 2;
                    this.movement = 1;
                    this.move = 3;
                    this.meeting = -1;
                    break;
                case 34:
                    this.title = "Western Publishing\n";
                    this.div = 3;
                    this.stock_name_num = 2;
                    this.direction = 1;
                    this.movement = 1;
                    this.move = 4;
                    this.meeting = -1;
                    break;
                case 35:
                    this.title = "Woolworth - Purchase Limit One Share\n";
                    this.div = 4;
                    this.stock_name_num = 1;
                    this.direction = 2;
                    this.movement = 1;
                    this.move = 3;
                    this.meeting = 1;
                    break;
                case 36:
                    this.title = "Int. Shoe\n";
                    this.div = 1;
                    this.stock_name_num = 4;
                    this.direction = 1;
                    this.movement = 1;
                    this.move = 2;
                    this.meeting = -1;
                    break;
                case 37:
                    this.title = "J.I. Case\n";
                    this.div = 2;
                    this.stock_name_num = 5;
                    this.direction = 2;
                    this.movement = 1;
                    this.move = 1;
                    this.meeting = -1;
                    break;
                case 38:
                    this.title = "Start - Pay $100 Fee\n";
                    this.div = -1;
                    this.stock_name_num = -1;
                    this.direction = -1;
                    this.movement = -1;
                    this.move = -1;
                    this.meeting = -1;
                    break;
                case 39:
                    this.title = "Maytag\n";
                    this.div = 2;
                    this.stock_name_num = 3;
                    this.direction = 2;
                    this.movement = 1;
                    this.move = 1;
                    this.meeting = -1;
                    break;
                case 40:
                    this.title = "Gen. Mills\n";
                    this.div = 1;
                    this.stock_name_num = 1;
                    this.direction = 1;
                    this.movement = 1;
                    this.move = 2;
                    this.meeting = -1;
                    break;
                case 41:
                    this.title = "Aloca - Purchase Limit One Share\n";
                    this.div = 4;
                    this.stock_name_num = 6;
                    this.direction = 2;
                    this.movement = 2;
                    this.move = 3;
                    this.meeting = 1;
                    break;
                case 42:
                    this.title = "A.M. Motors\n";
                    this.div = 3;
                    this.stock_name_num = 7;
                    this.direction = 1;
                    this.movement = 2;
                    this.move = 4;
                    this.meeting = -1;
                    break;
                case 43:
                    this.title = "Sell All Woolworth - At $30 Per Share\n";
                    this.div = -1;
                    this.stock_name_num = 1;
                    this.direction = 2;
                    this.movement = 2;
                    this.move = 5;
                    this.meeting = -1;
                    break;
                case 44:
                    this.title = "Pay Broker Fee $10 Per Share\n";
                    this.div = -2;
                    this.stock_name_num = -2;
                    this.direction = 2;
                    this.movement = 2;
                    this.move = 20;
                    this.meeting = -2;
                    break;
                case 45:
                    this.title = "Sell All Maytag - At $15 Per Share\n";
                    this.div = -1;
                    this.stock_name_num = 3;
                    this.direction = 1;
                    this.movement = 1;
                    this.move = 5;
                    this.meeting = -1;
                    break;
                case 46:
                    this.title = "Gen. Mills\n";
                    this.div = 1;
                    this.stock_name_num = 8;
                    this.direction = 2;
                    this.movement = 1;
                    this.move = 4;
                    this.meeting = -1;
                    break;
                case 47:
                    this.title = "J.I. Case -  Purchase Limit One Share\n";
                    this.div = 2;
                    this.stock_name_num = 5;
                    this.direction = 1;
                    this.movement = 1;
                    this.move = 3;
                    this.meeting = 1;
                    break;
                case 48:
                    this.title = "A.M. Motors\n";
                    this.div = 3;
                    this.stock_name_num = 7;
                    this.direction = 2;
                    this.movement = 1;
                    this.move = 2;
                    this.meeting = -1;
                    break;
                case 49:
                    this.title = "Alcoa\n";
                    this.div = 4;
                    this.stock_name_num = 1;
                    this.direction = 1;
                    this.movement = 1;
                    this.move = 1;
                    this.meeting = -1;
                    break;
                default:
                    Console.WriteLine("Error\n");
                    break;
            }
        }
    }
}
