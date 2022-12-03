namespace Day_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Elf> elfs = new List<Elf>();
            string[] input = File.ReadAllLines(@"../../../input.txt");
            int summary = 0;
            int maxCalories = 0;
            foreach(string line in input)
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
            foreach(Elf elf in elfs)
            {
                if(elf.CaloriesSummary > maxCalories)
                    maxCalories= elf.CaloriesSummary;
            }
            Console.WriteLine(maxCalories);
            Console.ReadLine();
        }
    }

    class Elf
    {
        public int CaloriesSummary { get; set; }
    }
}