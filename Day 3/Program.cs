namespace Day_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
            Console.WriteLine(sum);
        }
    }
}