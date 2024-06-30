namespace Ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            int n = int.Parse(Console.ReadLine());
            int hikersMusala = 0;
            int hikersMonblan = 0;
            int hikersKilimandjaro = 0;
            int hikersK2 = 0;
            int hikersEverest = 0;

            // Calcullations
            

            for (int i = 0; i < n; i++)
            {
                double hikers = double.Parse(Console.ReadLine());
                hikers += n;

                if (hikersMusala < 5) hikersMusala++;
                else if (hikersMonblan < 12) hikersMonblan++;
                else if (hikersKilimandjaro < 25) hikersKilimandjaro++; 
                else if (hikersK2 < 40) hikersK2++;     
                else if (hikersEverest >= 41) hikersEverest++;

                // Output

                Console.WriteLine($"{(double)hikersMusala++ / n * 100:f2}%");
                Console.WriteLine($"{(double)hikersMonblan / n * 100:f2}%"); 
                Console.WriteLine($"{(double)hikersKilimandjaro / n * 100:f2}%");
                Console.WriteLine($"{(double)hikersK2 / n * 100:f2}%");
                Console.WriteLine($"{(double)hikersEverest / n * 100:f2}%");





            }

        }
    }
}
