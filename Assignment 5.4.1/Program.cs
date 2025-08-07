namespace Assignment_5._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test = 1234;

            displayDigitsRecursively(test);
        }
        static void displayDigitsRecursively(int number)
        {
            if (number == 0) 
            {
                return;
            }

            displayDigitsRecursively(number / 10);

            Console.WriteLine(number % 10);
        }
    }
}
