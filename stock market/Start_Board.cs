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
                this.title = "Prospector\n";
                this.roll[0] = 2;
                this.roll[1] = 12;
                this.roll_num = 1;
                this.salary = 400;
            }
            if (num == 2)
            {
                this.title = "Policeman\n";
                this.roll[0] = 5;
                this.roll[1] = 9;
                this.roll_num = 2;
                this.salary = 100;
            }
            if (num == 3)
            {
                this.title = "Doctor\n";
                this.roll[0] = 4;
                this.roll[1] = 10;
                this.roll_num = 3;
                this.salary = 200;
            }
            if (num == 4)
            {
                this.title = "Deep Sea Diver\n";
                this.roll[0] = 3;
                this.roll[1] = 11;
                this.roll_num = 4;
                this.salary = 300;
            }
        }
        public void show()
        {
            //print out the description of the work postion
            Console.WriteLine("{0}", this.title);
            Console.WriteLine("Dice roll needed: {0},{1}\n", this.roll[0], this.roll[1]);
            Console.WriteLine("Enter this number to pick this job:{0}\n", this.roll_num);
            Console.WriteLine("The Salary: {0}\n\n\n", this.salary);
        }
    }
    
}
