using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_01
{
    class Problem_01
    {
        public void Result()
        {

            /*
              // Problem 31:
             int[] first_array = { 1, 3, -5, 4,};
             int[] second_array = { 1, 4, -5, -2 };
             for(int i=0; i < first_array.Length; i++)
             {
                 Console.WriteLine(first_array[i] * second_array[i]);
             }

            // problem 32:
            string str = "The quick brown fox jumps over the lazy dog";

            for(int i = 1; i <= 4; i++)
            {
                Console.Write(str.Substring(str.Length - 3)+".");
            }


            // problem 33:
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            if(num > 0 && num % 3 == 0 || num % 7 == 0)
            {
                Console.WriteLine(true);
            }else
            {
                Console.WriteLine(false);
            }


            // problem 34:

            string str = "Hello how are you?";

            if (str.StartsWith("Hello"))
            {
                Console.WriteLine(true);
            }else
            {
                Console.WriteLine(false);
            }

            // problem 35:

            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 < 100 && num2 > 200)
            {
                Console.WriteLine(true);
            }else
            {
                Console.WriteLine(false);
            }

             // problem 36:
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if ((num1 >= -10 && num1 <= 10) || num2 >= -10 && num2 <= 10)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // problem 37:
             string str = "PHP Tutorial";
             Console.WriteLine(str.Substring(1, 2).Equals("HP") ? str.Remove(1,2) : str );

            // problem 38:
            
            string str = "PHP Tutorial";
            string result = "";

            if(str.Length >= 1 && str[0] == 'P')
            {
                result += str[0];
            } 
            
            if(str.Length >= 2 && str[1] == 'H')
            {
                result += str[1];
            }

            Console.WriteLine(result);


            // problem 39:
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Largest number "+ Math.Max(num1, Math.Max(num2, num3)));
            Console.WriteLine("lowest number "+ Math.Min(num1, Math.Min(num2, num3)));



			// problem 39:
		    Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int n = 20;
            int val1 = Math.Abs(num1 - n); // 15
            int val2 = Math.Abs(num2 - n); // 5

             

            if (val1 == val2)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (val1 < val2)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num2);
                }
            }


			 
			// problem 41:
            string str = Console.ReadLine();

            // way one

            var count = str.Count(s => s == 'w');
            Console.WriteLine(count >= 1 && count <= 3);
             

            // way two

            //int wcount = 0;
            //for(int i=0; i< str.Length; i++)
            // {
            //     if(str[i] == 'w')
            //     {
            //         wcount++;
            //     }
            // }
            //if(wcount >= 1 && wcount <= 3)
            // {
            //     Console.WriteLine(true);
            // }else
            // {
            //     Console.WriteLine(false);
            // }


				// problem 42:
				string str = Console.ReadLine();
             
				if (str.Length <= 4)
				{
					Console.WriteLine(str.ToUpper());
				}else
				{
					Console.WriteLine(str);
				}


				// problem 43:
				string str = Console.ReadLine();
				var count = str.Count(s => s == 'w');

				if(str.StartsWith("w") && count <= 2)
				{
					Console.WriteLine(true);
				}else
				{
					Console.WriteLine(false);
				}

				// problem 44:
				string str = Console.ReadLine();

				string res = string.Empty;

				for(int i=0; i < str.Length; i+=2)
				{
					 res += str[i]; 
				}
				Console.WriteLine(res);


             */


            







        }
    }
}
