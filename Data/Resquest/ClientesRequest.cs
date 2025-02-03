using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Data.Request;
    public class ClienteRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        [Required(ErrorMessage = "La nombre del cliente es obligatoria")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "El email es obligatorio")]
        public string? Password { get; set; }
      
    }
