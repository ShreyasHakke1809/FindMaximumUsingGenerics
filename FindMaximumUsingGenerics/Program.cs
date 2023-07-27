namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum using generics program");
            Console.WriteLine("\n1.Find Max Of Three Int Number\n2.Find Max Of Three Float Number\n3.Find Max Of Three Strings");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                    case 1:
                    int[] intArray = {09,18,27,36};
                    int max = new FindMaximum<int>(intArray).GetMax();
                    Console.WriteLine("Maximum is " + max);
                    break;
                    case 2:
                    float[] floatArray = {09.18f, 27.09f, 45.63f, 72.99f};
                    float fmax = new FindMaximum<float>(floatArray).GetMax();
                    Console.WriteLine("Maximum is " + fmax);
                    break;
                    case 3:
                    string[] strArray = {"abc", "lmn", "pqr", "xyz"};
                    string smax = new FindMaximum<string>(strArray).GetMax();
                    Console.WriteLine("Maximum is "+  smax);
                    break;
            }
        }
    }
}