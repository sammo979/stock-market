using System;
using System.Collections.Generic;
using System.Text;

namespace stock_market
{
    public class Start_Board
    {
        public string title;
        public int[] roll = new int[2];
        public int roll_num;
        public int salary;
        public Start_Board(int num)
        {
            if (num == 1)
            {
                title = "Prospector\n";
                roll[0] = 2;
                roll[1] = 12;
                roll_num = 1;
                salary = 400;
            }
            if (num == 2)
            {
                title = "Policeman\n";
                roll[0] = 5;
                roll[1] = 9;
                roll_num = 2;
                salary = 100;
            }
            if (num == 3)
            {
                title = "Doctor\n";
                roll[0] = 4;
                roll[1] = 10;
                roll_num = 3;
                salary = 200;
            }
            if (num == 4)
            {
                title = "Deep Sea Diver\n";
                roll[0] = 3;
                roll[1] = 11;
                roll_num = 4;
                salary = 300;
            }
        } //done, fill the start board with the right information
        public void show()
        {
            //print out the description of the work position
            Console.WriteLine("{0}", title);
            Console.WriteLine("Dice roll needed: {0},{1}\n", roll[0], roll[1]);
            Console.WriteLine("Enter this number to pick this job:{0}\n", roll_num);
            Console.WriteLine("The Salary: {0}\n\n\n", salary);
        } //done, shows a description of each work position
    }
    
}
