namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum using generics program");

            FindMaximum findMaximum = new FindMaximum();
            int max = findMaximum.MaxOfThree(09, 18, 27);
            Console.WriteLine("Maximum is "+ max);
        }
    }
}