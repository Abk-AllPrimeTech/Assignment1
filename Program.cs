using System;
using System.Collections.Generic;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //DetectDatatype();

            //2----MultiplicationMethod implementation------\\
            //Console.WriteLine("Enter FirstParam in (string)");
            //string firstParam = Console.ReadLine();

            //Console.WriteLine("Enter SecondParam (int)");
            //string secondParam = Console.ReadLine();
            //bool check = int.TryParse(secondParam, out int secondParamValue);
            //if (check)
            //{
            //    var sum1 = MultiplicationMethod(firstParam, secondParamValue);
            //    Console.WriteLine($"The sum of the two values is = {sum1}");
            //}   
            //else
            //    Console.WriteLine("Second Param Input not in correct format, please try again");

            //3-------------------------------------------------\\
            //Console.WriteLine("Enter a value to convert");
            //string input = Console.ReadLine();
            //DatatypeConversion(input);

            //5--------------------------------------------------\\
            //----- CheckEvenOrOdd--------------\\
            //CheckEvenOrOdd();

            //--------------------------------------------------\\

            //--------------------------------------------------\\
            //PrintEvenNumbers();
            //--------------------------------------------------\\

            //-------------------------------------------------\\
                //BreakAtCondition(4);
            //------------------------------------------------\\

            //----------------------------------------------\\
            //TimesTable(1);
            //-----------------------------------------------\\
        }

        #region METHODS

        /// <summary>
        /// Used to Detect Datatype of a variable
        /// 
        /// </summary>
        /// <param></param>
        /// <returns>prints the value od the data type on the console</returns>
        public static void DetectDatatype()
        {
            Console.WriteLine("Enter a number or a string");
            var input = Console.ReadLine();
            try
            {
                if(input != null)
                {
                    if (int.TryParse(input, out var intDatatype))
                    {
                        Console.WriteLine($"This is an integer and the value is = {intDatatype}");
                    }
                    else if (double.TryParse(input, out var doubleDatatype))
                    {
                        Console.WriteLine($"This is double datatype and the value is = {doubleDatatype}");
                    }
                    else if (char.TryParse(input, out var characterDatatype))
                    {
                        Console.WriteLine($"This is an character datatype and the value is = {characterDatatype}");
                    }
                    else if (float.TryParse(input, out var floatDataType))
                    {
                        Console.WriteLine($"This is an character datatype and the value is = {floatDataType}");
                    }
                    else if (long.TryParse(input, out var longDatatype))
                    {
                        Console.WriteLine($"This is an character datatype and the value is = {longDatatype}");
                    }
                    else if (input.GetType() == typeof(string) && input.Length > 0)
                    {
                        Console.WriteLine($"This is string datatype and the value is = \"{input}\"");

                    }
                    else if (input.GetType() == typeof(string) && input.Length == 0)
                    {
                        Console.WriteLine($"The input is not in a correct format, please try again");
                    }
                    else
                    {
                        Console.WriteLine($"This is {input.GetType()} and the value is {input}");
                    }
                }
            }
            catch(Exception ex)
            {
                var errorMessage = ex.Message;
                Console.WriteLine(errorMessage);
            }
        }


        /// <summary>
        /// Used to Multiply Two paramaters
        /// </summary>
        /// <param name="firstParam">Takes a string as an input</param>
        /// <param name="secondParam">Takes an integer input</param>
        /// <returns>The product of the two parameter passed </returns>
        public static int MultiplicationMethod(string firstParam, int secondParam)
        {
            int sum = 0;
            try
            {
                
                if(int.TryParse(firstParam, out var intValue))
                {
                     sum = intValue * secondParam;
                }
                else
                {
                    sum = firstParam.Length * secondParam;
                }
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                Console.WriteLine(message);
                return 0;
            }
            return sum;
        }


        /// <summary>
        /// Used to convert datatype of passed in value
        /// </summary>
        /// <param>Takes in value to convert</param>
        /// <returns>Print the converted to the console</returns>
        public static void DatatypeConversion(string input)
        {
            try
            {
                if (int.TryParse(input, out var intValue))
                {
                    intValue.ToString();
                    Console.WriteLine($"The value is converted to a string and it is \"{intValue}\"");
                }
                else
                    Console.WriteLine($"Value {input} cannot be converted, please try again");

            }catch(Exception ex)
            {
                Console.WriteLine($"an error occured  {ex}");
            }
        }

        /// <summary>
        /// Used to detect even and odd numbers
        /// </summary>
        /// <param name="input">Provide a number to detect</param>
        /// <returns>Returns "even" if number is even and "odd" if number is odd</returns>
        public static string ReturnEvenOrOdd(int input)
        {
            string TypeOfNumber = string.Empty;
            try
            {
                if (input > 0) 
                {
                    if ( input % 2 == 0)
                    {
                        TypeOfNumber = "even";
                    }
                    else
                    {
                        TypeOfNumber = "odd";
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry, please try again");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured" + ex);
                return string.Empty;
            }
            return TypeOfNumber;
            
        }

        /// <summary>
        /// Used to check the retun type of the ReturnEvenOrOdd method
        /// </summary>
        /// <param></param>
        /// <returns>Print "even" if number is even and "odd" if number is odd to the console</returns>
        public static void CheckEvenOrOdd()
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            if (input != null && int.TryParse(input, out int inputValue))
                Console.WriteLine(ReturnEvenOrOdd(inputValue));
            else
                Console.WriteLine("Value entered not in a correct format, please enter an integer value");
        }

        /// <summary>
        /// Used to check the retun type of the ReturnEvenOrOdd method
        /// </summary>
        /// <param></param>
        /// <returns>Print "even" if number is even and "odd" if number is odd to the console</returns>
        public static void PrintEvenNumbers()
        {
            for (int i = 1; i <= 100 ; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Used to check for a certain condition to break a loop
        /// </summary>
        /// <param name="input">Provide the nummber you wish to break the loop at</param>
        /// <returns>Prints all numbers before the break condition</returns>
        public static void BreakAtCondition(int input)
        {
           int start = 0;
           bool KeepCounting = true;
            while (KeepCounting)
            {
                start++;
                Console.WriteLine(start);
                if (start == input)
                {
                    KeepCounting = false;
                    break;
                }
                else
                {
                    continue;
                }
            }
            //Console.WriteLine(start);
        }

        /// <summary>
        /// Used to create times table
        /// </summary>
        /// <param name="input">Provide value to use for cretion of the times table</param>
        /// <returns>Prints out the times table  using the intended value</returns>
        public static void TimesTable(int value)
        {
            List<int> TwlveTimes = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            foreach (var item in TwlveTimes)
            {
                var result = item * value;
                Console.WriteLine($"{item} X {value} = {result}");
            }
        }

        #endregion METHODS

    }
}
