# Gestión de Locales de Ventas de Accesorios de Telefonía Celular

## Descripción del Proyecto

Este proyecto es una aplicación de escritorio para la gestión de locales de ventas de accesorios de telefonía celular. El enfoque actual está en la funcionalidad de autenticación y la administración de usuarios según sus roles, permitiendo que diferentes tipos de usuarios (Depósito, Gerente, Vendedor) vean diferentes interfaces de usuario.

## Estructura del Proyecto

La solución está dividida en varias capas siguiendo la arquitectura en capas (Layered Architecture), lo que permite una separación clara de responsabilidades.

```
GestionLocalesTelefonia.sln
|
|-- GestionLocalesTelefonia.Dominio
|   |-- Usuario.cs
|
|-- GestionLocalesTelefonia.DAL
|   |-- UsuarioRepository.cs
|
|-- GestionLocalesTelefonia.BLL
|   |-- Interfaces
|   |   |-- IRoleBasedUI.cs                 // Interfaz para las estrategias de UI según roles
|   |-- Services
|   |   |-- UsuarioService.cs               // Servicio que maneja la lógica de usuarios y roles
|   |-- UIHandlers
|   |   |-- RoleBasedUIFactory.cs           // Fábrica para crear la instancia correcta de UI según el rol
|
|-- GestionLocalesTelefonia.UI
|   |-- Forms
|   |   |-- Home_deposito.cs                // Formulario para el rol de Depósito
|   |   |-- Home_deposito.Designer.cs
|   |   |-- Home_gerente.cs                 // Formulario para el rol de Gerente
|   |   |-- Home_gerente.Designer.cs
|   |   |-- Home_vendedor.cs                // Formulario para el rol de Vendedor
|   |   |-- Home_vendedor.Designer.cs
|   |-- Program.cs                          // Punto de entrada de la aplicación, configuración de dependencias
|   |-- Pantalla_inicio.cs                  // Formulario principal, maneja la autenticación y la navegación según roles
|   |-- Pantalla_inicio.Designer.cs
|   |-- UIHandlers
|       |-- DepositoUIHandler.cs            // Manejador de UI para el rol de Depósito
|       |-- GerenteUIHandler.cs             // Manejador de UI para el rol de Gerente
|       |-- VendedorUIHandler.cs            // Manejador de UI para el rol de Vendedor
```

## Requisitos Previos

- **Visual Studio 2019/2022** o superior.
- **.NET Framework 4.7.2** o superior.
- **SQL Server** (local o en la nube) para la base de datos.

## Configuración del Proyecto

### 1. Configurar la Base de Datos

Ejecuta el siguiente script SQL para crear la base de datos y las tablas necesarias:

```sql
CREATE DATABASE GestionLocalesTelefoniaDB;
GO

USE GestionLocalesTelefoniaDB;
GO

CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(255) NOT NULL
);

CREATE TABLE RolesUsuarios (
    UsuarioId INT PRIMARY KEY,
    Rol NVARCHAR(50) NOT NULL,
    FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id)
);

-- Insertar algunos usuarios y roles de prueba
INSERT INTO Usuarios (Username, Password)
VALUES ('admin', 'admin123'), ('deposito', 'deposito123'), ('gerente', 'gerente123'), ('vendedor', 'vendedor123');

INSERT INTO RolesUsuarios (UsuarioId, Rol)
VALUES 
    (1, 'Admin'),
    (2, 'deposito'),
    (3, 'gerente'),
    (4, 'vendedor');
```

### 2. Configurar la Cadena de Conexión

En el archivo `Program.cs` de `GestionLocalesTelefonia.UI`, actualiza la cadena de conexión a tu base de datos:

```csharp
string connectionString = "Server=tu_servidor;Database=GestionLocalesTelefoniaDB;Integrated Security=True;";
```

### 3. Ejecutar la Aplicación

1. Abre la solución `GestionLocalesTelefonia.sln` en Visual Studio.
2. Compila la solución para asegurarte de que todos los proyectos se compilan correctamente.
3. Establece `GestionLocalesTelefonia.UI` como el proyecto de inicio.
4. Ejecuta la aplicación.

## Uso de la Aplicación

1. **Inicio de Sesión**: Ingresa un nombre de usuario y contraseña.
2. **Navegación por Rol**: Según el rol del usuario autenticado, la aplicación mostrará la interfaz correspondiente (`Home_deposito`, `Home_gerente`, `Home_vendedor`).

## Patrones de Diseño Utilizados

### 1. **Arquitectura en Capas (Layered Architecture)**
   - Separa la aplicación en diferentes capas: Dominio, DAL, BLL y UI.

### 2. **Patrón de Inyección de Dependencias (Dependency Injection)**
   - Permite la inyección de dependencias, facilitando la prueba y mantenimiento del código.

### 3. **Patrón de Fábrica (Factory)**
   - La clase `RoleBasedUIFactory` en la BLL se utiliza para crear y devolver el manejador de UI adecuado según el rol del usuario autenticado.

### 4. **Patrón Estrategia (Strategy)**
   - Los manejadores de UI implementan la interfaz `IRoleBasedUI`, proporcionando diferentes implementaciones para diferentes roles de usuario.

### 5. **Patrón de Repositorio (Repository Pattern)**
   - `UsuarioRepository` en la DAL encapsula las operaciones de acceso a datos, proporcionando una interfaz limpia para `UsuarioService`.

## Buenas Prácticas Seguidas

### 1. **Separación de Responsabilidades (SoC)**
   - Cada capa tiene responsabilidades claras y bien definidas.

### 2. **Inversión de Control (IoC)**
   - Implementada a través de la inyección de dependencias en `Program.cs`.

### 3. **Modularidad**
   - Los componentes son modulares y pueden ser desarrollados, testeados y mantenidos de manera independiente.

### 4. **Facilidad de Pruebas**
   - Las clases están diseñadas para ser fácilmente testeables, gracias a la inyección de dependencias y patrones de diseño.

### 5. **Uso de Nombres Descriptivos**
   - Los nombres de clases, métodos y variables son claros y reflejan su propósito.

### 6. **Evitar Código Duplicado**
   - La lógica compartida se centraliza, evitando duplicación de código.

### 7. **Gestión de Errores**
   - Implementada para proporcionar retroalimentación adecuada al usuario y prevenir fallos en el sistema.

## Próximos Pasos

- **Gestión de Productos**: Agregar funcionalidad para gestionar productos en el inventario.
- **Módulo de Ventas**: Implementar la funcionalidad para gestionar las ventas y generar reportes.
- **Seguridad**: Implementar hashing de contraseñas y mejorar las validaciones de seguridad.

## Contribución

Si deseas contribuir a este proyecto, sigue los pasos a continuación:

1. **Fork** el repositorio.
2. Crea una nueva rama (`feature/nueva-funcionalidad`).
3. Realiza tus cambios y confirma los commits.
4. Abre un **Pull Request** para revisión.

## Licencia

Este proyecto está bajo la licencia MIT. Consulta el archivo `LICENSE` para más detalles.

## Contacto

Para cualquier consulta, puedes contactarme en [tu-email@dominio.com].
```

### Instrucciones para Usar el `README.md`

1. **Crea un archivo `README.md`** en la raíz de tu proyecto.
2. **Copia y pega** el contenido proporcionado en este archivo.
3. **Ajusta** cualquier detalle específico, como el nombre del servidor, correo electrónico u otros aspectos de configuración que sean únicos para tu entorno.

Este archivo `README.md` refleja la estructura y las prácticas actuales del proyecto, proporcionando una guía clara sobre cómo configurarlo, ejecutarlo, y las decisiones arquitectónicas clave que se tomaron. Si necesitas más ajustes o información adicional, ¡estoy aquí para ayudarte!
