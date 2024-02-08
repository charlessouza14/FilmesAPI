using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs
{
    public class UpdateCinemaDto
    {
        [Required(ErrorMessage = "O campo do nome é obrigatório")]
        public string Nome { get; set; }
    }
}
