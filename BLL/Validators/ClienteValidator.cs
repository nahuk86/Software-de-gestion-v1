using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.Validators
{
    public static class ClienteValidator
    {
        public static bool EsValido(ClienteDTO cliente, out string mensajeError)
        {
            mensajeError = string.Empty;

            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                mensajeError = "El nombre es obligatorio.";
            else if (string.IsNullOrWhiteSpace(cliente.Apellido))
                mensajeError = "El apellido es obligatorio.";
            else if (string.IsNullOrWhiteSpace(cliente.DNI) || !Regex.IsMatch(cliente.DNI, @"^\d{7,8}$"))
                mensajeError = "El DNI debe ser un número válido.";
            else if (!string.IsNullOrWhiteSpace(cliente.Email) && !Regex.IsMatch(cliente.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                mensajeError = "El email no tiene un formato válido.";
            else
                return true;

            return false;
        }
    }
}