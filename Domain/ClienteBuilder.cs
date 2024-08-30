using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ClienteBuilder
    {
        private ClienteDTO _cliente;

        public ClienteBuilder()
        {
            _cliente = new ClienteDTO();
        }

        public ClienteBuilder ConNombre(string nombre)
        {
            _cliente.Nombre = nombre;
            return this;
        }

        public ClienteBuilder ConApellido(string apellido)
        {
            _cliente.Apellido = apellido;
            return this;
        }

        public ClienteBuilder ConDNI(string dni)
        {
            _cliente.DNI = dni;
            return this;
        }

        public ClienteBuilder ConTelefono(string telefono)
        {
            _cliente.Telefono = telefono;
            return this;
        }

        public ClienteBuilder ConDireccion(string direccion)
        {
            _cliente.Direccion = direccion;
            return this;
        }

        public ClienteBuilder ConEmail(string email)
        {
            _cliente.Email = email;
            return this;
        }

        public ClienteBuilder ConFechaNacimiento(DateTime fechaNacimiento)
        {
            _cliente.FechaNacimiento = fechaNacimiento;
            return this;
        }

        public ClienteDTO Build()
        {
            return _cliente;
        }
    }
}