namespace BlazorApp.Models
{
    namespace BlazorApp.Models
{
		public class Barbero
		{
			public int BarberoId { get; set; }
			public required string Nombre { get; set; }
			public required string Especialidad { get; set; }
			public List<Cita> Citas { get; set; } = new List<Cita>();
		}
	}
}