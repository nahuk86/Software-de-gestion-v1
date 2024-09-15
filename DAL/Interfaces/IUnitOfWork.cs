using ArqBase.DAL.Repositories;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUsuarioRepository Usuarios { get; }
        //IBitacoraRepository Bitacora { get; }
        // Agrega otros repositorios según sea necesario

        Task<int> SaveChangesAsync();
    }
}