using InputUtilitys;
namespace Ex_2022_Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = InputUtility.Input("Name:");
            var age = InputUtility.InputNumber("Age:", 120);
            Console.WriteLine($"Hello {name}! \n U are {age} yeaes old.");
        }
    }
}