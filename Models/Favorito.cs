using System.ComponentModel.DataAnnotations;

namespace MyApi.Models
{
    public class Favorito
    {
        public int Id { get; set; }

        public int JogoId { get; set; }
        public Jogo Jogo { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
