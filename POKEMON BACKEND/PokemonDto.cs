namespace POKEMON_BACKEND
{
    public class PokemonDto
    {
        public String? Name { get; set; }

        public String? Imageurl { get; set; }

        public float? Height { get; set; }

        public float? Weight { get; set; }
        public string? Type { get; set; }
    }

    public static class PokemonRepository
    {
        private static readonly List<PokemonDto> PokemonList;
        static PokemonRepository()
        {
            PokemonList = new List<PokemonDto>()
            {
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png",
                    Name = "Mew",
                    Height = 4.0f,
                    Weight = 40.0f,
                    Type = "Psychic"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/25.png",
                    Name = "Pikachu",
                    Height = 0.4f,
                    Weight = 6.0f,
                    Type = "Electric"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/6.png",
                    Name = "Charizard",
                    Height = 1.7f,
                    Weight = 90.5f,
                    Type = "Fire/Flying"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png",
                    Name = "Bulbasaur",
                    Height = 0.7f,
                    Weight = 6.9f,
                    Type = "Grass/Poison"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/7.png",
                    Name = "Squirtle",
                    Height = 0.5f,
                    Weight = 9.0f,
                    Type = "Water"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/133.png",
                    Name = "Eevee",
                    Height = 0.3f,
                    Weight = 6.5f,
                    Type = "Normal"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/39.png",
                    Name = "Jigglypuff",
                    Height = 0.5f,
                    Weight = 5.5f,
                    Type = "Fairy/Normal"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/143.png",
                    Name = "Snorlax",
                    Height = 2.1f,
                    Weight = 460.0f,
                    Type = "Normal"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/2.png",
                    Name = "Machop",
                    Height = 0.8f,
                    Weight = 19.5f,
                    Type = "Fighting"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/10.png",
                    Name = "Caterpie",
                    Height = 0.3f,
                    Weight = 2.9f,
                    Type = "Bug"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/16.png",
                    Name = "Pidgey",
                    Height = 0.3f,
                    Weight = 1.8f,
                    Type = "Normal/Flying"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/19.png",
                    Name = "Rattata",
                    Height = 0.3f,
                    Weight = 3.5f,
                    Type = "Normal"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/41.png",
                    Name = "Zubat",
                    Height = 0.8f,
                    Weight = 7.5f,
                    Type = "Poison/Flying"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/74.png",
                    Name = "Geodude",
                    Height = 0.4f,
                    Weight = 20.0f,
                    Type = "Rock/Ground"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/95.png",
                    Name = "Onix",
                    Height = 8.8f,
                    Weight = 210.0f,
                    Type = "Rock/Ground"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/129.png",
                    Name = "Magikarp",
                    Height = 0.9f,
                    Weight = 10.0f,
                    Type = "Water"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/130.png",
                    Name = "Gyarados",
                    Height = 6.5f,
                    Weight = 235.0f,
                    Type = "Water/Flying"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/92.png",
                    Name = "Gastly",
                    Height = 1.3f,
                    Weight = 0.1f,
                    Type = "Ghost/Poison"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/93.png",
                    Name = "Haunter",
                    Height = 1.6f,
                    Weight = 0.1f,
                    Type = "Ghost/Poison"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/94.png",
                    Name = "Gengar",
                    Height = 1.5f,
                    Weight = 40.5f,
                    Type = "Ghost/Poison"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/65.png",
                    Name = "Alakazam",
                    Height = 1.5f,
                    Weight = 48.0f,
                    Type = "Psychic"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/96.png",
                    Name = "Drowzee",
                    Height = 1.0f,
                    Weight = 32.4f,
                    Type = "Psychic"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/138.png",
                    Name = "Kabuto",
                    Height = 0.5f,
                    Weight = 11.5f,
                    Type = "Rock/Water"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/139.png",
                    Name = "Kabutops",
                    Height = 1.3f,
                    Weight = 40.5f,
                    Type = "Rock/Water"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/4.png",
                    Name = "Charmander",
                    Height = 0.6f,
                    Weight = 8.5f,
                    Type = "Fire"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/727.png",
                    Name = "Litten",
                    Height = 0.4f,
                    Weight = 4.3f,
                    Type = "Fire"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/653.png",
                    Name = "Fennekin",
                    Height = 0.4f,
                    Weight = 9.4f,
                    Type = "Fire"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/158.png",
                    Name = "Totodile",
                    Height = 0.6f,
                    Weight = 9.5f,
                    Type = "Water"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/152.png",
                    Name = "Chikorita",
                    Height = 0.9f,
                    Weight = 6.4f,
                    Type = "Grass"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/153.png",
                    Name = "Bayleef",
                    Height = 1.2f,
                    Weight = 15.8f,
                    Type = "Grass"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/155.png",
                    Name = "Cyndaquil",
                    Height = 0.4f,
                    Weight = 7.9f,
                    Type = "Fire"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/175.png",
                    Name = "Togepi",
                    Height = 0.3f,
                    Weight = 1.5f,
                    Type = "Fairy"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/176.png",
                    Name = "Togekiss",
                    Height = 1.5f,
                    Weight = 38.0f,
                    Type = "Fairy/Flying"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/163.png",
                    Name = "Hoothoot",
                    Height = 0.6f,
                    Weight = 21.2f,
                    Type = "Normal/Flying"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/164.png",
                    Name = "Noctowl",
                    Height = 1.6f,
                    Weight = 40.8f,
                    Type = "Normal/Flying"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/112.png",
                    Name = "Rhydon",
                    Height = 1.9f,
                    Weight = 120.0f,
                    Type = "Rock/Ground"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/449.png",
                    Name = "Hippopotas",
                    Height = 0.8f,
                    Weight = 49.5f,
                    Type = "Ground"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/450.png",
                    Name = "Hippowdon",
                    Height = 2.0f,
                    Weight = 300.0f,
                    Type = "Ground"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/147.png",
                    Name = "Dratini",
                    Height = 1.8f,
                    Weight = 3.3f,
                    Type = "Dragon"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/149.png",
                    Name = "Dragonite",
                    Height = 2.2f,
                    Weight = 210.0f,
                    Type = "Dragon/Flying"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/357.png",
                    Name = "Tropius",
                    Height = 2.0f,
                    Weight = 100.0f,
                    Type = "Grass/Flying"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/213.png",
                    Name = "Shuckle",
                    Height = 0.6f,
                    Weight = 20.5f,
                    Type = "Bug/Rock"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/290.png",
                    Name = "Nincada",
                    Height = 0.6f,
                    Weight = 5.5f,
                    Type = "Bug/Ground"
                },
                new PokemonDto
                {
                    Imageurl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/291.png",
                    Name = "Ninjask",
                    Height = 0.8f,
                    Weight = 12.0f,
                    Type = "Bug/Flying"
                }

            };
        }

        public static List<PokemonDto> GetallPokemons()
        {
            return PokemonList;

        }
        public static void addPokemon(PokemonDto dto) 
        {
        PokemonList.Add(dto);
        }
    }
}
