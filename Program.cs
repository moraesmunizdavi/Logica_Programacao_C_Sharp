#region Estrutura Básica de Código
namespace Logica_Programacao_CSharp
{
    internal class Logica_C_Sharp
    {
        static void Main(string[] args)
        #endregion

      #region Declaração de Variáveis
        {

            int a = 7;
            int b = 5;
            double c = 3.5;
            float d = 2.5f;
            #endregion

          #region Registro de Variáveis

            Console.WriteLine($"O valor de a é: {a}");
            Console.WriteLine($"O valor de b é: {b}");
            #endregion

            #region  If e Else (Maior ou Menor Número)

            if (a < 5)
            {
                Console.WriteLine("A é menor que cinco");
            }

            else
            {
                Console.WriteLine("A é maior ou igual a 5");
            }
            #endregion

            #region If e Else (Idade)
            int idade = 19;

            if (idade < 12)
            {
                Console.WriteLine("Criança");
            }

            else if (idade < 18)
            {
                Console.WriteLine("Adulto");
            }

            else if (idade < 60)
            {
                Console.WriteLine("Idoso");
            }
            #endregion

            #region Or (||) e And (&&)
            if (a < 5 || b > 10)
            {
                Console.WriteLine("Pelo menos um dos testes é verdadeiro");
            }
            if (a > 5 && b < 10)
            {
                Console.WriteLine("Os dois testes são verdadeiros");
            }
            #endregion

            #region For 
            // Quando o programa souber quanto contar antes de iterar
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i} ");
            }
            #endregion

            #region While

            Console.WriteLine();

            string login = "";
            string senha = "";
            int tentativas = 0;
            

            while (login != "FECAP" || senha != "ABC")
            // Quando o programa não souber quanto contar antes de iterar
            {
                tentativas++;
                if (tentativas > 3)
                {
                    Console.WriteLine("Tentativas Excedidas, Login Bloqueado");
                    break;
                }
                Console.Write("Digite seu login: ");
                login = Console.ReadLine();
                Console.Write("Digite sua senha: ");
                senha = Console.ReadLine();

                if (senha != "ABC" || login != "FECAP")
                {
                    Console.WriteLine("Erro.");
                }
                else
                {
                    Console.WriteLine("Login efetuado com sucesso.");
                }

            }
            #endregion

            #region Array (Vetor)
            int[] x = { 1, 2, 3 };
        }
    }
    }
            #endregion  





