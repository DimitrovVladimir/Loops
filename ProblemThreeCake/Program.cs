namespace ProblemThreeCake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ingredientCount = 0;
            var ingredient = Console.ReadLine();

            while (ingredient !=  "bake !")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredientCount++;
                ingredient = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {ingredientCount} ingredients.");
        }
    }
}