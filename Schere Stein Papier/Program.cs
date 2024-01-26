namespace Schere_Stein_Papier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer;
            string inputComputer;
            int randomNumber;
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreComputer = 0;

                while (scorePlayer < 3 && scoreComputer < 3)
                {

                    Console.WriteLine("Wähle Schere, Stein oder Papier");
                    inputPlayer = Console.ReadLine();


                    Random random = new Random();
                    randomNumber = random.Next(1,4);

                    switch (randomNumber)
                    {
                        case 1:
                            inputComputer = "Schere";
                            Console.WriteLine("Computer hat Schere gewählt\n");
                            if (inputPlayer == "Schere")
                            {
                                Console.WriteLine("Unentschieden\n");
                            }
                            else if (inputPlayer == "Stein")
                            {
                                Console.WriteLine("Stein gewinnt\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Papier")
                            {
                                Console.WriteLine("Schere gewinnt\n");
                                scoreComputer++;
                            }
                            break;

                        case 2:
                            inputComputer = "Stein";
                            Console.WriteLine("Computer hat Stein gewählt\n");
                            if (inputPlayer == "Stein")
                            {
                                Console.WriteLine("Unentschieden\n");
                            }
                            else if (inputPlayer == "Schere")
                            {
                                Console.WriteLine("Stein gewinnt\n");
                                scoreComputer++;
                            }
                            else if (inputPlayer == "Papier")
                            {
                                Console.WriteLine("Papier gewinnt \n");
                                scorePlayer++;
                            }
                            break;

                        case 3:
                            inputComputer = "Papier";
                            Console.WriteLine("Computer hat Papier gewählt\n");
                            if (inputPlayer == "Papier")
                            {
                                Console.WriteLine("Unentschieden\n");
                            }
                            else if (inputPlayer == "Schere")
                            {
                                Console.WriteLine("Schere gewinnt\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Stein")
                            {
                                Console.WriteLine("Papier gewinnt\n");
                                scoreComputer++;
                            }
                            break;

                    }

                    Console.WriteLine("Score - Spieler: " + scorePlayer + ", Computer: " + scoreComputer);
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Spieler gewinnt");
                }
                else if (scoreComputer == 3)
                {
                    Console.WriteLine("Computer gewinnt");
                }
                else
                {

                }
                

                Console.WriteLine("Möchtest du erneut spielen? (j/n)");
                string loop = Console.ReadLine();
                if (loop == "j")
                {
                    playAgain = true;
                }
                else if (loop == "n")
                {
                    playAgain= false;
                }
            }           
        }
    }
}
