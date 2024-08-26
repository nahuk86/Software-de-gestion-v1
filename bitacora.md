## Patrones de Diseño Utilizados

### 1. **Arquitectura en Capas (Layered Architecture)**
   - **Descripción**: Separa la aplicación en diferentes capas que cumplen con distintas responsabilidades: Dominio, Acceso a Datos (DAL), Lógica de Negocio (BLL), e Interfaz de Usuario (UI).
   - **Aplicación**:
     - **Dominio**: Contiene las entidades básicas del negocio (`Usuario`).
     - **DAL**: Gestiona el acceso a la base de datos mediante `UsuarioRepository`.
     - **BLL**: Implementa la lógica de negocio, como la autenticación y la asignación de roles, en `UsuarioService`. También contiene la fábrica `RoleBasedUIFactory`, que decide qué manejador de UI debe ser utilizado según el rol del usuario.
     - **UI**: Gestiona la interacción con el usuario a través de formularios (`Pantalla_inicio`, `Home_deposito`, `Home_gerente`, `Home_vendedor`) y maneja la presentación basada en el rol del usuario utilizando los manejadores de UI proporcionados por la capa BLL.

### 2. **Patrón de Inyección de Dependencias (Dependency Injection)**
   - **Descripción**: Este patrón permite que las dependencias sean inyectadas en lugar de ser creadas directamente dentro de las clases, facilitando la prueba y mantenimiento del código.
   - **Aplicación**:
     - En `Program.cs` dentro del proyecto UI, se configuran e inyectan los manejadores de UI (`DepositoUIHandler`, `GerenteUIHandler`, `VendedorUIHandler`) en la fábrica `RoleBasedUIFactory`, la cual reside en la capa BLL. Esta fábrica luego se pasa al formulario principal `Pantalla_inicio`, permitiendo a la BLL seleccionar el manejador adecuado basado en el rol del usuario.

### 3. **Patrón de Fábrica (Factory)**
   - **Descripción**: Proporciona una interfaz para crear objetos en una superclase, pero permite a las subclases alterar el tipo de objetos que se crearán.
   - **Aplicación**:
     - La clase `RoleBasedUIFactory`, ubicada en la capa BLL, se utiliza para crear y devolver el manejador de UI adecuado (`DepositoUIHandler`, `GerenteUIHandler`, `VendedorUIHandler`) según el rol del usuario autenticado. Esta fábrica desacopla la lógica de selección de UI de la capa de presentación, centralizándola en la lógica de negocio.

### 4. **Patrón Estrategia (Strategy)**
   - **Descripción**: Define una familia de algoritmos o comportamientos, encapsula cada uno y los hace intercambiables. El patrón Strategy permite que el algoritmo o comportamiento varíe independientemente de los clientes que lo usan.
   - **Aplicación**:
     - Los manejadores de UI (`DepositoUIHandler`, `GerenteUIHandler`, `VendedorUIHandler`) implementan la interfaz `IRoleBasedUI`, que define el método `MostrarUI()`. Según el rol del usuario, la BLL selecciona y utiliza una estrategia (manejador) diferente para mostrar la interfaz correspondiente.

### 5. **Patrón de Repositorio (Repository Pattern)**
   - **Descripción**: Proporciona una abstracción sobre el acceso a datos que permite la separación de la lógica de negocio del acceso a la base de datos.
   - **Aplicación**:
     - `UsuarioRepository` en la capa DAL se encarga de todas las operaciones de acceso a datos relacionadas con la entidad `Usuario`, encapsulando los detalles de la base de datos y proporcionando una interfaz más limpia para el servicio `UsuarioService`.

## Buenas Prácticas Seguidas

### 1. **Separación de Responsabilidades (SoC - Separation of Concerns)**
   - **Descripción**: Consiste en dividir un programa en partes distintas, cada una de las cuales aborda una preocupación separada. Este enfoque facilita el mantenimiento y la escalabilidad.
   - **Aplicación**:
     - Cada capa de la aplicación tiene una responsabilidad clara y bien definida. La UI maneja la presentación y la interacción con el usuario, BLL maneja la lógica de negocio (incluyendo la fábrica de selección de UI), y DAL maneja el acceso a los datos.

### 2. **Inversión de Control (IoC - Inversion of Control)**
   - **Descripción**: La idea es invertir el control del flujo del programa y de las dependencias, delegando la creación de instancias y la coordinación de clases a un framework o un contenedor.
   - **Aplicación**:
     - La inyección de dependencias se realiza en `Program.cs` del proyecto UI, donde se inyectan los manejadores de UI en la fábrica `RoleBasedUIFactory`, la cual es luego utilizada por `Pantalla_inicio` para gestionar la presentación basada en roles.

### 3. **Modularidad**
   - **Descripción**: La modularidad en el código permite dividir el sistema en módulos intercambiables e independientes, que pueden ser desarrollados, testeados y mantenidos de manera autónoma.
   - **Aplicación**:
     - Cada componente, como los manejadores de UI y las clases de servicio, es modular y puede ser reemplazado o modificado sin afectar otras partes del sistema.

### 4. **Facilidad de Pruebas (Testability)**
   - **Descripción**: Al escribir código que es fácilmente testeable, se facilita la implementación de pruebas unitarias y de integración.
   - **Aplicación**:
     - El uso de inyección de dependencias y patrones como el de repositorio hacen que las clases sean más fáciles de probar en un entorno aislado. La fábrica `RoleBasedUIFactory` centraliza la lógica de selección, permitiendo que las diferentes estrategias de UI sean testeadas independientemente.

### 5. **Uso de Nombres Descriptivos**
   - **Descripción**: Usar nombres claros y descriptivos para clases, métodos y variables, facilitando la comprensión del código.
   - **Aplicación**:
     - Los nombres de las clases (`UsuarioService`, `RoleBasedUIFactory`, `DepositoUIHandler`, `Pantalla_inicio`, etc.) reflejan claramente su propósito y función dentro del sistema.

### 6. **Evitar Código Duplicado**
   - **Descripción**: Mantener el código DRY (Don't Repeat Yourself) previene la duplicación, reduciendo la posibilidad de errores y facilitando el mantenimiento.
   - **Aplicación**:
     - La lógica compartida, como la autenticación y la asignación de roles, se centraliza en las clases de servicio, mientras que la lógica de presentación específica se mantiene en los manejadores de UI, evitando duplicación de código.

### 7. **Gestión de Errores**
   - **Descripción**: Implementar mecanismos para capturar y manejar errores de manera adecuada, proporcionando retroalimentación al usuario y previniendo fallas en el sistema.
   - **Aplicación**:
     - Se utilizan bloques de código que verifican condiciones como la autenticación fallida y la falta de reconocimiento de roles, proporcionando mensajes de error adecuados en `Pantalla_inicio`.

## Conclusión

La implementación de estos patrones de diseño y buenas prácticas ha permitido desarrollar una aplicación sólida, modular y fácil de mantener. Al centralizar la lógica en la capa adecuada, como la fábrica de UI en la BLL y los manejadores específicos en la UI, el sistema es escalable y permite futuras extensiones sin comprometer la arquitectura existente.

Si necesitas más detalles o tienes alguna pregunta adicional sobre los patrones de diseño y buenas prácticas utilizadas, estaré encantado de ayudarte. ¡No dudes en preguntar!
