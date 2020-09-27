using System;
using System.Linq;
using System.Reflection;

namespace project_euler_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            var solutions = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.GetInterfaces().Any(y => y.Name == "ISolution"));
            Console.WriteLine($"{solutions.Count()} solutions available");
            if (solutions.Count() == 0) return;

            Console.Write("Enter problem id: ");
            if (!int.TryParse(Console.ReadLine(), out var id)) {
                Console.WriteLine("Id could not be parsed");
                return;
            }

            var solution = solutions.SingleOrDefault(s => s.Name == $"Solution{id}");
            if (solution == null) {
                Console.WriteLine("Requested solution doesn't exist.");
                return;
            }

            Console.WriteLine(((ISolution)Activator.CreateInstance(solution)).GetSolution());
        }
    }
}
