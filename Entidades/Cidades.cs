namespace teste_dapper.Entidades
{
    public class Cidades
    {
        public int Id { get; set; }
        public int IBGE7 { get; set; }
        public string Municipio { get; set; }
        public int EstadoId { get; set; }
        public virtual Estados Estado { get; set; }
    }
}