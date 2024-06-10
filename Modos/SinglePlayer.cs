namespace Jogo_Da_Forca.Modos;
public class SinglePlayer
{
    public static void Play()
    {
        string[] palavras = { "amora", "rato", "tuftzinho", "sorvete", "caracol", "lua", "banana", "pudim", "bicicleta", "floresta", "festa", "casaco", "cachorro" };
        Random random = new Random();
        int r = random.Next(palavras.Length);
        string palavraSecreta;

        void Jogo()
        {
            palavraSecreta = palavras[r];

            void Forca()
            {
                Validando(palavraSecreta, false, palavraSecreta.Length);

                bool Validando(string palavraSecreta, bool palavraDescoberta, int tentativas)
                {
                    int chances = palavraSecreta.Length;
                    tentativas = 0;
                    string palavraParcial = new string('_', palavraSecreta.Length);

                    while (chances > tentativas && !palavraDescoberta)
                    {
                        Console.Clear();
                        Console.WriteLine($"A palavra secreta tem {palavraSecreta.Length} letras\nVocê tem {chances} tentativas");
                        Console.WriteLine($@" J----|
 |    |
 O    |
/|\   |
/ \   |{palavraParcial}");
                        Console.Write("Chute uma letra:");
                        string chute = Console.ReadLine();
                        char chuteChar; char.TryParse(chute, out chuteChar);

                        if (palavraSecreta.Contains(chute))
                        {
                            for (int i = 0; i < palavraSecreta.Length; i++)
                            {
                                if (palavraSecreta[i] == chuteChar)
                                {
                                    palavraParcial = palavraParcial.Remove(i, 1).Insert(i, chute);

                                }
                            }
                        }
                        else { chances--; }

                        if (chances < 0)
                        {
                            Console.WriteLine("Perdeu"); break;
                        }
                        else if (!palavraParcial.Contains("_"))
                        {
                            palavraDescoberta = true;
                            break;
                        }
                    }
                    if (palavraDescoberta)
                    {
                        Console.Clear();
                        Console.Write($"Ganhou! A palavra era: {palavraParcial}\nJogar novamente?");
                    }
                    else { Console.WriteLine("Perdeu :(\nJogar Novamente?"); }

                    return palavraDescoberta;
                }
            }Forca();
        }Jogo();
    }
}

