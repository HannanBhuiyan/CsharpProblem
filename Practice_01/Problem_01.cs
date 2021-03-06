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



            // problem 40:
            Console.WriteLine("Enter the first number: ");

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



             // problem 45:

            Console.WriteLine("Enter an integer number :");
            int num = int.Parse(Console.ReadLine());

            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

            Console.WriteLine(nums.Count(x => x == num));


            // problem 46:
            Console.WriteLine("Enter an integer number :");
            int x = int.Parse(Console.ReadLine());


            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9, 10 };

            int firstindex = nums[0];
            int lastindex = nums[nums.Length - 1];

            if(firstindex == x || lastindex == x)
            {
                Console.WriteLine(true);
            }else
            {
                Console.WriteLine(false);
            } 


            //  ================== problem 47:
            int[] arr =  {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            int sum = 0;
            for(int i = 0; i< arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);


             //  ================== problem 48:
             int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 55 };

            int firstindex = nums[0];
            int lastindex = nums[nums.Length - 1];

            if (firstindex == lastindex && nums.Length >= 1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


             //  ================== problem 49:
            int[] arr1 = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] arr2 = new int[] { 10, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };


            int firstindexofarr1 = arr1[0];
            int firstindexofarry2 = arr2[0];

            if(firstindexofarr1 == firstindexofarry2 && arr1.Length >= 1 && arr2.Length >= 1)
            {
                Console.WriteLine(true);
            }else
            {
                Console.WriteLine(false);
            }
             

            //  ================== problem 50:
            int[] arr = { 1, 2, 8, 10 };
            int temp = arr[0];
            for(int i =0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = temp;
            Console.WriteLine($"[{string.Join(",", arr)}]");


             //  ================== problem 51:

            // way one
            //int[] array = { 1, 2, 5, 55, 7, 8 };
            //int maxValue = array.Max();

            //int maxIndex = array.ToList().IndexOf(maxValue);
            //Console.WriteLine(array[maxIndex]);


            // way three

            //int[] array = { 1, 2, 5, 55, 7, 8, 100 };
            //int index = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > index)
            //    {
            //        index  = array[i];
            //    }
            //}
            //Console.WriteLine(index);


            //int[] array = { 1, 2, 5, 55, 500, 7, 8, 100 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //     for(int j = 0; j < array.Length - 1; j++)
            //    {
            //        if(array[j] > array[j + 1])
            //        {
            //            int temp = 0;
            //            temp = array[j];
            //            array[j] = array[j + 1];
            //            array[j + 1] = temp;
                         
            //        }
            //    }
            //}
            //Console.WriteLine(array[array.Length - 1]);




             // ================== problem 52:

            int[] arr1 = { 1, 2, 11 };
            int[] arr2 = { 6, 0, 5 };
            int[] arr3 = { 3, 4, 5 };

           
            int mid = arr1[arr1.Length / 2];
            Console.WriteLine(mid);


            // way one
            //int arr1Middle = arr1[arr1.Length - 2];
            //int arr2Middle = arr2[arr2.Length - 2];
            //int arr3Middle = arr3[arr3.Length - 2];

            //int arr1Middle = arr1[1];
            //int arr2Middle = arr2[1];
            //int arr3Middle = arr3[1];

            //int[] new_array = { arr1Middle, arr2Middle, arr3Middle };
            //Console.WriteLine($"[{string.Join(",", new_array)}]");
            //Console.WriteLine($"[{ String.Join(", ", arr1Middle, arr2Middle , arr3Middle)}]");



            int[] ar = { 1, 5, 7, 9, 11, 13 };
            Console.WriteLine($"[{ string.Join("," , ar[ar.Length / 2 - 1], ar[ar.Length / 2])}]");

            //foreach(var i in new_arr)
            //{
            //    Console.Write(i.ToString()+" ");
            //}



              // ================= array copy extra problem ===============

            int[] ar = { 1, 5, 7, 9, 11, 13 };

            //var new_arr = new int[6];

            //ar.CopyTo(new_arr, 0);

            //foreach(var i in new_arr)
            //{
            //    Console.WriteLine(i);
            //}

            var new_arr = new int[6];

            for (int i = 0; i < ar.Length; i++)
            {
                new_arr[i] = ar[i];

            }

            foreach (var i in new_arr)
            {
                Console.WriteLine(i);
            }
             
            // ================= array copy extra problem ===============



            // problem 53:

            int[] arr = { 2, 4, 10, 8, 6 };

            bool isOdd = false;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 != 0)
                {
                    isOdd = true;
                }
            }
            Console.WriteLine(isOdd);


			// problem 54:
			Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine((int)(year / 100) + ((year % 100 == 0) ? 0 : 1));
            
			
			
			
			 // problem 55:
             //int[] arr = { 2, 4, 2, 6, 9, 3 };
             int[] arr = { 0, -1, -1, -2 };

             int target = int.Parse(Console.ReadLine());

             var new_arr = new int[5];
             for (int i = 0; i < arr.Length -1; i++)
             {
                  new_arr[i] += arr[i] * arr[i + 1];
             }

             if(new_arr.Max() == target)
             {
                 Console.WriteLine(true);
             }else
             {
                 Console.WriteLine(false);
             }

            // problem 57:
            // int[] arr = { 1, -3, 4, -5, 1 };
            int[] arr = { 1, 0, -4, 0, 2 };

            List<int> arrList = new List<int>();
             
            for (int i = 0; i < arr.Length - 1 ; i++)
            {
                arrList.Add(arr[i] * arr[i + 1]);
            }

            Console.WriteLine(arrList.Max());


             // =============== problem 58:
            // way one
            var arrList = new List<int> { 1, 2, 4, 7, 9 };

            var totalRange = Enumerable.Range(0, arrList.Max());

            var missingItems = totalRange.Except(arrList);

            foreach (int i in missingItems)
            {
                Console.WriteLine(i);
            }


            // way two
            List<int> arrList2 = new List<int> { 1, 2, 4, 7, 9 };
            List<int> newList = new List<int>();
            for(int i=0; i <= arrList2.Max(); i++)
            {
                Console.WriteLine(arrList2.IndexOf(i));
                if (arrList2.IndexOf(i) == -1)
                {
                    newList.Add(i);
                }

            }
            foreach(var list in newList)
            {
                Console.WriteLine(list);
            }


			
			
			

             */


            


        }
    }
}
