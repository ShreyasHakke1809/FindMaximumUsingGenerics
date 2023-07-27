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
                    FindMaximum <int> max = new FindMaximum<int>(intArray);
                    Console.WriteLine("Maximum is " + max);
                    max.PrintMax();
                    break;
                    case 2:
                    float[] floatArray = {09.18f, 27.09f, 45.63f, 72.99f};
                    FindMaximum<float> fmax = new FindMaximum<float>(floatArray);   
                    Console.WriteLine("Maximum is " + fmax);
                    fmax.PrintMax();
                    break;
                    case 3:
                    string[] strArray = {"abc", "lmn", "pqr", "xyz"};
                    FindMaximum<string> smax = new FindMaximum<string>(strArray);   
                    Console.WriteLine("Maximum is "+  smax);
                    smax.PrintMax();
                    break;
            }
        }
    }
}