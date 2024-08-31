﻿using ArqBase.DAL.Repositories;
using ArqBase.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqBase.BLL
{
    public class BitacoraService
    {
        private readonly BitacoraRepository _bitacoraRepository;

        public BitacoraService(string connectionString)
        {
            _bitacoraRepository = new BitacoraRepository(connectionString);
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