namespace PokedexConsole.src.Models
{
    public class PokemonPlus : Pokemon
    {
        public PokemonPlus() : base()
        {
            Power = 0;
        }

        public PokemonPlus(string name, string description, int power) : base(name, description)
        {
            Power = power;
        }

        public int Power { get; set; }

        public void ViewPokemonDataPlus()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Power: {Power}");
        }
    }
}