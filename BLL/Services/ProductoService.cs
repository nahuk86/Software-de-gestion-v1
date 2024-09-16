using BLL.Interfaces;
using DAL.Repositories;
using Domain;
using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductoService
    {
        private ProductoDAL productoDAL = new ProductoDAL();

        public List<string> ObtenerCategorias()
        {
            return productoDAL.GetCategorias();
        }

        public List<string> ObtenerProveedores()
        {
            return productoDAL.GetProveedores();
        }

        public List<string> ObtenerMarcas()
        {
            return productoDAL.GetMarcas();
        }
    }
}