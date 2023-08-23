internal class Program
{
    private static void Main(string[] args)
    {
        /* Faça um procedimento recursivo que receba por parâmetro um vetor 𝑣𝑒𝑡 de
        números reais e, multiplique por −1 todos os elementos negativos desse vetor.
        Para esse exercício não se pode utilizar as estruturas de repetição (for, while e do
        while). */
        double[] vet = {1, -2, 5, -4, 7}; 
        int indice = 0;
        TornaPositivo(vet, indice);

        for(int i = 0; i < vet.Length; i++)
        {
            Console.Write($"{vet[i]} ");
        }
        
    }

    static void TornaPositivo(double[] vet, int i)
    {
        if (i < vet.Length)
        {
            if(vet[i] < 0)
            {
                vet[i] *= -1;
            }
            TornaPositivo(vet, i+1);
        }
    }
}