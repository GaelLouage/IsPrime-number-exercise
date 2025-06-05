internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(IsPrime(7));
    }

    public static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        var counter = 0;
        for (int i = 1; i <= n; i++) 
        {
         
            if (n % i  == 0) 
            {
                counter++;
            }  
        }
        return counter == 2; 
    }
}