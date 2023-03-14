/*  ArrayExamples
 *  
 *  A demonstration on the use or arrays and lists
 *  
 *  Revision History:
 *      Tony Theo... 2023.03.13:   Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UsingArrays();
            //ReferenceExamples();
            ListExamples();

            Console.ReadKey();
        }

        static void UsingArrays()
        {
            int sum = 0;
            int temp;
            int[] numbers = new int[5];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            // 1. Display all the values in the array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            // 2. Add 1 to each value in array and display 
            //
            // Sample Output:
            // 2 3 4 5 6 
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]++;
                Console.Write($"{numbers[i]} ");
            }

            // 3. Sum all the values in the given array
            //
            // Sample Output:
            // The sum is 20
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];  //sum += numbers[i];
            }

            Console.WriteLine($"\n\nThe sum is {sum}");

            // 4. Perform the following on the given array, then display
            //    the updated array values.
            //    
            //    - add 5 to the element at index 1
            //    - multiply the element at index 2 by element 
            //      at index 4, and place result back at index 2
            //    - subtract the element at index 1 from element 
            //      at index 0 and place result in at index 0
            //    - swap the elements at index 3 and index 4
            //    - output with a foreach loop
            //
            // Sample Output
            // -6 8 24 6 5
            numbers[1] = numbers[1] + 5;
            numbers[2] = numbers[2] * numbers[4];
            numbers[0] = numbers[0] - numbers[1];
            temp = numbers[4];
            numbers[4] = numbers[3];
            numbers[3] = temp;
            
            Console.WriteLine();

            DisplayArray( numbers );
        }

        static void ReferenceExamples()
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = array1;
            int[] array3 = new int[3];

            array1[0] = -1;
            array2[0] = -2;

            Console.WriteLine(array1[0]);
            Console.WriteLine(array2[0]);

            ModifyArray(array1);
            Console.WriteLine(array1[0]);

            array1.CopyTo(array3, 0);

            DisplayArray(array1);

            Console.WriteLine();

            DisplayArray(array3);

            array1[0] = 1;
            
            Console.WriteLine();

            DisplayArray(array1);

            Console.WriteLine();

            DisplayArray(array3);
        }

        static void ModifyArray(int[] methodArray)
        {
            methodArray[0] = 9;
        }

        static void DisplayArray(int[] displayArray)
        {
            foreach (int num in displayArray)
            {
                Console.Write(num + " ");
            }
        }

        static void ListExamples()
        {
            List<string> names = new List<string>();
            int players;
            string playerName;

            Console.Write("Enter number of players: ");
            players = Convert.ToInt16(Console.ReadLine());

            for(int i = 0; i < players; i++)
            {
                Console.Write("Enter player name: ");
                names.Add(Console.ReadLine());
            }

            Console.WriteLine("\nHere are your survivors");

            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nVote a player off the island");
            playerName = Console.ReadLine();    

            if(names.Contains(playerName))
            {
                names.Remove(playerName);
            }
            else
            {
                Console.WriteLine("That player does not exist");
            }

            Console.WriteLine("\nThe remaining players are:");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
