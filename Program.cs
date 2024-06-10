using Jogo_Da_Forca.Modos;

class Program
{
    private static void Main(string[] args)
    {
        void Menu()
        {
            Console.WriteLine(@"
░░█ █▀█ █▀▀ █▀█   █▀▄ ▄▀█   █▀▀ █▀█ █▀█ █▀▀ ▄▀█
█▄█ █▄█ █▄█ █▄█   █▄▀ █▀█   █▀░ █▄█ █▀▄ █▄▄ █▀█");

            Console.WriteLine("\nPressione ENTER para começar");

            while (true)
            {
                var k = Console.ReadKey();
                if (k.Key == ConsoleKey.Enter)
                {
                    SinglePlayer.Play();
                }
            }
        }
        Menu();
    }

}