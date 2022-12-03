namespace Day_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Elf> elfs = new List<Elf>();
            string[] input = File.ReadAllLines(@"../../../input.txt");
            int summary = 0;
            int maxCalories = 0;
            foreach (string line in input)
            {
                if (string.IsNullOrEmpty(line))
                {
                    elfs.Add(new Elf { CaloriesSummary = summary });
                    summary = 0;
                }
                else
                {
                    summary = summary + int.Parse(line);
                }
            }
            summary= 0;
            IEnumerable<Elf> topThree = elfs.OrderByDescending( e => e.CaloriesSummary).Take(3);
            foreach (Elf el in topThree) { summary = summary + el.CaloriesSummary; }
            Console.WriteLine(summary);
            Console.ReadLine();
        }
    }

    class Elf
    {
        public int CaloriesSummary { get; set; }
    }
}