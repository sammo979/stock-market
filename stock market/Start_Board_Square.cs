using System;
using System.Collections.Generic;
using System.Text;

namespace stock_market
{
    public class Start_Board_Square
    {
        public string Title;
        public int[] Roll = new int[2];
        public int RollNum;
        public int Salary;
        public Start_Board_Square(int num)
        {
            if (num == 1)
            {
                Title = "Prospector\n";
                Roll[0] = 2;
                Roll[1] = 12;
                RollNum = 1;
                Salary = 400;
            }
            if (num == 2)
            {
                Title = "Policeman\n";
                Roll[0] = 5;
                Roll[1] = 9;
                RollNum = 2;
                Salary = 100;
            }
            if (num == 3)
            {
                Title = "Doctor\n";
                Roll[0] = 4;
                Roll[1] = 10;
                RollNum = 3;
                Salary = 200;
            }
            if (num == 4)
            {
                Title = "Deep Sea Diver\n";
                Roll[0] = 3;
                Roll[1] = 11;
                RollNum = 4;
                Salary = 300;
            }
        } //done, fill the start board with the right information
        public void Show()
        {
            //print out the description of the work position
            Console.WriteLine("############################################\n");
            Console.WriteLine("#                                          #\n");
            Console.WriteLine("#  {0}                                     #\n", Title);
            Console.WriteLine("#  Dice roll needed: {0},{1}               #\n", Roll[0], Roll[1]);
            Console.WriteLine("#  Enter this number to pick this job:{0}  #\n", RollNum);
            Console.WriteLine("#  The Salary: {0}                         #\n", Salary);
            Console.WriteLine("#                                          #\n");
            Console.WriteLine("############################################\n\n");
        } //done, shows a description of each work position
    }
    
}
