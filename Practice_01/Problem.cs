using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_01
{
    class Problem
    {
        public void Result()
        {
            /*
                // problem 01:
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("Hello: " + name);


                // problem 02:
                Console.WriteLine("Enter First Number : ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number : ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 + num2;
                Console.WriteLine("Result is : " + result);


                // problem 03:
                Console.WriteLine("Enter First Number : ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number : ");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine("Result is : " + result);

                // problem 04:
                Console.WriteLine(-1 + 4 * 6);
                Console.WriteLine((35 + 5) % 7);
                Console.WriteLine(14 + -4 * 6 / 11);
                Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);


                // problem 05:
                Console.WriteLine("Enter First Number : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int temp = 0;
                temp = num1;
                num1 = num2;
                num2 = temp;
                Console.WriteLine("Number one is: " + num1);
                Console.WriteLine("Number two is " + num2);


                // problem 06:
                Console.WriteLine("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter third number: ");
                int num3 = int.Parse(Console.ReadLine());
                int result = num1 * num2 * num3;
                Console.WriteLine($"{num1} * {num2} * {num3} = " + result);


                // problem 07:
                Console.WriteLine("Enter the first number : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number : ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                double add = num1 + num2;
                double sub = num1 - num2;
                double mul = num1 * num2;
                double div = num1 / num2;
                double dob = num1 % num2;

                Console.WriteLine($"{num1} + {num2} = " + add);
                Console.WriteLine($"{num1} - {num2} = " + sub);
                Console.WriteLine($"{num1} * {num2} = " + mul);
                Console.WriteLine($"{num1} / {num2} = " + div);
                Console.WriteLine($"{num1} % {num2} = " + dob);    
                


                // problem 08:
                Console.WriteLine("Enter the number: ");
                int num = int.Parse(Console.ReadLine());

                for(int i= 0; i <= 10; i++)
                {
                    Console.WriteLine($"{i} * {num} = " + i * num);
                }


                // problem 09: 
                Console.WriteLine("Enter the number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number: ");
                int num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number: ");
                int num4 = int.Parse(Console.ReadLine());

                double res = (num1 + num2 + num3 + num4) / 4;
                Console.WriteLine($"{num1}, {num2}, {num3}, {num4} is: "+res);


                // problem 10:
                Console.WriteLine("Enter the number: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number: ");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number: ");
                int z = int.Parse(Console.ReadLine());

                double res1 = (x + y) * z;
                double res2 = (x * y) + (y * z);

                Console.WriteLine($"Result of specified numbers {x}+{y}.{z} is {res1} and {x}.{y} + {y}.{z} is {res2}");


                
                // problem 11:
                Console.WriteLine("Enter your age ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine($"You look older than {age}");


                // problem 12:
                Console.WriteLine("Enter a digit: ");
                int num = int.Parse(Console.ReadLine());

                for(int i = 1; i <= 4; i++)
                {
                    if(i % 2 == 0)
                    {
                        for (int j = 1; j <= 4; j++)
                        {
                            Console.Write(num);
                        }
                    }else
                    {
                        for (int j = 1; j <= 4; j++)
                        {
                            Console.Write(num+ " ");
                        }
                    }

                    Console.WriteLine();
                }
             

                // problem 13:
                //  1 * * * 5 * * * 9 * * * 13...
                Console.WriteLine("Enter digit: ");
                int num = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= num; i+=4)
                {
                    Console.WriteLine(i);
                    for(int j=1; j <= 3; j++)
                    {
                        Console.WriteLine("*");
                    }
                }


             // problem 14:
             Console.WriteLine("Enter the amount of celsius :");
             int celsius = int.Parse(Console.ReadLine());
             int celsiusres = celsius + (int)273.15;
             int farenhiteres = (celsius * (int) 9 / 5) + 32;

             Console.WriteLine("Kelvin = "+ celsiusres);
             Console.WriteLine("Fahrenheit = "+ farenhiteres);
             

            // problem 15:
            Console.WriteLine("Enter index number :");
            int indexNumber = int.Parse(Console.ReadLine());
            string s = "w3resource";
            Console.WriteLine(s.Remove(1, indexNumber)); 


            // problem 16:
            Console.WriteLine("Enter the name: ");
            string str = Console.ReadLine();
            if(str.Length > 1)
            {
                string firstChar = str.Substring(0, 1);
                string lastChar = str.Substring(str.Length - 1);
                string middleChar = str.Substring(1, str.Length - 2);
                Console.WriteLine(lastChar+middleChar+firstChar);
            }
            else
            {
                Console.WriteLine(str);
            }
             

            // problem 17:
            string str = "The quick brown fox jumps over the lazy dog.";
            string firstChar = str.Substring(0, 1);
            string wholeChar = str.Substring(0, str.Length);
            Console.WriteLine(firstChar+wholeChar+firstChar);

            // problem 18:
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 > 0 && num2 < 0 || num1 < 0 && num2 > 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }



            problem 19:
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine((num2+num1)*3);
            }else
            {
                Console.WriteLine(num1+num2);
            }


            problem 20:
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                int res =  (num1 - num2) * 2;
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine(num2 - num1);
            }


            // problem 21:
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int res = num1 + num2;

            if(num1 > 20 || num2 > 20 || res == 20)
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }



            problem 22:
            Console.WriteLine("Enter the first number: ");
            int num = int.Parse(Console.ReadLine());
             

            if( Math.Abs(num - 100) <= 20 || Math.Abs(num - 200) <= 20)
            {
                Console.WriteLine(true);
            }else
            {
                Console.WriteLine(false);
            }
            

            // problem 23:
            string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            Console.WriteLine(line.ToLower());


            // problem 24:
            string str = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ch = 0;
            foreach(string s in words)
            {
                if(s.Length > ch)
                {
                    word = s;
                    ch = s.Length;
                }
            }
            Console.WriteLine(word);


            Console.WriteLine();



            // problem 25:
            for(int i =1; i <= 99; i += 2)
            {
                Console.WriteLine(i);
            }
			
			
			// problem 26:
			
			
			 public static bool IsPrime(int n)
			{

				int x = (int)Math.Floor(Math.Sqrt(n));

				if (n == 1)
				{
					return false;
				}

				for(int i = 2; i<= x; i++)
				{
					if(n % i == 0)
					{
						return false;
					}
				}

				return true;

			}

			
			
			long sum = 0;
            int count = 0;
            int n = 2;

            while (count < 500)
            {
                if (IsPrime(n))
                {
                    sum += n;
                    count++;
                }
                n++;
                    
            }

            Console.WriteLine(sum.ToString());
			
			============================= 
			
			  //Console.WriteLine("Enter number ");
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int count = 0;
            //for (int i = 3; i <= n; i++)
            //{
            //    int isPrime=0;

            //    for (int j = 2; j <=  i/2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime++;
            //            break;
            //        }
            //    }
            //    if (isPrime == 0 &&  i != 1 )
            //    {
            //        Console.WriteLine(i);
            //        count += 1;
            //        sum += i;
            //    }
            //}
            //Console.WriteLine($"total {sum}");
            //Console.WriteLine($"total number {count}");
			
			
			// problem 27:
			Console.WriteLine("Enter you number ");
			int n = Convert.ToInt32(Console.ReadLine());
			int sum = 0;
			int temp = n;
			int r;
			while(temp != 0)
			{
				r = temp % 10;
				sum += r;
				temp = temp / 10;
				
				//sum += n % 10;
				//n /= 10;
			}

			Console.WriteLine(sum);
			

			// problem 28:
			string line = "Display the pattern like pyramid using the alphabet.";
			//string[] words = line.Split(' ');
			string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
			string joinArray = " ";
			for (int i = words.Length - 1; i >= 0 ; --i)
			{
				joinArray += words[i] + " ";
			}
			Console.WriteLine(joinArray);
			
			
			// problem 29:
			string path = @"C:\Users\USER\source\repos\Demo.txt";
            Console.WriteLine("File size : " + path.Length.ToString() + " Byte");
			
			// problem 30:
			 string hexval = "4B0";
            Console.WriteLine("Hexadecimal number: " + hexval);

            int decVal = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine(decVal);


             */

               
			
			   
			   
           

             


            }
        }
    }
