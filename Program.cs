
public class Program
{
    static private int INDICE, SOMA, K;
    static void Main(string[] args)
    {
        Atividade01();
        Atividade02();
        Atividade03();
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

    //Desafio 02
    static private void Atividade02()
    {
        Console.WriteLine("Insira um número: ");
        int n = Convert.ToInt16(Console.ReadLine());

        /*Testando o resultado
        for (int i = 0; i <= 35; i++){
            if (VerificarFibo(i)) Console.WriteLine(i + " pertence a sequência de Fibonacci");
            else Console.WriteLine(i + " não pertence a sequência de Fibonacci");
        }*/

        if (VerificarFibo(n)) Console.WriteLine(n + " pertence a sequência de Fibonacci");
        else Console.WriteLine(n + " não pertence a sequência de Fibonacci");
    }

    static private void Atividade03()
    {
        Console.WriteLine("Insira um texto: ");
        string a = Console.ReadLine();

        Console.Write("Invertida: ");
        char[] letras = a.ToCharArray();

        int tamanho = letras.Length;

        for (int i = 0; i < tamanho / 2; i++)
        {
            char tmp = letras[i];
            letras[i] = letras[tamanho - i - 1];
            letras[tamanho - i - 1] = tmp;
        }

        Console.WriteLine(new string(letras));
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