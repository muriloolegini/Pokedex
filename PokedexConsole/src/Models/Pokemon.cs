namespace PokedexConsole.src.Models
{
    public class Pokemon
    {
        public Pokemon()
        {
            Name = "";
            Description = "";
        }

        public Pokemon(string name, string description)
        {
            Name = name;
            Description = description;
        }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                string text = value.ToUpper();
                name = text;
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value.ToUpper(); }
        }

        public void ViewPokemonData()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}