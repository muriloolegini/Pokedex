namespace PokedexConsole.src.Models
{
    public class Pokedex
    {
        public Pokedex()
        {
            InitializeList();
        }

        private List<Pokemon> pokemons;
        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
        }

        private void InitializeList()
        {
            // Instantiate the list
            pokemons = new List<Pokemon>();
            Pokemon p = new Pokemon("Pikachu", "Pikachu that can generate powerful electricity have cheek sacs that are extra soft and super stretchy.");
            pokemons.Add(p);

            p = new Pokemon("Charmander", "It has a preference for hot things. When it rains, steam is said to spout from the tip of its tail.");
            pokemons.Add(p);

            p = new Pokemon("Bulbasaur", "There is a plant seed on its back right from the day this Pokémon is born. The seed slowly grows larger.");
            pokemons.Add(p);
        }
    }
}