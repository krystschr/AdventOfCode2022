namespace Day_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var instance = new Program();
            Input[] inputGame1 = new Input[3];
            Input[] inputGame2 = new Input[3];
            string[] input = File.ReadAllLines(@"../../../input.txt");
            int myTotalScore1 = 0;
            int myTotalScore2 = 0;
            foreach (string line in input)
            {
                for(int i = 0; i < line.Length; i++)
                {
                    if (line[i] == 'A' || line[i] == 'X')
                        inputGame1[i] = Input.Rock;
                    if (line[i] == 'B' || line[i] == 'Y')
                        inputGame1[i] = Input.Paper;
                    if (line[i] == 'C' || line[i] == 'Z')
                        inputGame1[i] = Input.Scissors;
                }

                if (line[0] == 'A')
                {
                    inputGame2[0] = Input.Rock;
                    if (line[2] == 'X')
                        inputGame2[2] = Input.Scissors;
                    if (line[2] == 'Y')
                        inputGame2[2] = Input.Rock;
                    if (line[2] == 'Z')
                        inputGame2[2] = Input.Paper;
                }
                if (line[0] == 'B')
                {
                    inputGame2[0] = Input.Paper;
                    if (line[2] == 'X')
                        inputGame2[2] = Input.Rock;
                    if (line[2] == 'Y')
                        inputGame2[2] = Input.Paper;
                    if (line[2] == 'Z')
                        inputGame2[2] = Input.Scissors;
                }
                if (line[0] == 'C')
                {
                    inputGame2[0] = Input.Scissors;
                    if (line[2] == 'X')
                        inputGame2[2] = Input.Paper;
                    if (line[2] == 'Y')
                        inputGame2[2] = Input. Scissors;
                    if (line[2] == 'Z')
                        inputGame2[2] = Input.Rock;
                }

                (int, int) result1 = instance.PlayTheGame(inputGame1[0], inputGame1[2]);
                (int, int) result2 = instance.PlayTheGame(inputGame2[0], inputGame2[2]);
                myTotalScore1 += result1.Item2;
                myTotalScore2 += result2.Item2;
            }
            Console.WriteLine(myTotalScore1);
            Console.WriteLine(myTotalScore2);
        }

        public (int, int) PlayTheGame(Input a, Input b) 
        {
            int playerOne = (int)a, playerTwo = (int)b;
            switch (a)
            {
                case Input.Rock:
                    if (b == Input.Rock)
                    {
                        playerOne += 3; 
                        playerTwo += 3;
                    }
                    if (b == Input.Paper) 
                        playerTwo += 6;
                    if (b == Input.Scissors) 
                        playerOne += 6;
                    break;
                case Input.Paper:
                    if (b == Input.Paper)
                    {
                        playerOne += 3;
                        playerTwo += 3;
                    }
                    if (b == Input.Scissors)
                        playerTwo += 6;
                    if (b == Input.Rock)
                        playerOne += 6;
                    break;
                case Input.Scissors:
                    if (b == Input.Scissors)
                    {
                        playerOne += 3;
                        playerTwo += 3;
                    }
                    if (b == Input.Rock)
                        playerTwo += 6;
                    if (b == Input.Paper)
                        playerOne += 6;
                    break;
            }
            return (playerOne, playerTwo);
        }
        public enum Input
        {
            Rock = 1,
            Paper = 2,
            Scissors = 3
        }
    }
}