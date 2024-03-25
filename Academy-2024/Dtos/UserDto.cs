using System.ComponentModel.DataAnnotations;
using Academy_2024.Services;


namespace Academy_2024.Dtos
{
    public class UserDto
    {

        public string jelszo;

        [Key]
        public int Id { get; set; }

        [StringLength(10)]
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password
        { get { return titkositas.HashSzovegMD5(jelszo); }
            set{ jelszo=value; } }



    }
}
