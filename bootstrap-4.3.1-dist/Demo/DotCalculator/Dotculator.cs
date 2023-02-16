using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotCalculator
{
    class Dotculator
    {
        static void Main(string[] args)
        {
            int i = 0;
            //including the do while loop and setting value to 0 , this makes it impossible for the loop to end
            do
            {
                //simple dot notation used because the methods are all static, no need to instantiate them
                calculator.operateur();
                //This is what could've been used if the methods werent static. Remember only a static method can access a static method! 
                // calculator calc = new calculator();
                // calc.operateur();
            } while (i == 0);
        }
    }
    public  class calculator
    {
        public static float  Addition(float arg1, float arg2)
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
        public static bool LessGreater(float arg1, float arg2)
        {
            if (arg1 > arg2) { Console.WriteLine("The First value is greater than the Second");}
           else if (arg2 > arg1) { Console.WriteLine("The Second value is greater than the First"); }
            if (arg1 == arg2) { Console.WriteLine("These values are all equal!"); }
        }
        public static int Modular(int arg1, int arg2)
        {
            return (arg1 % arg2);
        }
        public static void  operateur()
        {

            try
            {
                bool checker = true;
                while (checker == true)
                {
                    Console.WriteLine("Enter the first operand:");
                    float arg1 = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Enter the second operand:");
                    float arg2 = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Choose any: +,-,*, /,% or bit?");
                    char op = Convert.ToChar(Console.ReadLine());
                    checker = false;
                    if (op == '+')
                    {
                        float ans = Addition(arg1, arg2);
                        Console.WriteLine(ans);
                    }
                    else if (op == '-')
                    {
                        float ans = Substraction(arg1, arg2);
                        Console.WriteLine(ans);
                    }
                    else if (op == '*')
                    {
                        float ans = Multiplication(arg1, arg2);
                        Console.WriteLine(ans);
                    }
                    else if (op == '/')
                    {
                        float ans = Division(arg1, arg2);
                        Console.WriteLine(ans);
                    }
                    else if(op == "b")
                    {
                        bool ans = LessGreater(arg1, arg2);
                        Console.WriteLine(ans);
                    }
                    else if (op == '%')
                    {
                        int a = Convert.ToInt32(arg1);
                        int b = Convert.ToInt32(arg2);
                        {
                        }
                        float ans = Modular(a, b);
                        Console.WriteLine(ans);
                    }
                    else
                    {
                        Console.WriteLine("Error,please reconsult your sheet of operators");
                    }
                    Console.ReadLine();
                }
                
            }
            catch
            {
                Console.WriteLine("Enter a variable that is a number, sure you added a letter!");
            }
            Console.ReadKey();

        }
    }
    public class GenericLinking
    {
        public static void genericBrother()
        {
            string[] person1 = new string[] { "Arabeng", "Consolata", "677575159", "Star Multipurpose" };
            string[] person2 = new string[] { "Fogwe", "Fogwe", "677575159", "Bucrep-MINEPAT" };
            string[] person3 = new string[] { "Ande", "Bande", "659559494", "FoodOK" };
            Dictionary<int, string[]> dict = new Dictionary<int, string[]>();
            //the pain of a dictionary; 1,2,3 are keys to the values of the person1, person2 and person 3 respectively. W wouldnt know thus if Arabeng is a name or an email address
            //Unfortunately the values are still not strongly typed, information are strored in a string array rather than a user type
            dict.Add(1, person1);
            dict.Add(2, person2);
            dict.Add(3, person3);
            foreach (var value in dict)
            {
                string[] userinfo = value.Value;
                foreach (var user in userinfo)
                {
                    System.Console.WriteLine(user);
                }
            }
        }
        public static void genericBrotherusingCustomClassCreated9()
        {
            List<user> users = new list<user>();
            users.Add(new user { userID = "1", Firstname = "Adil", Lastmame = "Renato", Telephone = "612222254", Location = "Home" });
            users.Add(new user { userID = "2", Firstname = "Clinton", Lastmame = "Njie", Telephone = "8186222254", Location = "Marseille" });
            users.Add(new user { userID = "3", Firstname = "Abu", Lastmame = "Trika", Telephone = "844541154", Location = "Besiktas" });
            foreach (var user in users)
            {
                System.Console.WriteLine(String.Format("The user {0} {1} could be called using the number {2}, He is presently at {3}", user.Firstname, user.Lastmame, user.Telephone, user.Location));
            }
        }
        //to do the solutions of the uplisted problems for custom types
        //...creating a custom type user...when created we can now store all the values in a collection and retreive the values
        public class user
        {
            public int userID { get; set; }//optional, used if you wish to call the user using an id
            public string Firstname { get; set; }
            public string Lastmame { get; set; }
            public int Telephone { get; set; }
            public string Location { get; set; }
        }
    }
}
