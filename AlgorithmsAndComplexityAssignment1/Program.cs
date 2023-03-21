using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmsAndComplexityAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
			
			//Bubble Sorting
			int[] bubbled = Sort.bubble(values);
			Console.WriteLine("Bubble Sorted:");
			for (int i = 0; i < bubbled.Length; i++)
			{
				Console.WriteLine(bubbled[i]);
			}
			int[] selected = Sort.selection(values);
			Console.WriteLine("Selection Sorted:");
			for (int i = 0; i < selected.Length; i++)
			{
				Console.WriteLine(selected[i]);
			}
			//Insertion sorting
			int[] inserted = Sort.insertion(values);
			Console.WriteLine("Insertion Sorted:");
			for (int i = 0; i < inserted.Length; i++)
			{
				Console.WriteLine(bubbled[i]);
			}
			//keep the console open :P
			Console.ReadLine();
		}
            
    }
}
