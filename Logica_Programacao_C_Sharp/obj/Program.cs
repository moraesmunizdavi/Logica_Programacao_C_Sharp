void ImprimirVetor(int[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine($"Produto {i + 1}: {vetor[i]}");
    }

    int SomarVetor(int[] vetor)
    {
        int total = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            total += total + vetor[i];
        }
        return total;
    }


    int[] GerarVetor(int qtde, int min, int max)
    {
        int[] vetor = new int[qtde];
        Random rnd = new Random();
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = rnd.Next(min, max);
        }
        return vetor;
    }

    int MaiorVetor(int []vetor)
    {
        int maior = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }
        return maior;
    }

    int[] estoque = GerarVetor(12, 0, 100);
    ImprimirVetor(estoque);
    int total = SomarVetor(estoque);
    Console.WriteLine("Total de Produtos em Estoque: " + total);
    int maior = MaiorVetor(estoque);
    Console.WriteLine("Maior quantidade em estoque: " + maior);
    Console.WriteLine("Quantidade de Estoque" + estoque[maior]);
}


