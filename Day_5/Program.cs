using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Day_5
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            int whichProgram = 1;

            Stack<string>[] stacks = new Stack<string>[9];
            for (int i = 0; i < stacks.Length; i++)
            {
                stacks[i] = new Stack<string>();
            }
            string[] input = File.ReadAllLines(@"../../../input.txt");
            for(int i = 7; i >= 0; i--)
            {
                for (int j = 0; j < stacks.Length; j++)
                {
                    if(Char.IsLetter(input[i][1 + 4 * j]))
                        stacks[j].Push(input[i][1+4*j].ToString());
                }
            }
            for(int i = 10; i < input.Length; i++)
            {
                var numbers = Regex.Matches(input[i], @"\d+");
                int howMany = int.Parse(numbers[0].Value);
                int fromWhere = int.Parse(numbers[1].Value);
                int where = int.Parse(numbers[2].Value);
                if (whichProgram == 0)
                {
                    for (int j = 0; j < howMany; j++)
                    {
                        stacks[where - 1].Push(stacks[fromWhere - 1].Pop());
                    }
                }
                if (whichProgram == 1)
                {
                    Stack<string> stack = new Stack<string>();
                    for (int j = 0; j < howMany; j++)
                    {
                        stack.Push(stacks[fromWhere - 1].Pop());
                    }
                    for (int j = 0; j < howMany; j++)
                    {
                        stacks[where - 1].Push(stack.Pop());
                    }
                }
            }
            foreach(var stack in stacks) { Console.Write(stack.Peek().ToString()); }
        }
    }
}