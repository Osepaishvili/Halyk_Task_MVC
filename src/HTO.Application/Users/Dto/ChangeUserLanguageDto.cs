using System.ComponentModel.DataAnnotations;

namespace HTO.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}