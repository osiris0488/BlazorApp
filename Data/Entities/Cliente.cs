namespace BlazorApp.Data.Entities
{
	public class Cliente
	{
		public int ClienteId { get; set; }
		public required string Nombre { get; set; }
		public required string Email { get; set; }
		public required string Password { get; set; }
		public List<Cita> Citas { get; set; } = new List<Cita>();
	}
}