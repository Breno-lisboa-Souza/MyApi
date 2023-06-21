using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public DateTime? DataAcesso { get; set; }
        public string PasswordString { get; set; }
        public string Perfil { get; set; }
        public string Email { get; set; }
        public List<Jogo> Jogo { get; set; }
    }
}
