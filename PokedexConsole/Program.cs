using PokedexConsole.src.Models;

Pokedex pokedex = new Pokedex();
int answer = 100;

while (answer != 0)
{
    answer = Menu();
    Console.Clear();
    
    if (answer == 1)
    {
        pokedex.ListPokemons();
    }

    if (answer == 2)
    {
        pokedex.ListPokemons();
        Console.Write("Enter the Pokémon code: ");
        int code = Convert.ToInt32(Console.ReadLine());

        // Catch the player's Pokémon
        PokemonPlus pPlayer = pokedex.Pokemons[code];

        // Set pc's Pokémon
        Random rand = new Random();
        code = rand.Next(0, pokedex.Pokemons.Count);
        PokemonPlus pPC = pokedex.Pokemons[code];

        // Battle
        Console.WriteLine("\n ==== Pokémon battle ====");
        Console.WriteLine("");
        Console.WriteLine("Your Pokémon data");
        pPlayer.ViewPokemonData();

        Console.WriteLine("");
        Console.WriteLine("PC Pokémon Data");
        pPC.ViewPokemonData();

        if (pPlayer.Power >= pPC.Power)
        {
            Console.WriteLine("Congratulations! You win");
        }
        else
        {
            Console.WriteLine("Sorry! You lost");
        }
    }

    Console.ReadLine();
    Console.Clear();
}

static int Menu()
{
    Console.WriteLine("Pokémon === Battle Game ===");
    Console.WriteLine("0 - Exit");
    Console.WriteLine("1 - List all pokedex Pokémon ");
    Console.WriteLine("2 - Battle");
    Console.Write("What do you want to do: ");

    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}