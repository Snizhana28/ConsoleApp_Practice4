using Domain.models;
namespace ConsoleApp_Practice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a number task :");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    Domain.models.EvenNumbers.Numbers.EvenNumbersCreating();
                    Domain.models.OddNumbers.Numbers.OddNumbersCreating();
                    Domain.models.PrimeNumbers.Numbers.PrimeNumbersCreating();
                    Domain.models.FibonacciNumbers.Numbers.FibonacciNumbersCreating();
                    break;

                case 2:
                    Domain.models.Triangle.Figures.TriangleCreating();
                    Domain.models.Rectangle.Figures.RectangleCreating();
                    Domain.models.Square.Figures.SquareCreating();
                    break;
                case 3:
                    Domain.models.GuessNumber.Number.GuessNumberCreating();
                    break;
                case 4:
                    Console.WriteLine("Enter a vowel count :");
                    int vowelCount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter a consonant count : ");
                    int consonantCount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter a max length :");
                    int maxLength = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Genereted Text :");
                    string pseudoText = Domain.models.GeneretedText.GeneretedPseudoText.RandomText(vowelCount, consonantCount, maxLength);
                    Console.WriteLine(pseudoText);
                    break;

            }
        }
    }
}