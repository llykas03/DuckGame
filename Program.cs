namespace DuckShootingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicijalizacija
            Random random = new Random();
            int totalDucks = 8;
            int bullets = 20;
            int ducksKilled = 0;
            int[] duckPositions = new int[totalDucks];

            // Dodeljivanje random pozicija patkama
            for (int i = 0; i < totalDucks; i++)
            {
                duckPositions[i] = random.Next(1, 6);
            }

            // Početak igre
            Console.WriteLine("Dobrodošli u lov na patke!");
            Console.WriteLine("Imate 20 metaka. Unesite broj pozicije (1-5) da biste pucali.");

            while (bullets > 0 && ducksKilled < totalDucks)
            {
                Console.WriteLine("\nPatke kvacu...");
                for (int i = 0; i < totalDucks; i++)
                {
                    Console.Write("Quack ");
                }

                Console.Write("\nUnesite broj pozicije: ");
                int playerGuess = int.Parse(Console.ReadLine());

                bool hit = false;
                for (int i = 0; i < totalDucks; i++)
                {
                    if (duckPositions[i] == playerGuess)
                    {
                        Console.WriteLine("Bang! Pogodili ste patku!");
                        ducksKilled++;
                        hit = true;
                        break;
                    }
                }

                if (!hit)
                {
                    Console.WriteLine("Promašili ste!");
                }

                bullets--;
            }

            // Kraj igre
            if (ducksKilled == totalDucks)
            {
                Console.WriteLine("Čestitamo! Ubili ste sve patke!");
            }
            else
            {
                Console.WriteLine("Game over! Ponestalo vam je metaka.");
            }
        }
    }
}