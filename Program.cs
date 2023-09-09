namespace Aula30;

class Program
{
    static void Main()
    {
        var numeroFibo = new List<int> { 1, 1 };

        

        while (numeroFibo.Count <= 30)
        {
            var numeroAnterior1 = numeroFibo[numeroFibo.Count - 1];
            var numeroAnterior2 = numeroFibo[numeroFibo.Count - 2];

            var item = numeroAnterior1 + numeroAnterior2;

            numeroFibo.Add(item);
        }

        foreach(var item in numeroFibo) 
        {
            Console.WriteLine($"A sequencia é: {item}");
        }

    }
}