# Software de Gestión para Locales de Telefonía Celular

## Descripción del Proyecto

Este proyecto es una aplicación de escritorio diseñada para la gestión de locales de ventas de accesorios de telefonía celular. El enfoque principal está en la funcionalidad de autenticación y administración de usuarios, permitiendo que diferentes tipos de usuarios (Depósito, Gerente, Vendedor) vean diferentes interfaces de usuario.

## Funcionalidades Cubiertas

- **Autenticación de Usuarios**: La aplicación permite la autenticación segura de usuarios mediante el uso de hashing de contraseñas con sal.
- **Gestión de Usuarios**: Los usuarios pueden ser creados, asignados a roles específicos y administrados a través de una interfaz de usuario.
- **Roles de Usuario**: Se manejan tres tipos de roles:
  - **Gerente**: Acceso a la administración completa del sistema.
  - **Vendedor**: Acceso limitado a las funciones de ventas.
  - **Depósito**: Acceso a la gestión de inventario.
- **Bitácora de Transacciones**: Registro de todas las transacciones realizadas por los usuarios en el sistema, lo que permite llevar un control y auditoría de las actividades.

## Estructura del Proyecto

El proyecto está dividido en varias capas siguiendo la arquitectura en capas (Layered Architecture), lo que permite una separación clara de responsabilidades.

- **Domain**: Contiene las entidades y reglas de negocio fundamentales.
- **DAL (Data Access Layer)**: Maneja el acceso a la base de datos y las operaciones CRUD.
- **BLL (Business Logic Layer)**: Contiene la lógica de negocio y los servicios de la aplicación.
- **UI (User Interface)**: La capa de presentación que incluye las interfaces de usuario.

## Patrones de Diseño Utilizados

1. **Arquitectura en Capas (Layered Architecture)**: Separación de la aplicación en capas claras (Dominio, DAL, BLL, UI) para una mejor mantenibilidad y escalabilidad.
   
2. **Patrón de Inyección de Dependencias (Dependency Injection)**: Facilita la inyección de dependencias, promoviendo un código más limpio y fácil de mantener.
   
3. **Patrón de Fábrica (Factory)**: Utilizado para crear y manejar la instancia correcta de UI según el rol del usuario autenticado.
   
4. **Patrón Repositorio (Repository Pattern)**: Implementado en la DAL para gestionar el acceso a datos, proporcionando una capa de abstracción sobre la lógica de acceso a la base de datos.

5. **Patrón Estrategia (Strategy)**: La capa UI implementa la lógica para manejar diferentes interfaces según los roles de usuario, utilizando diferentes estrategias de interfaz.

6. **Patrón de Registro de Actividad (Logger Pattern)**: Implementado para registrar todas las transacciones y actividades en el sistema, facilitando auditorías y análisis.

## Requisitos Previos

- **Visual Studio 2019/2022** o superior.
- **.NET Framework 4.7.2** o superior.
- **SQL Server** para la base de datos.

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
    Password NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    DNI NVARCHAR(20) NOT NULL,
    Rol NVARCHAR(50) NOT NULL
);

CREATE TABLE Bitacora (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FechaHora DATETIME NOT NULL,
    Usuario NVARCHAR(100) NOT NULL,
    Accion NVARCHAR(255) NOT NULL,
    Detalle NVARCHAR(MAX) NULL
);
```

### 2. Configurar la Cadena de Conexión

En el archivo `Program.cs` de `GestionLocalesTelefonia.UI`, ajusta la cadena de conexión a tu base de datos:

```csharp
string connectionString = "Server=tu_servidor;Database=GestionLocalesTelefoniaDB;Integrated Security=True;";
```

### 3. Ejecutar la Aplicación

1. Abre la solución `GestionLocalesTelefonia.sln` en Visual Studio.
2. Compila la solución para asegurar que todos los proyectos se compilen correctamente.
3. Establece el proyecto `GestionLocalesTelefonia.UI` como el proyecto de inicio.
4. Ejecuta la aplicación.

## Contribuciones

Si deseas contribuir a este proyecto, sigue los pasos a continuación:

1. **Fork** el repositorio.
2. Crea una nueva rama (`feature/nueva-funcionalidad`).
3. Realiza tus cambios y confirma (`git commit -m 'Añadir nueva funcionalidad'`).
4. Haz un **push** a la rama (`git push origin feature/nueva-funcionalidad`).
5. Abre un **Pull Request**.

## Licencia

Este proyecto está bajo la licencia MIT. Consulta el archivo [LICENSE](LICENSE) para más detalles.

