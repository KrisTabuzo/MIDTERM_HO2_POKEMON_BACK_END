namespace POKEMON_HO3.Repository
{

    using POKEMON_HO3.Data;
    using POKEMON_HO3.Interface;
    using System.Collections.Generic;
    using System.Data.OleDb;
    using System.Linq;
    using System.Threading.Tasks;

    public class PokemonRepository : IPokemonRepository
    {
        private readonly string _connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Kristofher\\Desktop\\MIDTERM-POKEMON-HO3\\DATABASE\\pokemon.accdb\"";

        public async Task<IEnumerable<Pokemon>> GetAllPokemonsAsync()
        {
            var pokemons = new List<Pokemon>();

            using (var connection = new OleDbConnection(_connectionString))
            {
                await connection.OpenAsync();
                var command = new OleDbCommand("SELECT * FROM Pokemon", connection);
                var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    pokemons.Add(new Pokemon
                    {
                        Name = reader["Name"].ToString(),
                        ImageUrl = reader["ImageUrl"].ToString(),
                        Weight = Convert.ToDouble(reader["Weight"]),
                        Height = Convert.ToDouble(reader["Height"]),
                        BaseEvolution = reader["BaseEvolution"].ToString(),
                        NextEvolution = reader["NextEvolution"].ToString(),
                        Generation = Convert.ToInt32(reader["Generation"]),
                        Type = reader["Type"].ToString()
                    });
                }
            }

            return pokemons;
        }

        public async Task<Pokemon> GetPokemonByNameAsync(string name)
        {
            using (var connection = new OleDbConnection(_connectionString))
            {
                await connection.OpenAsync();
                var command = new OleDbCommand($"SELECT * FROM Pokemon WHERE Name = ?", connection);
                command.Parameters.AddWithValue("?", name);
                var reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    return new Pokemon
                    {
                        Name = reader["Name"].ToString(),
                        ImageUrl = reader["ImageUrl"].ToString(),
                        Weight = Convert.ToDouble(reader["Weight"]),
                        Height = Convert.ToDouble(reader["Height"]),
                        BaseEvolution = reader["BaseEvolution"].ToString(),
                        NextEvolution = reader["NextEvolution"].ToString(),
                        Generation = Convert.ToInt32(reader["Generation"]),
                        Type = reader["Type"].ToString()
                    };
                }
            }

            return null;
        }

        public async Task<IEnumerable<Pokemon>> GetPokemonsByTypeAsync(string type)
        {
            var pokemons = new List<Pokemon>();

            using (var connection = new OleDbConnection(_connectionString))
            {
                await connection.OpenAsync();
                var command = new OleDbCommand($"SELECT * FROM Pokemon WHERE Type = ?", connection);
                command.Parameters.AddWithValue("?", type);
                var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    pokemons.Add(new Pokemon
                    {
                        Name = reader["Name"].ToString(),
                        ImageUrl = reader["ImageUrl"].ToString(),
                        Weight = Convert.ToDouble(reader["Weight"]),
                        Height = Convert.ToDouble(reader["Height"]),
                        BaseEvolution = reader["BaseEvolution"].ToString(),
                        NextEvolution = reader["NextEvolution"].ToString(),
                        Generation = Convert.ToInt32(reader["Generation"]),
                        Type = reader["Type"].ToString()
                    });
                }
            }

            return pokemons;
        }

        public async Task<IEnumerable<Pokemon>> GetPokemonsByGenerationAsync(int generation)
        {
            var pokemons = new List<Pokemon>();

            using (var connection = new OleDbConnection(_connectionString))
            {
                await connection.OpenAsync();
                var command = new OleDbCommand($"SELECT * FROM Pokemon WHERE Generation = ?", connection);
                command.Parameters.AddWithValue("?", generation);
                var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    pokemons.Add(new Pokemon
                    {
                        Name = reader["Name"].ToString(),
                        ImageUrl = reader["ImageUrl"].ToString(),
                        Weight = Convert.ToDouble(reader["Weight"]),
                        Height = Convert.ToDouble(reader["Height"]),
                        BaseEvolution = reader["BaseEvolution"].ToString(),
                        NextEvolution = reader["NextEvolution"].ToString(),
                        Generation = Convert.ToInt32(reader["Generation"]),
                        Type = reader["Type"].ToString()
                    });
                }
            }

            return pokemons;
        }
    }

}

