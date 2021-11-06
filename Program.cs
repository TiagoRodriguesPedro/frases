using System;

namespace frases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // limpar a tela
             Console.Clear();
           // mudar a cor da letra para vermelho
             Console.ForegroundColor = ConsoleColor.Red;
           // exibir a primeira frase

            Console.WriteLine("voce erra todos os chutes");
            Console.WriteLine("tiago odrigues");

           // aguardar o usuario pressionar uma tecla
           Console.WriteLine("pressione uma tecla para continuar");
           Console.ReadKey();

           // mudar cor para azul
           Console.ForegroundColor = ConsoleColor.Blue;

           // exibir a segunda frase
           Console.WriteLine(" devagarinho vou chegar la ");
           Console.WriteLine("tiago pedro");

           // aguardar o usuario pressionar uma tecla
           Console.ReadKey();

           // mudar a cor para verde
           Console.ForegroundColor = ConsoleColor.Green;

           // aguarda o usuario pressionar uma tecla
           Console.ReadKey();

           // exibir a terceira frase
           Console.WriteLine("voando baixo mas sonhando alto");
           Console.WriteLine(" fé produçoes");

           // mudar a cor para azul
           Console.ForegroundColor = ConsoleColor.Blue;

           // limpar a tela 
           Console.Clear();

          // voltar a cor padrao
          Console.ResetColor();

        }
    }
}
