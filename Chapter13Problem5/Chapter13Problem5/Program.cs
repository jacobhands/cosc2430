/*
 * Jacob Hands
 * COSC 2430 001
 * 4-12-2015
 * Chapter 13 Problem 5 (page 890)
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13Problem5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            const int ROWS = 10;
            const int COLUMNS = 5;
            const int MIN = 1;
            const int MAX = 1000;
            ILogger logger = new Logger();
            NumberStore numsDb = new NumberStore("numbers.txt", COLUMNS);
            
            // Add random numbers to the number store
            for (int i = 0; i < ROWS*COLUMNS; i++)
            {
                numsDb.Add(rnd.Next(MIN, MAX + 1));
            }
            Console.WriteLine("Numbers about to go into file:");
            foreach (var line in numsDb.Numbers)
            {
                foreach (var i in line)
                {
                    Console.Write(i.ToString() + ", ");
                }
                Console.WriteLine();
            }
            Console.Write("\nPress any key.");
            Console.ReadKey();
            var numberList = numsDb.Numbers;
            // Attempt to save the numbers
            try
            {
                numsDb.Save();
            }
            catch (DirectoryNotFoundException ex)
            {
                logger.Log(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                logger.Log(ex.Message);
            }
            catch (IOException ex)
            {
                logger.Log(ex.Message);
                throw;
            }

            // Attempt to load the numbers
            try
            {
                numsDb.Numbers = null;
                numsDb.Load();
                var validRows = new List<bool>();
                bool rowValid;
                for (int i = 0; i < numberList.Count; i++)
                {
                    rowValid = true;
                    for (int j = 0; j < numberList[i].Count; j++)
                    {
                        if (numberList[i][j] != numsDb.Numbers[i][j])
                        {
                            rowValid = false;
                        }
                    }
                    validRows.Add(rowValid);
                }
                // Print rows
                Console.WriteLine("Numbers read from file:");
                foreach (var line in numsDb.Numbers)
                {
                    foreach (var i in line)
                    {
                        Console.Write(i.ToString() + ", ");
                    }
                    Console.WriteLine();
                }
                Console.Write("\nPress any key.");
                Console.ReadKey();
                // Print what rows are identical
                for (int i = 0; i < validRows.Count; i++)
                {
                    var row = validRows[i];
                    Console.WriteLine("Row[" + i + "] is identical to original: " + validRows[i]);
                }
                Console.WriteLine("\nPress any key.");
                Console.ReadKey();
                
            }
            catch (DirectoryNotFoundException ex)
            {
                logger.Log(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                logger.Log(ex.Message);
            }
            catch (IOException ex)
            {
                logger.Log(ex.Message);
                throw;
            }
        }
    }
}