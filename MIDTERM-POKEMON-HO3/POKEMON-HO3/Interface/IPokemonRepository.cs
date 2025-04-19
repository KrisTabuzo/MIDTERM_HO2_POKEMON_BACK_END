using POKEMON_HO3.Data;

namespace POKEMON_HO3.Interface
{
    public interface IPokemonRepository
    {
        public Task<IEnumerable<Pokemon>> GetAllPokemonsAsync();
        public Task<Pokemon> GetPokemonByNameAsync(string name);
        public Task<IEnumerable<Pokemon>> GetPokemonsByTypeAsync(string type);
        public Task<IEnumerable<Pokemon>> GetPokemonsByGenerationAsync(int generation);
    }
}
