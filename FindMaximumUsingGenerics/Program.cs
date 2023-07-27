namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum using generics program");
            FindMaximum findMaximum = new FindMaximum();
            Console.WriteLine("\n1.Find Max Of Three Int Number\n2.Find Max Of Three Float Number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:            
            int max = findMaximum.MaxOfThree(09, 18, 27);
            Console.WriteLine("Maximum is " + max);
                    break;
                    case 2:
            float fmax = findMaximum.MaxOfThreeFloat(18.27f, 45.63f, 72.99f);
            Console.WriteLine("Maximum is " + fmax);
                    break;
            }
        }
    }
}