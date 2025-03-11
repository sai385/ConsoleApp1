namespace ConsoleApp1
{
    internal class Program
    {
         public  Program(int x)
        {
            Console.WriteLine("constructor is called");
        }
        void method1(int y)
        {
            Program p = new Program(20);
            Console.WriteLine(y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program p1 = new Program(10);
            p1.method1(100);
            
        }
    }
}
