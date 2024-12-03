namespace ConsoleApp1
{
    internal class Program
    {
        static async Task<int> CalculateSquareAsync(int number)
        {
            Console.WriteLine($"Започвам обработката на числото: {number}");

            await Task.Delay(1000);

            int square = number * number;
            Console.WriteLine($"Квадратът на {number} е {square}");

            return square;
        }

        static async Task Main(string[] args)
        {
            Console.Write("n= ");
            int n=int.Parse( Console.ReadLine() );

            List<int> numbers = new List<int>(); 

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            List<Task<int>> tasks = new List<Task<int>>();

            foreach (int number in numbers)
            {
                tasks.Add(CalculateSquareAsync(number));
            }

            int[] results = await Task.WhenAll(tasks);

            Console.WriteLine("Обработката е завършена!");
        }
    }
}


