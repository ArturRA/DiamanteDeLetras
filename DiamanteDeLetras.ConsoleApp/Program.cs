namespace DiamanteDeLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Diamond is unbreakable!");

                int tamanhoDoDiamante = 0;
                int letraParaDesenhar = 0;

                #region Validar entrada
                while (true)
                {
                    Console.Write("Digite uma letra maiuscula para desenhar o diamante: ");
                    letraParaDesenhar = Convert.ToChar(Console.ReadLine());

                    if (65 <= letraParaDesenhar && letraParaDesenhar  <= 90)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor digite uma letra valida.");
                        Console.WriteLine("Digite qualquer tecla para tentar novamente....");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                }
                #endregion

                tamanhoDoDiamante = (letraParaDesenhar - 65) * 2 + 1;
                int quantidadeDeSimbolosEmBranco = (tamanhoDoDiamante - 1) / 2;
                int quantidadeDeSimbolosDoDiamante = 1;
                int metadeDoDiamante = (tamanhoDoDiamante - 1) / 2;
                int primeiraLetra = 65;

                for (int i = 0; i < tamanhoDoDiamante; i++)
                {
                    #region Excreve espaço em branco
                    for (int j = 0; j < quantidadeDeSimbolosEmBranco; j++)
                    {
                        Console.Write(" ");
                    }
                    if (i < metadeDoDiamante)
                    {
                        quantidadeDeSimbolosEmBranco--;
                    }
                    else
                    {
                        quantidadeDeSimbolosEmBranco++;
                    }
                    #endregion

                    #region Escreve a "letra" "espaço em branco" "letra"
                    for (int j = 0; j < quantidadeDeSimbolosDoDiamante; j++)
                    {
                        if (j == 0 || j == (quantidadeDeSimbolosDoDiamante - 1))
                        {
                            Console.Write(Convert.ToChar(primeiraLetra));
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write($"    Quantidade de 'simbolos' nesta linha: {quantidadeDeSimbolosDoDiamante}");
                    if (i < metadeDoDiamante)
                    {
                        quantidadeDeSimbolosDoDiamante += 2;
                        primeiraLetra++;
                    }
                    else
                    {
                        quantidadeDeSimbolosDoDiamante -= 2;
                        primeiraLetra--;
                    }
                    #endregion

                    // Pula para a proxima linha
                    Console.WriteLine();
                }

                #region Conitinuar ou parar o programa
                string continuar = "";
                while (true)
                {
                    Console.Write("Deseja desenhar outro diamante (S/N)? ");
                    continuar = Console.ReadLine();

                    if (continuar == "S" || continuar == "s")
                    {
                        Console.WriteLine("Por favor digite um valor impar.");
                        Console.Clear();
                        break;
                    }
                    else if (continuar == "N" || continuar == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor digite uma opção valida.");
                    }

                }
                #endregion

                // Termina o programa
                if (continuar == "N" || continuar == "n")
                {
                    break;
                }
            }
        }
    }
}