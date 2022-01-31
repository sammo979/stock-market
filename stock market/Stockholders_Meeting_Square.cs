using System;
using System.Collections.Generic;
using System.Text;

namespace stock_market
{
    public class Stockholders_Meeting_Square
    {
        public int[] Stockholder = new int[9];
        public int Move = 0; // 1 means add, 2 means subtract
        public Stockholders_Meeting_Square(int stockNameNum )
        {
            switch(stockNameNum)
            {
                case 1:
                    //woolwth add,1
                    Stockholder[0] = 1;
                    Stockholder[1] = 2;
                    Stockholder[2] = 1;
                    Stockholder[3] = 2;
                    Stockholder[4] = 3;
                    Stockholder[5] = 2;
                    Stockholder[6] = 1;
                    Stockholder[7] = 2;
                    Stockholder[8] = 1;
                    Move = 1;
                    break;
                case 2:
                    //alcoa, subtract 2
                    Stockholder[0] = 1;
                    Stockholder[1] = 2;
                    Stockholder[2] = 1;
                    Stockholder[3] = 2;
                    Stockholder[4] = 3;
                    Stockholder[5] = 2;
                    Stockholder[6] = 1;
                    Stockholder[7] = 2;
                    Stockholder[8] = 1;
                    Move = 2;
                    break;
                case 3:
                    //int shoe,subtract,2
                    Stockholder[0] = 1;
                    Stockholder[1] = 3;
                    Stockholder[2] = 2;
                    Stockholder[3] = 3;
                    Stockholder[4] = 2;
                    Stockholder[5] = 3;
                    Stockholder[6] = 2;
                    Stockholder[7] = 3;
                    Stockholder[8] = 1;
                    Move = 2;
                    break;
                case 4:
                    //ji case add 1
                    Stockholder[0] = 1;
                    Stockholder[1] = 2;
                    Stockholder[2] = 3;
                    Stockholder[3] = 2;
                    Stockholder[4] = 3;
                    Stockholder[5] = 2;
                    Stockholder[6] = 3;
                    Stockholder[7] = 2;
                    Stockholder[8] = 1;
                    Move = 1;
                    break;
                case 5:
                    //maytag subtract 2
                    Stockholder[0] = 1;
                    Stockholder[1] = 2;
                    Stockholder[2] = 3;
                    Stockholder[3] = 2;
                    Stockholder[4] = 3;
                    Stockholder[5] = 2;
                    Stockholder[6] = 3;
                    Stockholder[7] = 2;
                    Stockholder[8] = 1;
                    Move = 2;
                    break;
                case 6:
                    //gen mills add,1
                    Stockholder[0] = 1;
                    Stockholder[1] = 3;
                    Stockholder[2] = 2;
                    Stockholder[3] = 3;
                    Stockholder[4] = 2;
                    Stockholder[5] = 3;
                    Stockholder[6] = 2;
                    Stockholder[7] = 3;
                    Stockholder[8] = 1;
                    Move = 1;
                    break;
                case 7:
                    //am motors  add 1
                    Stockholder[0] = 1;
                    Stockholder[1] = 2;
                    Stockholder[2] = 3;
                    Stockholder[3] = 2;
                    Stockholder[4] = 1;
                    Stockholder[5] = 2;
                    Stockholder[6] = 3;
                    Stockholder[7] = 2;
                    Stockholder[8] = 1;
                    Move = 1;
                    break;
                case 8:
                    //western pub subtract 2
                    Stockholder[0] = 1;
                    Stockholder[1] = 2;
                    Stockholder[2] = 3;
                    Stockholder[3] = 2;
                    Stockholder[4] = 1;
                    Stockholder[5] = 2;
                    Stockholder[6] = 3;
                    Stockholder[7] = 2;
                    Stockholder[8] = 1;
                    Move = 2;
                    break;
            }
        }
    }
}
