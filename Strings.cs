namespace CoolBeans
{
    class Program
    {
        static void Main(string[] args)
        {
            string printer = "coolBeans";
            Console.WriteLine(printer.Length);
            Console.WriteLine(printer.ToUpper());
            Console.WriteLine(printer.Contains("ool"));
            Console.WriteLine(printer[0]);
            Console.WriteLine(printer.IndexOf("Be"));
            Console.WriteLine(printer.Substring(4));
            Console.WriteLine(printer.Substring(4,2));
          //  Console.ReadLine();
        }
    }
}
