using System;

namespace Conditional_Statements_Practice
{

    class Program
    {
        static void Main()
            //-----------------------if statement-----------------------------
        //{
        //    Console.WriteLine("Please enter a number");
        //    int UserNumber = int.Parse(Console.ReadLine());
        //    if(UserNumber==1)
        //    {
        //        Console.WriteLine("Your number is one");
        //    }
        //    if (UserNumber == 2)
        //    {
        //        Console.WriteLine("Your number is two");
        //    }
        //    if (UserNumber == 3)
        //    {
        //        Console.WriteLine("Your number is three");
        //    }
        //    if(UserNumber!=1&& UserNumber!=2&&UserNumber!=3)
        //    {
        //        Console.WriteLine("your is not between 1 and 3");
        //    }

        //-------------------------------------replaced if stat. by using if-else condition-----------------------
        //{
        //    Console.WriteLine("please enter a number");
        //    int usernumber = int.Parse(Console.ReadLine());
        //            if (usernumber == 1)
        //            {
        //                Console.WriteLine("your number is one");  
        //            }
        //            else if (usernumber == 2)
        //            {
        //                Console.WriteLine("your number is two");
        //            }
        //            else if (usernumber == 3)
        //{
        //    Console.WriteLine("your number is three");
        //}
        //else
        //{
        //    Console.WriteLine("your is not between 1 and 3");
        //}
        //}


        //switch statement
        //{
        //            Console.WriteLine("please enter a no.");
        //            int usernumber = int.Parse(Console.ReadLine());
        //            if (usernumber == 10)
        //            {
        //                Console.WriteLine("your number is 10");
        //            }
        //            else if (usernumber == 20)
        //            {
        //                Console.WriteLine("your number is 20");
        //            }
        //            else if (usernumber == 30)
        //            {
        //                Console.WriteLine("your number is 30");
        //            }
        //            else
        //            {
        //                Console.WriteLine("your is not  10 ,20 and 30");
        //            }
        //        }

        // -----------replaced by switch statement---------------------------------

        {
            Console.WriteLine("please enter a no.");
              int usernumber = int.Parse(Console.ReadLine());
            
                switch (usernumber)
            {
                case 10:
                    Console.WriteLine("your number is 10");
                    break;
                case 20:
                    Console.WriteLine("your number is 20");
                    break;
                case 30:                    Console.WriteLine("your number is 30");
                    break;
                default :
                    Console.WriteLine("your is not  10 ,20 and 30");
                    break;
                //-----------------or--------------------------------------
                //case 10;
                // case 20;
                // case 30;
                //     Console.WriteLine("your number is {0}",usernumber);
                ////     break;
                //default:
                //    Console.WriteLine("your is not  10 ,20 and 30");
                //    break;
            }
        }
}}