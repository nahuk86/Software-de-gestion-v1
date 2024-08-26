En el desarrollo de la aplicación de gestión de locales de ventas de accesorios de telefonía celular, se siguieron varios patrones de diseño y buenas prácticas para garantizar un código modular, mantenible y escalable. A continuación, te detallo cuáles se utilizaron y cómo se aplicaron en el proyecto:

## Patrones de Diseño Utilizados

### 1. **Arquitectura en Capas (Layered Architecture)**
   - **Descripción**: Separa la aplicación en capas que cumplen diferentes responsabilidades: Dominio, Acceso a Datos (DAL), Lógica de Negocio (BLL), y la Interfaz de Usuario (UI).
   - **Aplicación**:
     - **Dominio**: Contiene las entidades básicas del negocio (`Usuario`).
     - **DAL**: Gestiona el acceso a la base de datos mediante la clase `UsuarioRepository`.
     - **BLL**: Implementa la lógica de negocio, como la autenticación y la asignación de roles, en la clase `UsuarioService`.
     - **UI**: Gestiona la interacción con el usuario a través de formularios (`Home_deposito`, `Home_gerente`, `Home_vendedor`), y se conecta con la BLL para procesar la lógica de negocio.

### 2. **Patrón de Inyección de Dependencias (Dependency Injection)**
   - **Descripción**: Este patrón permite inyectar dependencias en lugar de crearlas directamente dentro de los objetos, facilitando la prueba y mantenimiento del código.
   - **Aplicación**:
     - En `Program.cs`, se inyectan los manejadores de UI (`DepositoUIHandler`, `GerenteUIHandler`, `VendedorUIHandler`) en la fábrica `RoleBasedUIFactory` y esta se pasa al formulario de inicio de sesión (`LoginForm`). Esto permite que la lógica de negocio en BLL no dependa directamente de la UI.

### 3. **Patrón de Fábrica (Factory)**
   - **Descripción**: Proporciona una interfaz para crear objetos en una superclase, pero permite a las subclases alterar el tipo de objetos que se crearán.
   - **Aplicación**:
     - La clase `RoleBasedUIFactory` se utiliza para crear y devolver el manejador de UI adecuado (`DepositoUIHandler`, `GerenteUIHandler`, `VendedorUIHandler`) según el rol del usuario autenticado.

### 4. **Patrón Estrategia (Strategy)**
   - **Descripción**: Define una familia de algoritmos o comportamientos, encapsula cada uno y los hace intercambiables. El patrón Strategy permite que el algoritmo o comportamiento varíe independientemente de los clientes que lo usan.
   - **Aplicación**:
     - Los manejadores de UI (`DepositoUIHandler`, `GerenteUIHandler`, `VendedorUIHandler`) implementan la interfaz `IRoleBasedUI`, que define el método `MostrarUI()`. Según el rol del usuario, se utiliza una estrategia (manejador) diferente para mostrar la interfaz correcta.

### 5. **Patrón de Repositorio (Repository Pattern)**
   - **Descripción**: Proporciona una abstracción sobre el acceso a datos que permite la separación de la lógica de negocio del acceso a la base de datos.
   - **Aplicación**:
     - `UsuarioRepository` se encarga de todas las operaciones de acceso a datos relacionadas con la entidad `Usuario`, encapsulando los detalles de la base de datos y proporcionando una interfaz más limpia para el servicio `UsuarioService`.

## Buenas Prácticas Seguidas

### 1. **Separación de Responsabilidades (SoC - Separation of Concerns)**
   - **Descripción**: Consiste en dividir un programa en partes distintas, cada una de las cuales aborda una preocupación separada. Este enfoque facilita el mantenimiento y la escalabilidad.
   - **Aplicación**:
     - Cada capa de la aplicación tiene una responsabilidad clara y está bien delimitada. Por ejemplo, la capa UI no contiene lógica de negocio, y la capa BLL no gestiona la interacción con el usuario.

### 2. **Inversión de Control (IoC - Inversion of Control)**
   - **Descripción**: La idea es invertir el control del flujo del programa y de las dependencias, delegando la creación de instancias y la coordinación de clases a un framework o un contenedor.
   - **Aplicación**:
     - Mediante la inyección de dependencias en `Program.cs`, se logra que las dependencias sean inyectadas desde la capa de presentación en lugar de ser creadas dentro de las clases de la BLL, promoviendo el desacoplamiento.

### 3. **Modularidad**
   - **Descripción**: La modularidad en el código permite dividir el sistema en módulos intercambiables e independientes, que pueden ser desarrollados, testeados y mantenidos de manera autónoma.
   - **Aplicación**:
     - Cada componente (por ejemplo, los manejadores de UI) es modular y puede ser reemplazado o modificado sin afectar otras partes del sistema.

### 4. **Facilidad de Pruebas (Testability)**
   - **Descripción**: Al escribir código que es fácilmente testeable, se facilita la implementación de pruebas unitarias y de integración.
   - **Aplicación**:
     - El uso de inyección de dependencias y patrones como el de repositorio hacen que las clases sean más fáciles de probar en un entorno aislado.

### 5. **Uso de Nombres Descriptivos**
   - **Descripción**: Usar nombres claros y descriptivos para clases, métodos y variables, facilitando la comprensión del código.
   - **Aplicación**:
     - Los nombres de las clases (`UsuarioService`, `RoleBasedUIFactory`, `DepositoUIHandler`, etc.) reflejan claramente su propósito y función dentro del sistema.

### 6. **Evitar Código Duplicado**
   - **Descripción**: Mantener el código DRY (Don't Repeat Yourself) previene la duplicación, reduciendo la posibilidad de errores y facilitando el mantenimiento.
   - **Aplicación**:
     - La lógica compartida se centraliza en las clases de servicio y manejadores, evitando la duplicación de código en diferentes partes de la aplicación.

### 7. **Gestión de Errores**
   - **Descripción**: Implementar mecanismos para capturar y manejar errores de manera adecuada, proporcionando retroalimentación al usuario y previniendo fallas en el sistema.
   - **Aplicación**:
     - Se utilizan bloques de código que verifican condiciones como la autenticación fallida y la falta de reconocimiento de roles, proporcionando mensajes de error adecuados.

## Conclusión

El uso de patrones de diseño y buenas prácticas ha permitido crear una base sólida para la aplicación, haciendo que sea fácil de mantener y escalar en el futuro. La arquitectura modular y desacoplada asegura que nuevas funcionalidades puedan ser añadidas sin afectar negativamente al sistema existente, y que los diferentes componentes puedan ser desarrollados y probados de forma independiente.

Si necesitas más detalles o tienes alguna pregunta adicional sobre los patrones de diseño y buenas prácticas utilizadas, no dudes en preguntarme. ¡Estoy aquí para ayudarte!
