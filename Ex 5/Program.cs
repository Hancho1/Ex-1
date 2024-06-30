namespace Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = 0;


            // Calculations 
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num >= max)
                    max = num;       
            }

            // Output
            if ( sum - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum - max}"); // or max 
            }
            else
            { 
                Console.WriteLine("No");
                int difference = Math.Abs(max - (sum - max));
                Console.WriteLine($"Diff = {difference}"); // or {max - sum]
            }



        }
    }
}
