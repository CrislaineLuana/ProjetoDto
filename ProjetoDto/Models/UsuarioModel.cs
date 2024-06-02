namespace ProjetoDto.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Senha { get; set; }
        public bool Situacao { get; set; }
    }
}
