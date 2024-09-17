using BLL.Interfaces;
using DAL.Repositories;
using Domain;
using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Servicios.BLL;
using BLL.Factory;

namespace BLL.Services
{
    public class ProductoService
    {
        private ProductoRepository productoRepository;
        private MarcaRepository marcaRepository;
        private readonly BitacoraService _bitacoraService;
        private readonly UsuarioService _usuarioService;

        public ProductoService(BitacoraService bitacoraService, UsuarioService usuarioService)
        {
            _bitacoraService = bitacoraService ?? throw new ArgumentNullException(nameof(bitacoraService));
            _usuarioService = usuarioService ?? throw new ArgumentNullException(nameof(usuarioService));

            // Inicializa el repositorio
            productoRepository = new ProductoRepository();
            _entidadFactory = new EntidadFactory();
            marcaRepository = new MarcaRepository();
        }

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
            string usuarioActual = _usuarioService.ObtenerUsuarioActual();
            _bitacoraService.Registrar(usuarioActual, "Creación de producto", $"EL producto id {producto.Id} con nombre {producto.Nombre} fue creado");

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

        private EntidadFactory _entidadFactory;

        public ProductoService()
        {
            _entidadFactory = new EntidadFactory();
        }

        public void AgregarMarca(string nombre)
        {

            if (productoRepository == null)
            {
                throw new InvalidOperationException("El repositorio de productos no está inicializado.");
            }

            var nuevaMarca = (Marca)_entidadFactory.CrearEntidad("Marca");
            nuevaMarca.Nombre = nombre;

            // Llamar a la capa DAL para guardar la nueva marca
            marcaRepository.AgregarMarca(nuevaMarca);
        }

        public void AgregarProveedor(string nombre)
        {
            var nuevoProveedor = (Proveedor)_entidadFactory.CrearEntidad("Proveedor");
            nuevoProveedor.Nombre = nombre;

            // Lógica para guardar el proveedor en la base de datos
            // productoRepository.AgregarProveedor(nuevoProveedor);
        }

        public void AgregarCategoria(string nombre)
        {
            var nuevaCategoria = (Categoria)_entidadFactory.CrearEntidad("Categoria");
            nuevaCategoria.Nombre = nombre;

            // Lógica para guardar la categoría en la base de datos
            // productoRepository.AgregarCategoria(nuevaCategoria);
        }

    }
}