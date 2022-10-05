using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week4_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question1();
            //Question2();
            //Question3a();
            //Question3();
            //Question4();
            //Question5();
            //Question6();
            //Question7();
            //Question8();
            Question9();
            Console.ReadKey();
        }
        public static void Question1()
        {
            Console.Write("Write a string : ");
            string entireString = Console.ReadLine();
            if(entireString.Length>1)
            {
                string middleChar = entireString.Substring(1, entireString.Length - 2);
                string modifiedString = entireString[entireString.Length - 1] + middleChar + entireString[0];
                Console.WriteLine("The new string is : " + modifiedString);
            }
            else
            {
                Console.WriteLine("The new string is the same : " + entireString);
            }
        }
        public static void Question2()
        {
            // create the sequence of numbers
            Console.WriteLine("Write an array of 10 integers");
            int[] sequence = new int[10];
            for(int i = 0; i< sequence.Length; i++)
            {
                sequence[i] = Convert.ToInt32(Console.ReadLine());
            }

            // create the array with your numbers
            Console.WriteLine("Here is your sequence array : ");
            foreach (int element in sequence)
            {
                Console.Write(sequence[element] + ";");
            }
            Console.WriteLine("\nChoose a size under 10 for your array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("Write an array of "+ length + " integers");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            //comparing numbers
            bool appearing = true;

            if (sequence.Contains(array[0]) == false)
            {
                Console.WriteLine("answer : " + false);
            }
            else
            {
                int index = 0;
                for(int i = 0; i < sequence.Length; i++)
                {
                    if(sequence[i] == array[0])
                    {
                        index = i;
                    }
                }
                for (int j = 1; (j < array.Length) && appearing == true; j++)
                {
                    if (sequence[index + j] != array[j])
                    {
                        appearing = false;
                    }
                }

                Console.WriteLine("answer : " + appearing);
            }


            
        }
        public static void Question3a()
        {
            Console.WriteLine("Write a character: ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nASCII Value of " + c + " " + Convert.ToInt32(c));
        }
        public static void Question3()
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            string sReversed = "";
            for(int i = 0; i < s.Length; i++ )
            {
                sReversed += s[s.Length-1-i];
            }
            Console.WriteLine("the string reversed : " + sReversed);
        }
        public static void Question4()
        {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            int occ = 0;
            string compressString = "";
            for(int i =0; i < s.Length-1; i++ )
            {
                if(s[i] == s[i+1])
                {
                    occ++;
                }
                else
                {
                    compressString += s[i];
                    compressString += occ+1;
                    occ = 0;
                }
            }
            Console.WriteLine("The compress string is : " + compressString);
        }
        public static void Question5()
        {
            List<int> armstrongNumbers = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                if(i <10)
                {
                    if(Math.Pow(i,3) == i)
                    {
                        armstrongNumbers.Add(i);
                    }
                }
                if(i<100)
                {
                    int firstDigit = i % 10;
                    int secondDigit = (i % 100 - firstDigit) / 10;

                    if (Math.Pow(firstDigit,3) + Math.Pow(secondDigit,3) == i)
                    {
                        armstrongNumbers.Add(i);
                    }
                }
                if(i>=100)
                {
                    int firstDigit = i%10;
                    int secondDigit = (i%100 -firstDigit) /10;
                    int thirdDigit = (i - secondDigit - firstDigit) / 100;

                    if (Math.Pow(firstDigit,3) + Math.Pow(secondDigit,3) + Math.Pow(thirdDigit,3) == i)
                    {
                        armstrongNumbers.Add(i);
                    }
                }
            }
            foreach (int element in armstrongNumbers)
                Console.WriteLine(element + ";");
        }
        public static void Question6()
        {
            Console.WriteLine("\nChoose a size for your array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("Write an array of " + length + " integers");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            var occur = new List<KeyValuePair<int, int>>();
            //occur.Add(new KeyValuePair<int, int>(array[0], array.Count(x => x == array[0])));
            for(int i = 0; i < array.Length; i++)
            {
                occur.Add(new KeyValuePair<int, int>(array[i], array.Count(x => x == array[i])));
            }
            foreach (KeyValuePair<int, int> keyValuePair in occur)
                Console.WriteLine(keyValuePair + " ; ");
        }
        public static void Question7()
        {
            Console.WriteLine("Enter a number");
            int nb = Convert.ToInt32(Console.ReadLine());
            int sum = 1;

            for (int i = 1; i <= nb; i++)
                sum *= i;

            Console.WriteLine("The factorial is : " + sum);
        }
        public static void Question8()
        {
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();
            int cmp = 0;
            for(int i = 0; i < sentence.Length;i++)
            {
                if (sentence[i] == ' ')
                    cmp++;
            }
            Console.WriteLine("There are " + cmp + " spaces in the sentence");
        }
        public static void Question9()
        {
            Console.WriteLine("Enter 3 names");
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            string n3 = Console.ReadLine();
            Person[] list = { new Person(n1), new Person(n2), new Person(n3) };
            foreach (Person p in list)
                Console.WriteLine(p.ToString());
        }

    }
}
