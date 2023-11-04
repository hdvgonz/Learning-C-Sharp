namespace RockPaperScissors_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rps("rock", "rock"));

            Console.ReadKey();
        }

        public static string Rps(string p1, string p2)
        {
            string msg = "";
            switch (p1)
            {
                case "scissors":
                    if (p1.Equals(p2)) return msg = "Draw!";
                    if (p1.Equals("scissors") && (p2.Equals("rock"))) return msg = "Player 2 won!";
                    msg = "Player 1 won!";
                    break;
                case "rock":
                    if (p1.Equals(p2)) return msg = "Draw!";
                    if (p1.Equals("rock") && (p2.Equals("paper"))) return msg = "Player 2 won!";
                    msg = "Player 1 won!";
                    break;
                case "paper":
                    if (p1.Equals(p2)) return msg = "Draw!";
                    if (p1.Equals("paper") && (p2.Equals("scissors"))) return msg = "Player 2 won!";
                    msg = "Player 1 won!";
                    break;
            }

            return msg;
        }
    }
}

/** 
 * Rock Paper Scissors
Let's play! You have to return which player won! In case of a draw return Draw!.

Examples(Input1, Input2 --> Output):

"scissors", "paper" --> "Player 1 won!"
"scissors", "rock" --> "Player 2 won!"
"paper", "paper" --> "Draw!"
 * */