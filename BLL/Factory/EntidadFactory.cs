using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace BLL.Factory
{
    public class EntidadFactory
    {
        public IEntidad CrearEntidad(string tipo)
        {
            switch (tipo)
            {
                case "Marca":
                    return new Marca();
                case "Proveedor":
                    return new Proveedor();
                case "Categoria":
                    return new Categoria();
                default:
                    throw new ArgumentException("Tipo de entidad no válido");
            }
        }
    }
}
