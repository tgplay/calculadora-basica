using System;

class Program
{
    static void Main(string[] args)
    {
        // Teste da função com dois números
        Console.WriteLine("Digite o primeiro número (a):");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número (b):");
        double b = double.Parse(Console.ReadLine());

        ExibirOperacoesBasicas(a, b);
    }

    static void ExibirOperacoesBasicas(double a, double b)
    {
        // Adição
        Console.WriteLine($"Adição: {a} + {b} = {a + b}");
        
        // Subtração
        Console.WriteLine($"Subtração: {a} - {b} = {a - b}");
        
        // Multiplicação
        Console.WriteLine($"Multiplicação: {a} * {b} = {a * b}");
        
        // Divisão com verificação de divisão por zero
        if (b != 0)
        {
            Console.WriteLine($"Divisão: {a} / {b} = {a / b}");
        }
        else
        {
            Console.WriteLine($"Divisão: Não é possível dividir {a} por 0.");
        }
    }
}
