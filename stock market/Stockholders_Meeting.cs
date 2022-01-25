using System;
using System.Collections.Generic;
using System.Text;

namespace stock_market
{
    public class Stockholders_Meeting
    {
        public int[] stockholder = new int[9];
        public int move = 0; // 1 means add, 2 means subtract
        public Stockholders_Meeting(int stock_name_num )
        {
            switch(stock_name_num)
            {
                case 1:
                    //woolwth add,1
                    stockholder[0] = 1;
                    stockholder[1] = 2;
                    stockholder[2] = 1;
                    stockholder[3] = 2;
                    stockholder[4] = 3;
                    stockholder[5] = 2;
                    stockholder[6] = 1;
                    stockholder[7] = 2;
                    stockholder[8] = 1;
                    move = 1;
                    break;
                case 2:
                    //alcoa, subtract 2
                    stockholder[0] = 1;
                    stockholder[1] = 2;
                    stockholder[2] = 1;
                    stockholder[3] = 2;
                    stockholder[4] = 3;
                    stockholder[5] = 2;
                    stockholder[6] = 1;
                    stockholder[7] = 2;
                    stockholder[8] = 1;
                    move = 2;
                    break;
                case 3:
                    //int shoe,subtract,2
                    stockholder[0] = 1;
                    stockholder[1] = 3;
                    stockholder[2] = 2;
                    stockholder[3] = 3;
                    stockholder[4] = 2;
                    stockholder[5] = 3;
                    stockholder[6] = 2;
                    stockholder[7] = 3;
                    stockholder[8] = 1;
                    move = 2;
                    break;
                case 4:
                    //ji case add 1
                    stockholder[0] = 1;
                    stockholder[1] = 2;
                    stockholder[2] = 3;
                    stockholder[3] = 2;
                    stockholder[4] = 3;
                    stockholder[5] = 2;
                    stockholder[6] = 3;
                    stockholder[7] = 2;
                    stockholder[8] = 1;
                    move = 1;
                    break;
                case 5:
                    //maytag subtract 2
                    stockholder[0] = 1;
                    stockholder[1] = 2;
                    stockholder[2] = 3;
                    stockholder[3] = 2;
                    stockholder[4] = 3;
                    stockholder[5] = 2;
                    stockholder[6] = 3;
                    stockholder[7] = 2;
                    stockholder[8] = 1;
                    move = 2;
                    break;
                case 6:
                    //gen mills add,1
                    stockholder[0] = 1;
                    stockholder[1] = 3;
                    stockholder[2] = 2;
                    stockholder[3] = 3;
                    stockholder[4] = 2;
                    stockholder[5] = 3;
                    stockholder[6] = 2;
                    stockholder[7] = 3;
                    stockholder[8] = 1;
                    move = 1;
                    break;
                case 7:
                    //am motors  add 1
                    stockholder[0] = 1;
                    stockholder[1] = 2;
                    stockholder[2] = 3;
                    stockholder[3] = 2;
                    stockholder[4] = 1;
                    stockholder[5] = 2;
                    stockholder[6] = 3;
                    stockholder[7] = 2;
                    stockholder[8] = 1;
                    move = 1;
                    break;
                case 8:
                    //western pub subtract 2
                    stockholder[0] = 1;
                    stockholder[1] = 2;
                    stockholder[2] = 3;
                    stockholder[3] = 2;
                    stockholder[4] = 1;
                    stockholder[5] = 2;
                    stockholder[6] = 3;
                    stockholder[7] = 2;
                    stockholder[8] = 1;
                    move = 2;
                    break;
            }
        }
    }
}
