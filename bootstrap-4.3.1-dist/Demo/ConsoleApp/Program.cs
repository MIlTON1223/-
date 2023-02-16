using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*if the values are to be put in a try and catch scheme, we must redeclare the used variables to 0*/
            float arg1 = 0;
            float arg2 = 0;
            int i = 0;
            bool check=true;
            // iteration1();
            while (i == 0)
            {
                while (check)
            {
                    try
                    {
                        /*the first phase code put without of the try and catch scheme gave and error whence a non-float was introduced eg "letter-l*/
                        Console.WriteLine("Enter your first operand");
                        arg1 = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Enter your second operand");
                        arg2 = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine();

                        check = false;

                   
                    System.Console.WriteLine("What do you want to do? 1-add, 2-substract, 3-divide, 4-multiply");
                    int a = Convert.ToInt32(System.Console.ReadLine());
                    Console.WriteLine();
                    //testing on the operator to be used...
                    if (a == 1)
                    {
                        float arg3 = Addition(arg1, arg2);
                        Console.WriteLine(arg3);

                    }
                    else if (a == 2)
                    {
                        float arg3 = Substraction(arg1, arg2);
                        Console.WriteLine(arg3);
                    }
                    else if (a == 3)
                    {
                        float arg3 = Division(arg1, arg2);
                        Console.WriteLine(arg3);
                    }
                    else if (a == 4)
                    {
                        float arg3 = Multiplication(arg1, arg2);
                        Console.WriteLine(arg3);
                    }
                    else
                    {
                        Console.WriteLine("wrong value imput");
                    }

                    Console.ReadLine();
                    }
                    catch (Exception)
                    {
                        //what happens when a non-float is used...
                        Console.WriteLine("value out of bounds");
                    }
                }
            }
        }
           public static float Addition(float arg1, float arg2)
        {
            return (arg1 + arg2);
        }
        public static float Substraction(float arg1, float arg2)
        {
            return (arg1 - arg2);
        }
        public static float Multiplication(float arg1, float arg2)
        {
            return (arg1 * arg2);
        }
        public static float Division(float arg1, float arg2)
        {
            return (arg1 / arg2);
        }
        public static int Modular(int arg1, int arg2)
        {
            return (arg1 % arg2);
        }
        public static void iteration1()
        {
            for(int i=0; i<=5; i++)
            {
                Console.WriteLine(i=+1);
                Console.ReadLine();
            }
        }
    
        }           
}