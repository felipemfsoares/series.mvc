using System.ComponentModel.DataAnnotations;

namespace Series.Mvc.Models
{
    public class Serie
    {
        public int Id { get; set; }
     
        [Display(Name = "Título")]
        [Required(ErrorMessage = "Informe o título")]
        public string Titulo { get; set; }
        
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Informe a descrição")]
        public string Descricao { get; set; }
        
        [Display(Name = "Ano")]
        [Required(ErrorMessage = "Informe o ano")]
        public int Ano { get; set; }
        
        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "Informe o gênero")]
        public string Genero { get; set; }
    }
}