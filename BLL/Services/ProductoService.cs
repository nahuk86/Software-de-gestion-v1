﻿using BLL.Interfaces;
using DAL.Repositories;
using Domain;
using BLL.DTOs;
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
        private ProductoRepository productoRepository = new ProductoRepository();

        public void AgregarProducto(ProductoDTO productoDTO)
        {
            // Convertir ProductoDTO a Producto (entidad del dominio)
            var producto = new Producto
            {
                Nombre = productoDTO.Nombre,
                IdCategoria = productoDTO.IdCategoria,
                IdProveedor = productoDTO.IdProveedor,
                IdMarca = productoDTO.IdMarca,
                ValorUnitario = productoDTO.ValorUnitario
            };

            // Validar los datos
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new ArgumentException("El nombre del producto no puede estar vacío.");
            if (producto.ValorUnitario <= 0)
                throw new ArgumentException("El valor unitario debe ser mayor que cero.");

            // Llamar a la capa DAL para agregar el producto
            productoRepository.AgregarProducto(producto);
        }

        public List<CategoriaDTO> ObtenerCategorias()
        {
            var categorias = productoRepository.ObtenerCategorias();
            return categorias.ConvertAll(c => new CategoriaDTO
            {
                Id = c.Id,
                Nombre = c.Nombre
            });
        }

        public List<ProveedorDTO> ObtenerProveedores()
        {
            var proveedores = productoRepository.ObtenerProveedores();
            return proveedores.ConvertAll(p => new ProveedorDTO
            {
                Id = p.Id,
                Nombre = p.Nombre
            });
        }

        public List<MarcaDTO> ObtenerMarcas()
        {
            var marcas = productoRepository.ObtenerMarcas();
            return marcas.ConvertAll(m => new MarcaDTO
            {
                Id = m.Id,
                Nombre = m.Nombre
            });
        }
    }
}