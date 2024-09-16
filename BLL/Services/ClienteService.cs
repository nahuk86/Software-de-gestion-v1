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
using Servicios.BLL;
using Servicios.Domain;


namespace BLL.Services
{
    public class ClienteService : IClienteService
    {
        private readonly ClienteRepository _clienteRepository;
        private readonly BitacoraService _bitacoraService;
        private readonly UsuarioService _usuarioService;



        public ClienteService(string connectionString, UsuarioService usuarioService)
        {
            _clienteRepository = new ClienteRepository(connectionString); // DAL manejada dentro de BLL
            _usuarioService = usuarioService ?? throw new ArgumentNullException(nameof(usuarioService));

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

            string usuarioActual = _usuarioService.ObtenerUsuarioActual();

            _clienteRepository.AgregarCliente(cliente);

            _bitacoraService.Registrar(usuarioActual, "Creación de cliente", $"Cliente {cliente.Email} dni {cliente.DNI} creado");


        }
    }
}