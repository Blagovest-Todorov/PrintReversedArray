using System;
using System.Linq;

namespace ReadArrayStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrString = Console.ReadLine().Split().ToArray(); // read String Line /remove the space between strings and convert to Array
            string[] reversedArr = new string[arrString.Length];

            for (int i = 0; i < arrString.Length; i++)
            {                
                reversedArr[reversedArr.Length - 1 - i] = arrString[i];                
            }
            foreach (string item in reversedArr)
            {
                Console.Write(item + " ");
            }

        }
    }
}
