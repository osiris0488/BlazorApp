using BlazorApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Services
{
    public class ClienteService
    {
        private readonly List<Cliente> clientes = new List<Cliente>();

        public ClienteService()
        {
            // Inicializar con algunos datos de ejemplo
            clientes.Add(new Cliente 
            { 
                ClienteId = 1, 
                Nombre = "Juan Perez", 
                Email = "juan@example.com", 
                Password = "password123",
                Citas = new List<Cita>()
            });
        }

        public Cliente? ValidarUsuario(string email, string password)
        {
            return clientes.FirstOrDefault(c => c.Email == email && c.Password == password);
        }

        public void RegistrarCliente(Cliente cliente)
        {
            cliente.ClienteId = clientes.Count + 1;
            clientes.Add(cliente);
        }
    }
}