using System.ComponentModel.DataAnnotations;

namespace Api.Entidades
{
    public class Livros : Entity
    {
        [Required]
        public string Nome { get; set; }
        public string Autor { get; set; }   
       
    }
}
