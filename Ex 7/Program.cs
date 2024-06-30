namespace Ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            int age = int.Parse(Console.ReadLine());
            double washingMashinePrice = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            double sum = 0;
            int moneyForBirthday = 10;

            // Calcullations 
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyForBirthday += 10;
                    sum += moneyForBirthday;

                }
                else
                {

                    sum += priceToy;

                }



            }
            // Output
            if (sum >= washingMashinePrice)
            {
                double moneyLeft = sum - washingMashinePrice;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                double moneyNeeded = washingMashinePrice - sum;
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }




        }
    }
}
