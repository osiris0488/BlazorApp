namespace BlazorApp.Models
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int CitaId { get; set; }
        public required Cita Cita { get; set; }
        public int ClienteId { get; set; }
        public required Cliente Cliente { get; set; }
        public DateTime FechaReserva { get; set; }
    }
}