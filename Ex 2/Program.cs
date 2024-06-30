namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int leftNumber = 0;
            int rightNumber = 0;

            for (int i = 0; i < num; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                leftNumber += currNumber;
                

            }

            for (int i = 0;i < num; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                rightNumber += currNumber;
            }

            if (leftNumber == rightNumber)
            {
                Console.WriteLine($"Yes, sum = {leftNumber}");
            }

            if (rightNumber != leftNumber)
            {
                int finalSum = Math.Abs(rightNumber - leftNumber);
                Console.WriteLine($"No, diff = {finalSum}");
            }












        }
    }
}
