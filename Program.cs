
public class Program
{
    static private int INDICE, SOMA, K;
    static void Main(string[] args)
    {
        Atividade01();
        Atividade02();
    }

    //Desafio 01
    static private void Atividade01()
    {
        INDICE = 13;
        SOMA = 0;
        K = 0;
        
        while (K < INDICE)
        {
            K++;
            SOMA+=K;
        }

        Console.WriteLine(SOMA);
    } 

    static private void Atividade02()
    {
        Console.WriteLine("Insira um número: ");
        int n = Convert.ToInt16(Console.ReadLine());
        for (int i = 0; i <= 35; i++){
            if (VerificarFibo(i)) Console.WriteLine(i + " pertence a sequência de Fibonacci");
            else Console.WriteLine(i + " não pertence a sequência de Fibonacci");
        }
        if (VerificarFibo(n)) Console.WriteLine(n + " pertence a sequência de Fibonacci");
        else Console.WriteLine(n + " não pertence a sequência de Fibonacci");
    }

    static bool VerificarFibo(int n)
    {
        int x = 0;
        int y = 1;

        while (y < n)
        {
            int tmp = x;
            x = y;
            y = tmp + y;
        }

        return y == n;
    }
}