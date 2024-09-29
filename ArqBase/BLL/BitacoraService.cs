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

        public BitacoraService()
        {
            _bitacoraRepository = new BitacoraRepository();
        }

        public void Registrar(string email, string accion, string detalle)
        {
            Bitacora bitacora = new Bitacora
            {
                FechaHora = DateTime.Now,
                Email = email,
                Accion = accion,
                Detalle = detalle
            };

            _bitacoraRepository.RegistrarEnBitacora(bitacora);
        }
    }
}