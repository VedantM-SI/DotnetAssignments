namespace Arrays_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////ARRAYS//////////
            /* 1st */
            /*Console.WriteLine("Enter the number of elements");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }*/


            /*2nd*/
            /*Console.WriteLine("Enter the number of elements");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }

                     /*3rd*/
            /*Console.WriteLine("Enter the number of elements");
                    int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] copy = new int[n];
            Console.WriteLine("Enter the elements");
                    for (int i = 0; i<arr.Length; i++)
                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    for (int i = 0; i<arr.Length; i++)
                    {
                        copy[i] = arr[i];
                        Console.WriteLine(copy[i]);
                    }*/

            //4//

            /* Console.Write("Enter the number of elements in the array: ");
             int n = int.Parse(Console.ReadLine());

             int[] arr = new int[n];

             Console.WriteLine("Enter the elements of the array:");
             for (int i = 0; i < n; i++)
             {
                 Console.Write($"Element {i + 1}: ");
                 arr[i] = int.Parse(Console.ReadLine());
             }

             Console.WriteLine("Original Array:");
             PrintArray(arr);

             Console.Write("Enter the position of element to delete: ");
             int position = int.Parse(Console.ReadLine());

             if (position >= 1 && position <= arr.Length)
             {
                 // Create a new array with one less element
                 int[] newArray = new int[arr.Length - 1];

                 // Copy elements from original array to new array
                 for (int i = 0, j = 0; i < arr.Length; i++)
                 {
                     if (i != position - 1)
                     {
                         newArray[j] = arr[i];
                         j++;
                     }
                 }

                 arr = newArray;

                 Console.WriteLine("Array after deleting element:");
                 PrintArray(arr);
             }
             else
             {
                 Console.WriteLine("Invalid position.");
             }
         }

         static void PrintArray(int[] arr)
         {
             foreach (int num in arr)
             {
                 Console.Write(num + " ");
             }
             Console.WriteLine();
         }
     }
*/

            /*5th*/

            /*int[] marks = new int[10];
            Console.WriteLine("Enter the marks for 10 students");
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            avg = sum / 10;
            Console.WriteLine("Average marks:" + avg);
            int max = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] > max)
                {
                    max = marks[i];
                }
            }
            Console.WriteLine("Highest marks:" + max);*/

            ///STRINGS
            ///Write a program that counts the number of occurrences of a particular character in a line of
            //text.
            //1
            /*String s = Console.ReadLine();

            int count = 0;

            char c= Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < s.Length; i++){
                if (s[i].Equals(c)) 
                {
                    count++;
                }
             }
            Console.WriteLine(count);*/


            //2Write a program that reads a string and rewrite it in alphabetical order. For example the
            // word STRING should be written as GINRST.

            /*String s = Console.ReadLine();


            char[] c = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                c[i] = s[i];
            }


            for (int i = 0;i < c.Length; i++)
            {
                Console.Write(c[i]);
            }

            foreach (char a in s)
            {

            }
            Console.ReadKey();*/

            //3 Write a program in C# Sharp to extract a substring from a given string

            /* String s = Console.ReadLine();

             char[] delimiters = {','};

             String[] s2 = s.Split(delimiters);

             foreach (string item in s2)
             {
                 Console.WriteLine(item);
             }

             Console.WriteLine(s2);*/


            //4 Write a program in C# Sharp to search the position of a substring within a string


            /*String s = Console.ReadLine();

            Console.WriteLine(s.IndexOf((Convert.ToChar(Console.ReadLine()))));*/


            //5 Write a C# Sharp program to compare two substrings that only differ in case. The first
            // comparison ignores case and the second comparison considers case

            /*String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();

            Console.WriteLine(s1.Equals(s2));

            Console.WriteLine(s1.ToLower().Equals(s2.ToLower()));*/

            ///////////CONTROL STRCUTURES////////////////////
            /*1*/
            /*Console.WriteLine("Enter the purchase price");
            int price = Convert.ToInt32(Console.ReadLine());
            if (price > 10000)
            {
                Console.WriteLine("Error, Please Try Again!");
            }
            else
            {
                Console.WriteLine("Approved");
            }*/

            //2//
            /* Console.WriteLine("Enter the sentinel value");
             double num = Convert.ToDouble(Console.ReadLine());
             double sum = 0;
             int count = 0;
             for (double i = 0; i < num; i++)
             {
                 Console.WriteLine("Enter the temperature");
                 double temp = Convert.ToDouble(Console.ReadLine());
                 if (temp > 20 && temp < 130)
                 {
                     sum += temp;
                     count++;
                 }
                 else
                 {
                     --i;
                     Console.WriteLine("Enter a valid temperature");
                 }
             }
             Console.Write("No. of temperatures entered:" + count);
             Console.Write("Average of temperatures entered:" + (sum / count));
         }*/

        }
    }
}
            