// See https://aka.ms/new-console-template for more information
namespace cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomNumber = random.Next(0, 10);
            bool isCorrect = false;

            do
            {
                Console.Write("Guess a number between 0 - 10: ");
                String guess = Console.ReadLine();
                int i = int.Parse(guess);

                if (i == randomNumber){
                    Console.Write("Correct! Thanks for playing.");
                    isCorrect = true;
                }else if (i < randomNumber){
                    Console.Write("Too low!\n");
                }else{
                    Console.Write("Too high!\n");
                }
                
            } while (!isCorrect);
        }
    }
}