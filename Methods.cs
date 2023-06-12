namespace CoolBeans
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            HelloMe("Bob",20);

            
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static void HelloMe(string name, int age) 
        { 
            Console.WriteLine("Hello my name is " + name + " and I am " + age
                +" years old"); 
        }

    }
}
