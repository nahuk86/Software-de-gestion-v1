using ArqBase.DAL.Repositories;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GestionLocalesTelefoniaDBContext _context;
        private UsuarioRepository _usuarioRepository;
        private BitacoraRepository _bitacoraRepository;
        // Agrega otros repositorios según sea necesario

        public UnitOfWork(GestionLocalesTelefoniaDBContext context)
        {
            _context = context;
        }

        public IUsuarioRepository Usuarios
        {
            get
            {
                if (_usuarioRepository == null)
                {
                    _usuarioRepository = new UsuarioRepository(_context);
                }
                return _usuarioRepository;
            }
        }

        //public IBitacoraRepository Bitacora
        //{
        //    get
        //    {
        //        if (_bitacoraRepository == null)
        //        {
        //            _bitacoraRepository = new BitacoraRepository(_context);
        //        }
        //        return _bitacoraRepository;
        //    }
        //}

        // Implementa otros repositorios de manera similar

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
