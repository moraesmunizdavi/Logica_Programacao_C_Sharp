namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[10];

            Console.WriteLine("Digite as notas dos alunos:");
            Random sorteio = new Random();
            for (int i = 0; i < notas.Length; i++)
            {
                // Console.Write($"Aluno {i + 1}: ");
                // notas[i] = int.Parse(Console.ReadLine());
                notas[i] = sorteio.Next(0, 11); // Gera notas aleatórias entre 0 e 100
            }

            int soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }
            double media = (double)soma / notas.Length;
            Console.WriteLine($"A média das notas é: {media}");

            int maior = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > maior) maior = notas[i];

            }
            Console.WriteLine($"A maior nota é: {maior}");

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < media)
                {
                    Console.WriteLine($"Aluno {i + 1} tem nota abaixo da média: {notas[i]}");
                }
            }
        }
    }
}
