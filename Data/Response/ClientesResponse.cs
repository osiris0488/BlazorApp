using Alquilandome.Data.Request;
using BlazorApp.Data.Entities;
using BlazorApp.Data.Request;

namespace Alquilandome.Data.Response
{

    // Clase Cliente
    public class ClienteResponse
    {
		public int ClienteId { get; set; }
		public required string Nombre { get; set; }
		public required string Email { get; set; }
		public required string Password { get; set; }
		public List<Cita> Citas { get; set; } = new List<Cita>();

		public ClienteResponse ToRequest()
        {  
            return new ClienteRequest
            { 
                Id= ClienteId,
                Nombre = Nombre, 
                Email = Email, 
                Password = Password, 
                
            }; 
        }
    }

}
