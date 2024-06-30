namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddNumber = 0;
            int evenNumber = 0;


            for (int i = 1; i <= n; i ++)
            {
                int currNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 1)
                    oddNumber += currNumber;
                else
                    evenNumber += currNumber;
                             
            }

            if (oddNumber == evenNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddNumber}");
            }
            
            else
            {
                
                Console.WriteLine("No");
                Console.WriteLine($"Diff ={Math.Abs(oddNumber - evenNumber)}");
            }
                                                                           
           
            






















         
        }
    }
}
