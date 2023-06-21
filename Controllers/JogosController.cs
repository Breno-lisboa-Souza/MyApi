using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using MyApi.Data;
using System;
using Microsoft.EntityFrameworkCore;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogosController : ControllerBase
    {
        private readonly DataContext _context;

        public JogosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Jogo a = await _context.Jogos.FirstOrDefaultAsync(pBusca => pBusca.Id == id);

                return Ok(a);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Jogo> lista = await _context.Jogos.ToListAsync();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        public async Task<IActionResult> Add(Jogo novoJogo)
        {
            try
            {
                await _context.Jogos.AddAsync(novoJogo);
                await _context.SaveChangesAsync();

                return Ok(novoJogo.Id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Jogo novoJogo)
        {
            try
            {
                _context.Jogos.Update(novoJogo);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Jogo aRemove = await _context.Jogos.FirstOrDefaultAsync(p => p.Id == id);

                _context.Jogos.Remove(aRemove);
                int linhasAfetedas = await _context.SaveChangesAsync();
                return Ok(linhasAfetedas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
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

    }
}