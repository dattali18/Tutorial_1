internal class Program
{
    private static void Main(string[] args)
    {
        Class1.Ex2();
    }

    private static void Start()
    {
        Console.WriteLine("Welcome to the calculator");
        Console.WriteLine("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter operation: ");
        char operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        double ans = 0;

        switch (operation)
        {
            case '+':
                ans = num1 + num2;
                break;
            case '-':
                ans = num1 - num2;
                break;
            case '*':
                ans = num1 * num2;
                break;
            case '/':
                ans = num1 / num2;
                break;
            default:
                Console.WriteLine("You Enter a wrong operation");
                break;

        }
        Console.WriteLine("Answer: " + ans);
    }
}