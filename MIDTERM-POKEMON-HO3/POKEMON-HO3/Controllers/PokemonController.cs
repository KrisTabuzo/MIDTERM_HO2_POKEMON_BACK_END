using Microsoft.AspNetCore.Mvc;
using POKEMON_HO3.Data;
using POKEMON_HO3.Interface;
using POKEMON_HO3.Repository;

namespace POKEMON_HO3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository _pokemonrepository;

        public PokemonController(IPokemonRepository pokemonrepo)
        {
            _pokemonrepository = pokemonrepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemons()
        {
            var pokemons = await _pokemonrepository.GetAllPokemonsAsync();
            return Ok(pokemons);
        }


        [HttpGet("name/{name}")]
        public async Task<ActionResult<Pokemon>> GetPokemonByName(string name)
        {
            var pokemon = await _pokemonrepository.GetPokemonByNameAsync(name);
            if (pokemon == null)
                return NotFound();
            return Ok(pokemon);
        }

        [HttpGet("type/{type}")]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemonsByType(string type)
        {
            var pokemons = await _pokemonrepository.GetPokemonsByTypeAsync(type);
            return Ok(pokemons);
        }

        [HttpGet("generation/{generation}")]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemonsByGeneration(int generation)
        {
            var pokemons = await _pokemonrepository.GetPokemonsByGenerationAsync(generation);
            return Ok(pokemons);
        }
    }

}
