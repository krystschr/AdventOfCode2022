using System.Text.RegularExpressions;

namespace Day_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //PART 1
            string[] input = File.ReadAllLines(@"../../../input.txt");
            int summaryPartOne = 0;
            int summaryPartTwo = 0;
            foreach(string line in input)
            {
                string[] numbers = Regex.Split(line, @"\D+");
                
                int first = int.Parse(numbers[0]);
                int second = int.Parse(numbers[1]);
                int third = int.Parse(numbers[2]);
                int fourth = int.Parse(numbers[3]);
       
                if (first >= third && second <= fourth) { summaryPartOne++; }
                else if (first <= third && second >= fourth) { summaryPartOne++; }

                //PART TWO
                IEnumerable<int> firstRange = Enumerable.Range(first, second-first+1);
                IEnumerable<int> secondRange = Enumerable.Range(third, fourth-third+1);
                IEnumerable<int> sameElements = firstRange.Intersect(secondRange);

                if (sameElements.Any()) { summaryPartTwo++; }
            }
            Console.WriteLine($"Summary Part One: {summaryPartOne}");
            Console.WriteLine($"Summary Part Two: {summaryPartTwo}");
        }
    }
}