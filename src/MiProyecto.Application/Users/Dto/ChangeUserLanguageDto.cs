using System.ComponentModel.DataAnnotations;

namespace MiProyecto.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}