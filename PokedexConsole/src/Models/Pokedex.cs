namespace PokedexConsole.src.Models
{
    public class Pokedex
    {
        public Pokedex()
        {
            InitializeList();
        }

        private List<PokemonPlus> pokemons;
        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }

        private void InitializeList()
        {
            // Instantiate the list
            pokemons = new List<PokemonPlus>();
            PokemonPlus p = new PokemonPlus("Pikachu", "Pikachu that can generate powerful electricity have cheek sacs that are extra soft and super stretchy.", 100);
            pokemons.Add(p);

            p = new PokemonPlus("Charmander", "It has a preference for hot things. When it rains, steam is said to spout from the tip of its tail.", 90);
            pokemons.Add(p);

            p = new PokemonPlus("Bulbasaur", "There is a plant seed on its back right from the day this Pokémon is born. The seed slowly grows larger.", 70);
            pokemons.Add(p);
        }

        public void ListPokemon()
        {
            for (int i = 0; i < Pokemons.Count; i++)
            {
                Pokemons[i].ViewPokemonData();
            }
        }
    }
}