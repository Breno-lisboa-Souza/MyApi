using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using MyApi.Data;
using System;
using Microsoft.EntityFrameworkCore;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoritosController : ControllerBase
    {
        private readonly DataContext _context;

        public FavoritosController(DataContext context)
        {
            _context = context;
        }


        [HttpPost("favoritar/{jogoId}/{usuarioId}")]
        public async Task<IActionResult> FavoritarJogo(int jogoId, int usuarioId)
        {
            Jogo j = await _context.Jogos.FirstOrDefaultAsync(jBusca => jBusca.Id == jogoId);
            Usuario u = await _context.Usuarios.FirstOrDefaultAsync(uBusca => uBusca.Id == usuarioId);

            if (j == null || u == null)
            {
                return NotFound("Jogo ou usuário não encontrado.");
            }

            var jogoFavoritado = _context.Favoritos.Any(f => f.JogoId == jogoId && f.UsuarioId == usuarioId);

            if (jogoFavoritado)
            {
                return Ok("O jogo já está favoritado pelo usuário.");
            }

            var favorito = new Favorito
            {
                JogoId = jogoId,
                UsuarioId = usuarioId
            };

            _context.Favoritos.Add(favorito);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpGet("favoritos/{usuarioId}")]
        public async Task<IActionResult> GetFavoritos(int usuarioId)
        {
            try
            {
                List<Jogo> jogosFavoritos = await _context.Jogos
                    .Where(j => _context.Favoritos.Any(f => f.JogoId == j.Id && f.UsuarioId == usuarioId))
                    .ToListAsync();

                return Ok(jogosFavoritos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("favoritos/{jogoId}/{usuarioId}")]
        public async Task<IActionResult> RemoverFavorito(int jogoId, int usuarioId)
        {
            try
            {
                Favorito favorito = await _context.Favoritos
                    .FirstOrDefaultAsync(f => f.JogoId == jogoId && f.UsuarioId == usuarioId);

                if (favorito == null)
                {
                    return NotFound("O jogo não está na lista de favoritos do usuário.");
                }

                _context.Favoritos.Remove(favorito);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}