using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POKEMON_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokedexController : ControllerBase

    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(PokemonRepository.GetallPokemons());
        }

        [HttpGet]
        [Route("get-by-name")]
        public IActionResult GetByName([FromQuery] string? name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Name parameter is required.");
            }

            var result = PokemonRepository.GetallPokemons()
                .FirstOrDefault(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            return result != null ? Ok(result) : NotFound("No Cintent");
        }

        [HttpGet]
        [Route("get-by-type")]
        public IActionResult GetByType([FromQuery] string? type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                return BadRequest("Type parameter is required.");
            }

            var result = PokemonRepository.GetallPokemons()
                .Where(i => i.Type.Equals(type, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return result.Any() ? Ok(result) : NotFound("No Pokémon found with the specified type.");
        }



        [HttpPost]
        public IActionResult Post([FromBody] PokemonDto dto) 
        {
            try
            {
                if (dto == null || string.IsNullOrWhiteSpace(dto.Name) || string.IsNullOrWhiteSpace(dto.Type))
                {
                    return BadRequest("Invalid Pokémon data.");
                }

                PokemonRepository.addPokemon(dto);
                return CreatedAtAction(nameof(GetByName), new { name = dto.Name }, dto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        public IActionResult Put([FromBody] PokemonDto dto) {
            if (dto == null || string.IsNullOrWhiteSpace(dto.Name))
            {
                return BadRequest("Invalid Pokémon data.");
            }

            var existingPokemon = PokemonRepository.GetallPokemons()
                .FirstOrDefault(p => p.Name.Equals(dto.Name, StringComparison.OrdinalIgnoreCase));

            if (existingPokemon == null)
            {
                return NotFound("Pokemon not found.");
            }

            return Ok("OK");
        }


        [HttpDelete]
        public IActionResult Delete([FromBody] PokemonDto dto) 
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.Name))
            {
                return BadRequest("Invalid Pokémon data.");
            }

            var pokemons = PokemonRepository.GetallPokemons();
            var pokemonToRemove = pokemons.FirstOrDefault(p => p.Name.Equals(dto.Name, StringComparison.OrdinalIgnoreCase));

            if (pokemonToRemove == null)
            {
                return NotFound("Pokemon not found.");
            }

            pokemons.Remove(pokemonToRemove);
            return Ok($"Pokemon {dto.Name} removed successfully.");
        }

    }
}
