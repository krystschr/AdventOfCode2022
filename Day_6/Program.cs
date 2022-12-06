namespace Day_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"../../../input.txt");
            List<char> chars = input[0].ToCharArray().ToList();
            bool itWorked = false;
            for(int i = 0; i < input[0].Length; i++)
            {
                List<char> fourLetters = chars.Skip(i).Take(4).ToList();
                List<char> fourteenLetters = chars.Skip(i).Take(14).ToList();

                if (fourLetters.Count == fourLetters.Distinct().Count() && !itWorked)
                {
                    itWorked= true;
                    Console.WriteLine(i + 4);
                }
                if (fourteenLetters.Count == fourteenLetters.Distinct().Count())
                {
                    Console.WriteLine(i + 14);
                }
            }
        }
    }
}