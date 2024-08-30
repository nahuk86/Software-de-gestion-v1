using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Validators;
using DAL.Repositories;



namespace BLL.Commands
{
    public class AltaClienteCommand
    {
        private readonly ClienteDTO _cliente;
        private readonly ClienteRepository _repository;

        public AltaClienteCommand(ClienteDTO cliente, ClienteRepository repository)
        {
            _cliente = cliente;
            _repository = repository;
        }

        public void Ejecutar()
        {
            if (ClienteValidator.EsValido(_cliente, out string mensajeError))
            {
                _repository.AgregarCliente(_cliente);
            }
            else
            {
                throw new InvalidOperationException(mensajeError);
            }
        }
    }
}