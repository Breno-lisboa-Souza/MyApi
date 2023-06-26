namespace MyApi.Models
{
    public class Jogo
    {
       
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Genero { get; set; }
        //public DateTime DataL { get; set; }
        public string Desenvolvedor { get; set; }
        public List<Usuario> Usuario { get; set; }
        
    }
}