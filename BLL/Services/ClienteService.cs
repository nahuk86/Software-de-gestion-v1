using BLL.Validators;
using DAL.Repositories;
using Domain.DTOs;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;


namespace BLL.Services
{
    public class ClienteService : IClienteService
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteService(string connectionString)
        {
            _clienteRepository = new ClienteRepository(connectionString); // DAL manejada dentro de BLL
        }

        public void CrearCliente(string nombre, string apellido, string dni, string telefono, string direccion, string email, DateTime fechaNacimiento)
        {
            var clienteBuilder = new ClienteBuilder()
                .ConNombre(nombre)
                .ConApellido(apellido)
                .ConDNI(dni)
                .ConTelefono(telefono)
                .ConDireccion(direccion)
                .ConEmail(email)
                .ConFechaNacimiento(fechaNacimiento);

            ClienteDTO cliente = clienteBuilder.Build();

            if (!ClienteValidator.EsValido(cliente, out string mensajeError))
            {
                throw new InvalidOperationException(mensajeError);
            }

            _clienteRepository.AgregarCliente(cliente);
        }
    }
}