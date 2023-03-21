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
            string[] lines = File.ReadAllLines(@"\RoadFiles");
            for (int i = 0; i < lines.Length; i++)
                Console.WriteLine(lines[i]);
        }
    }
}
