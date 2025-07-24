namespace VagasTracker.Model
{
    public class Vagas
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Empresa { get; set; }
        public string? Link { get; set; }
        public DateTime DataAplicacao { get; set; }
        public string?   Status { get; set; } 
        public string? Observacoes { get; set; }
    }
}
