/*
Info 
Author: mr_raze 
Lang: CS
*/

using System;

class Program {
    static void Main() {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Generating Random Prediction...");

        var random = new Random();
        int[] randomNumbers = new int[3];
        for (int i = 0; i < 3; i++)
            randomNumbers[i] = random.Next(0, 25);

        Console.WriteLine("Random Numbers:");
        foreach (int number in randomNumbers) {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nGrid:");
        char[,] grid = new char[5, 5];
        for (int row = 0; row < 5; row++) {
            for (int col = 0; col < 5; col++) {
                grid[row, col] = '❌';
            }
        }

        foreach (int number in randomNumbers) {
            int row = number / 5;
            int col = number % 5;
            grid[row, col] = '✅'; 
        }

        for (int row = 0; row < 5; row++) {
            for (int col = 0; col < 5; col++) {
                Console.Write(grid[row, col] + "\t");
            }
            Console.WriteLine();
        }
    }
}
