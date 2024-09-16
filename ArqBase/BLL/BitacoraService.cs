using Servicios.DAL.Repositories;
using Servicios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.BLL
{
    public class BitacoraService
    {
        private readonly BitacoraRepository _bitacoraRepository;

        public BitacoraService(BitacoraRepository bitacoraRepository)
        {
            _bitacoraRepository = bitacoraRepository ?? throw new ArgumentNullException(nameof(bitacoraRepository));
        }

        public void Registrar(string usuario, string accion, string detalle = null)
        {
            Bitacora bitacora = new Bitacora
            {
                FechaHora = DateTime.Now,
                Usuario = usuario,
                Accion = accion,
                Detalle = detalle
            };

            _bitacoraRepository.RegistrarEnBitacora(bitacora);
        }
    }
}