using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MathsGame
{
    //
    //A maths game that asks the user to add,sud,mult or div numbers on a running total
    //
    //
    //
    class Program
    {

        #region globle decleration of veribles
        
            private static Random ran = new Random();
            private static int startNum = ran.Next(10) + 1;
            private static int user = 0;
            private static int runningTotal = 0;
            private static int nextNumber;
            private static int caseSwitch;
            private static int temp;
            private static Boolean rightAns = false;

        #endregion

        static void Main(string[] args)
        {
            runningTotal = startNum;
          
            while (true)
                {
                    runningTotal = returnRunningTotal();
                    rightAns = false;
                }
           
        }

        #region switch methodes for next numbers generated

            private static int returnRunningTotal()
            { 
                nextNumber = ran.Next(10) + 1;
                caseSwitch = ran.Next(4);
           
                    switch (caseSwitch)
                    {
                        case 0:
                            while (rightAns == false)
                            {
                                temp = nextNumber + runningTotal;
                                Console.WriteLine("Add " + nextNumber + " to " + runningTotal);
                                user = int.Parse(Console.ReadLine());
                                if (user.Equals(temp))
                                {
                                    runningTotal = user;
                                    rightAns = true;
                                }
                                else
                                {
                                    Console.WriteLine("Wrong !");
                                    rightAns = false;
                                }
                            }
                            break;
                        case 1:
                            while (rightAns == false)
                            {
                                temp = runningTotal - nextNumber;
                                Console.WriteLine("sub " + nextNumber + " from " + runningTotal);
                                user = int.Parse(Console.ReadLine());
                                if (user.Equals(temp))
                                {
                                    runningTotal = user;
                                    rightAns = true;
                                }
                                else
                                {
                                    Console.WriteLine("Wrong !");
                                    rightAns = false;
                                }
                            }
                            break;
                        case 2:
                            while (rightAns == false)
                            {
                                temp = nextNumber * runningTotal;
                                Console.WriteLine("mult " + nextNumber + " by " + runningTotal);
                           
                                user = int.Parse(Console.ReadLine());
                                if (user.Equals(temp))
                                {
                                    runningTotal = user;
                                    rightAns = true;
                                }
                                else
                                {
                                    Console.WriteLine("Wrong !");
                                    rightAns = false;
                                }
                            }
                            break;
                        case 3:
                            if ((nextNumber % 2 == 0) && (runningTotal % 2 == 0))
                            {
                                while (rightAns == false)
                                {
                                    temp = nextNumber / runningTotal;
                                    Console.WriteLine("div " + nextNumber + " by " + runningTotal);
                             
                                    user = int.Parse(Console.ReadLine());
                                    if (user.Equals(temp))
                                    {
                                        runningTotal = user;
                                        rightAns = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Wrong !");
                                        rightAns = false;
                                    }
                                }
                            }
                            break;
                    }
            
                return runningTotal;
            }

        #endregion
    }
}
