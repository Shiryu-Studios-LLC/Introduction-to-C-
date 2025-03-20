// these are varables that can be used in the code

internal class Program
{
    static int myint = 9; // This is an integer
    static string mystring = "Hello, World!"; // This is a string
    static double mydouble = 3.14; // This is a double-precision floating-point number
    static float myfloat = 3.14f; // This is a single-precision floating-point number
    static bool mybool = true; // This is a boolean expression (true or false)


    private static void Main(string[] args)
    {
        var result = Convert.ToInt32(mybool); // This will return 1
        // this is a function 
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.Write("How old are you? ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Hello {name}!, you are {age} years old!");
    }
}