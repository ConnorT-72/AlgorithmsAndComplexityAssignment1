﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmsAndComplexityAssignment1
{
    class Program
    {
        

		public static void Main(string[] args)
		{








			Array theLines;


			string[] lines = File.ReadAllLines("Road1-256.txt");
			lines = new string[lines.Length];
			lines = lines.ToArray();
			theLines = new string[lines.Length];
			Console.WriteLine(lines);
			
			int[] values = new int[theLines.Length];
			Console.WriteLine("Not sorted:");

            char userKeyPress;
            do
            {
                Console.WriteLine("Please input your number: ");
                userKeyPress = Console.ReadKey().KeyChar;
            }
            while (values.Contains(userKeyPress));
			if (values.Contains(userKeyPress))
			{
				Console.WriteLine("Found");
				Console.ReadLine();
			}
			else
				Console.WriteLine("" +
					"Value not found");
				





            //bubble Sorting
            int[] bubbled = Sort.bubble(values);
			Console.WriteLine("Bubble Sorted:");
			for (int i = 0; i < bubbled.Length; i++)
			{
				Console.WriteLine(bubbled[i]);
			}
			//sort into every 10th value 
			int[] selected = Sort.selection(values);
			Console.WriteLine("Sorted:");
			for (int i = 0; i < selected.Length; i++)
			{
				Console.WriteLine(selected[i]);
			}
			//Insert sorting
			int[] inserted = Sort.insertion(values);
			Console.WriteLine("Insertion Sorted:");
			for (int i = 0; i < inserted.Length; i++)
			{
				Console.WriteLine(bubbled[i]);
			}



            






            Console.ReadLine();
		}

	}
}
