
public class Program
{
    static private int INDICE, SOMA, K;
    static void Main(string[] args)
    {
        Somar();
    }

    static private void Somar()
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
}