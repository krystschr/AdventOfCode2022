namespace Day_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //PART 1
            int sum = 0;
            string[] input = File.ReadAllLines(@"../../../input.txt");
            foreach (string line in input) 
            {     
                char[] rucksack = line.ToCharArray();
                var firstCompartment = rucksack.Take(rucksack.Length / 2).ToArray();
                var secondCompartment = rucksack.Skip(rucksack.Length / 2).ToArray();
                char[] commonItem = firstCompartment.Intersect(secondCompartment).ToArray();
                foreach(var item in commonItem)
                {
                    if (Char.IsLower(item))
                    {
                        sum = sum + (int)item - 96;
                    }
                    else if (Char.IsUpper(item))
                    {
                        sum = sum + (int)item - 38;
                    }
                }
            }
            Console.WriteLine($"Part 1 answear: {sum}");
            //PART 2
            sum = 0;
            for (int i = 0; i < input.Length; i += 3)
            {
                char[] firstElfsSack = input[i].ToCharArray();
                char[] secondElfsSack = input[i+1].ToCharArray();
                char[] thirdElfsSack = input[i+2].ToCharArray();
                char[] commonItem = firstElfsSack.Intersect(secondElfsSack).ToArray();
                commonItem = commonItem.Intersect(thirdElfsSack).ToArray();
                foreach (var item in commonItem)
                {
                    if (Char.IsLower(item))
                    {
                        sum = sum + (int)item - 96;
                    }
                    else if (Char.IsUpper(item))
                    {
                        sum = sum + (int)item - 38;
                    }
                }
            }
            Console.WriteLine($"Part 2 answear: {sum}");
        }
    }
}