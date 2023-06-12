namespace CoolBeans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string myName = Console.ReadLine();
            Console.Write("Enter your age: ");
            string myAge = Console.ReadLine();
            Console.WriteLine("My name is " + myName);
            Console.WriteLine("I am " + myAge + " years old");
        }
    }
}
