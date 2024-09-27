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

A lo largo del desarrollo de este proyecto, se han implementado varios patrones de diseño que ayudan a organizar el código, mejorar su mantenibilidad y promover buenas prácticas en el desarrollo de software:

### 1. **Singleton (Patrón de Creación)**
   - **Clase `Sesion`**: La clase `Sesion` utiliza el patrón Singleton para asegurar que solo exista una instancia de la sesión de usuario en todo el sistema. Este patrón es esencial para gestionar de manera eficiente la información de la sesión y prevenir la creación de múltiples sesiones simultáneas.
   
   **Ventajas**:
   - Evita la creación innecesaria de objetos.
   - Asegura que se trabaje siempre con la misma instancia para mantener la coherencia de los datos.

### 2. **Composite (Patrón Estructural)**
   - **Clase `Componente` y sus derivados `Patente` y `Familia`**: El patrón Composite se utiliza para estructurar jerárquicamente los permisos de usuarios. Cada `Componente` puede tener hijos que pueden ser permisos individuales (`Patente`) o conjuntos de permisos (`Familia`), lo que permite manejar roles complejos en la organización.

   **Ventajas**:
   - Simplifica el tratamiento de grupos y elementos individuales de permisos.
   - Permite una fácil extensión para añadir nuevos tipos de permisos o estructuras jerárquicas.

### 3. **Repository (Patrón de Acceso a Datos)**
   - **Clases en la capa DAL**: Se ha implementado el patrón Repository para abstraer el acceso a la base de datos. Este patrón facilita la persistencia y recuperación de entidades, como usuarios y permisos, ocultando la lógica de acceso a datos detrás de una interfaz común.

   **Ventajas**:
   - Desacopla la lógica de negocio de la lógica de acceso a datos.
   - Facilita el testeo unitario al permitir el uso de repositorios simulados (mocks).

### 4. **Factory (Patrón de Creación)**
   - **Creación de usuarios y permisos**: Aunque no explícitamente, se sigue el patrón Factory para encapsular la creación de objetos complejos, como usuarios y sus componentes, facilitando su inicialización desde diferentes capas del sistema.


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

