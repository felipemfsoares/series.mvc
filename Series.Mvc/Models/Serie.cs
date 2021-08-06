using System.ComponentModel.DataAnnotations;

namespace Series.Mvc.Models
{
    public class Serie
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public string Genero { get; set; }
    }
}