namespace Mundial.API.Models
{
    public class Seleccion
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Confederacion { get; set; } = string.Empty;
        public int RankingFIFA { get; set; }
        public int MundialesGanados {  get; set; }
    }
}
