namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum using generics program");
            FindMaximum findMaximum = new FindMaximum();
            Console.WriteLine("\n1.Find Max Of Three Int Number\n2.Find Max Of Three Float Number\n3.Find Max Of Three Strings");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                    case 1:
                    int a = 09; int b = 18; int c = 27; 
                    int max = findMaximum.GetMaxOfThree(a,b,c);
                    Console.WriteLine("Maximum out of {0}, {1}, {2} integers is: {3}", a,b,c,max);  
                    break;
                    case 2:
                    float p = 27.09f; float q = 45.18f; float r = 72.99f;
                    float fmax = findMaximum.GetMaxOfThree(p,q,r);
                    Console.WriteLine("Maximum out of {0}, {1}, {2} float is: {3}", p,q,r, fmax);
                    break;
                    case 3:
                    string x = "Xyz"; string y = "Abc"; string z = "Pqr";
                    string smax = findMaximum.GetMaxOfThree(x,y,z);
                    Console.WriteLine("Maximum out of {0}, {1}, {2} string is: {3}", x,y,z,smax);
                    break;
            }
        }
    }
}