using Tyuiu.DylginA.Sprint0.Task5.V0.Lib;
namespace Tyuiu.DylginA.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A+B=" +DataService.Addition(1,5));
            Console.WriteLine("A-B=" + DataService.Addition(15, 5));
            Console.WriteLine("A*B=" + DataService.Addition(10, 10));
            Console.WriteLine("A/B=" + DataService.Addition(5, 0));
            Console.ReadKey();
        }
    }
}
