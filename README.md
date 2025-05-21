# SolucionServicios - Proyecto ASP.NET Web Service

Este proyecto consiste en el desarrollo completo de una solución ASP.NET Web Forms que incluye:
- Un servicio web (ASMX) que expone datos desde una base de datos SQL Server.
- Un cliente web que consume dicho servicio para listar y buscar usuarios.

## Estructura del Proyecto

- **Servicios/**  → Proyecto Web que contiene:
  - `MiServicio.asmx`: Servicio web tipo ASMX.
  - `BD.cs`: Clase auxiliar para conexión a base de datos con ADO.NET.
  - `App_Data`: Contiene el modelo de base de datos local si se utiliza.

- **Cliente/** → Proyecto Web cliente que consume el servicio:
  - `ClienteWS.aspx`: Página web que muestra listado de usuarios.
  - `ClienteWS.aspx.cs`: Lógica del lado servidor (C#) que invoca el servicio.
  - Referencia Web al servicio (`MiServicio.asmx`).

## Tecnologías Utilizadas

- ASP.NET Web Forms (.NET Framework 4.7.2)
- Web Services ASMX (SOAP)
- SQL Server Express (localdb)
- ADO.NET (clase `SqlConnection`, `SqlDataAdapter`)
- Visual Studio 2022

## Funcionalidades

- **Servicio Web**:
  - `HelloWorld()`: Método de prueba por defecto.
  - `Listado()`: Retorna todos los usuarios.
  - `ListadoParametro(string rut)`: Retorna un usuario según su RUT.

- **Cliente Web**:
  - Carga automática del listado completo en `Page_Load`.
  - Búsqueda de usuario por RUT mediante `TextBox` + `Button`.
  - Visualización de resultados en `GridView`.

## Cómo Ejecutar

1. Abrir la solución en Visual Studio 2022.
2. Crear una BD en SQL Server con una tabla Usuarios y dos columnas, 'rut' y 'clave'.
3. Establecer el proyecto `Cliente` como StartUp.
4. Ejecutar con IIS Express.
5. El cliente se comunicará con el servicio y mostrará los datos.

## Capturas

- Página principal:
  - Visualización de todos los usuarios.
  - Búsqueda por RUT.

---

## Autor

**Remigio Stocker**  

---

## Notas

Este proyecto implementa la arquitectura **cliente/servidor** utilizando SOAP con WebForms, sin uso de tecnologías modernas como Web API o REST. Ideal para entender los fundamentos de los servicios web clásicos en .NET Framework.
