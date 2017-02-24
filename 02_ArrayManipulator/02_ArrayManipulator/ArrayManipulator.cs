using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var newArray = new int[array.Length];
            var command = Console.ReadLine().Split(' ');

            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    if (int.Parse(command[1]) >= array.Length || int.Parse(command[1])<0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        newArray = ExchangeElements(array, int.Parse(command[1]));
                        array = newArray;
                    }
                }

                if (command[0] == "max" && command[1] == "even")
                {
                    var index = MaxEven(array);
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }

                if (command[0] == "max" && command[1] == "odd")
                {
                    var index = MaxOdd(array);
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }

                if (command[0] == "min" && command[1] == "even")
                {
                    var index = MinEven(array);
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }

                if (command[0] == "min" && command[1] == "odd")
                {
                    var index = MinOdd(array);
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }

                if (command[0] == "first" && command[2] == "even")
                {
                    if (int.Parse(command[1]) > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        var firstEven = FirstEven(array, int.Parse(command[1]));
                        Console.WriteLine("[{0}]", string.Join(", ", firstEven));
                    }
                }

                if (command[0] == "first" && command[2] == "odd")
                {
                    if (int.Parse(command[1]) > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        var firstOdd = FirstOdd(array, int.Parse(command[1]));
                        Console.WriteLine("[{0}]", string.Join(", ", firstOdd));
                    }
                }

                if (command[0] == "last" && command[2] == "even")
                {
                    if (int.Parse(command[1]) > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        var lastEven = LastEven(array, int.Parse(command[1]));
                        Console.WriteLine("[{0}]", string.Join(", ", lastEven));
                    }
                }

                if (command[0] == "last" && command[2] == "odd")
                {
                    if (int.Parse(command[1]) > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        var lastOdd = LastOdd(array, int.Parse(command[1]));
                        Console.WriteLine("[{0}]", string.Join(", ", lastOdd));
                    }
                }

                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));

        }

        public static int[] ExchangeElements(int[] arr, int index)
        {
            List<int> firstArr = new List<int>();
            List<int> secondArr = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i <= index)
                {
                    firstArr.Add(arr[i]);
                }
                else
                {
                    secondArr.Add(arr[i]);
                }
            }

            int[] newArr = new int[arr.Length];
            int count = 0;

            foreach (var element in secondArr)
            {
                newArr[count] = element;
                count++;
            }

            foreach (var element in firstArr)
            {
                newArr[count] = element;
                count++;
            }
            return newArr;
        }

        public static int MaxEven(int[] arr)
        {
            var maxEven = int.MinValue;
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                var currentNumber = arr[i];
                if (currentNumber >= maxEven && currentNumber % 2 == 0)
                {
                    maxEven = currentNumber;
                    index = i;
                }
            }
            return index;
        }

        public static int MaxOdd(int[] arr)
        {
            var maxOdd = int.MinValue;
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                var currentNumber = arr[i];
                if (currentNumber >= maxOdd && currentNumber % 2 != 0)
                {
                    maxOdd = currentNumber;
                    index = i;
                }
            }
            return index;
        }

        public static int MinEven(int[] arr)
        {
            var minEven = int.MaxValue;
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                var currentNumber = arr[i];
                if (currentNumber <= minEven && currentNumber % 2 == 0)
                {
                    minEven = currentNumber;
                    index = i;
                }
            }
            return index;
        }

        public static int MinOdd(int[] arr)
        {
            var minOdd = int.MaxValue;
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                var currentNumber = arr[i];
                if (currentNumber <= minOdd && currentNumber % 2 != 0)
                {
                    minOdd = currentNumber;
                    index = i;
                }
            }
            return index;
        }

        public static List<int> FirstEven(int[] arr, int maxCount)
        {
            int count = 0;
            var first = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    first.Add(arr[i]);
                    count++;
                }

                if (count == maxCount)
                {
                    break;
                }
            }

            return first;
        }

        public static List<int> FirstOdd(int[] arr, int maxCount)
        {
            int count = 0;
            var first = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    first.Add(arr[i]);
                    count++;
                }

                if (count == maxCount)
                {
                    break;
                }
            }

            return first;
        }

        public static List<int> LastEven(int[] arr, int maxCount)
        {
            int count = 0;
            var last = new List<int>();
            var lastEven = new List<int>();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0)
                {
                    last.Add(arr[i]);
                    count++;
                }

                if (count == maxCount)
                {
                    break;
                }
            }

            for (int i = last.Count - 1; i >= 0; i--)
            {
                lastEven.Add(last[i]);
            }

            return lastEven;
        }

        public static List<int> LastOdd(int[] arr, int maxCount)
        {
            int count = 0;
            var last = new List<int>();
            var lastOdd = new List<int>();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 != 0)
                {
                    last.Add(arr[i]);
                    count++;
                }

                if (count == maxCount)
                {
                    break;
                }
            }

            for (int i = last.Count - 1; i >= 0; i--)
            {
                lastOdd.Add(last[i]);
            }

            return lastOdd;
        }
    }
}
