namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Inferred typing, string interpolation, and the ternary operator.
            
            var answer = 4;
             Console.WriteLine("The integer is 4 and the compared integer is 9.");
            var response = (answer < 9) ? $"{answer} is less than nine." : $"{answer} is greater than or equal to nine.";

            Console.WriteLine(response);

            Console.WriteLine("Choose a number between 0 and 15:");
            var answer2 = int.Parse(Console.ReadLine());
            var response2 = (answer2 < 9) ? $"{answer2} is less than nine." : $"{answer2} is greater than or equal to nine.";
            Console.WriteLine(response2);

        }
    }
}
