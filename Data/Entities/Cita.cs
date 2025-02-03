using System;
using BlazorApp.Models.BlazorApp.Models;
namespace BlazorApp.Data.Entities
{
	public class Cita
	{
		public int CitaId { get; set; }
		public DateTime Fecha { get; set; }
		public int ClienteId { get; set; }
		public required Cliente Cliente { get; set; }
		public int BarberoId { get; set; }
		public required Barbero Barbero { get; set; }
	}
}