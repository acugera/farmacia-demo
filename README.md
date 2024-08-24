# Simulación de Sistema Administrativo para Farmacia

Este proyecto es una simulación de una aplicación administrativa para una farmacia, desarrollado como trabajo final de la materia **Programación de Aplicaciones Visuales** de la **Universidad Tecnológica Nacional Regional Córdoba (UTN FRC)**. El objetivo del proyecto es demostrar el conocimiento adquirido durante el curso, incluyendo la conexión con una base de datos Microsoft SQL Server Express, el prototipado de interfaces con Windows Forms (usando Visual Studio), el uso del lenguaje de programación C#, y el manejo de reportes y estadísticas.

## Índice

- [Escenario Planteado](#escenario-planteado)
- [Solución Planteada](#solución-planteada)
- [Características del Sistema](#características-del-sistema)
- [Base de Datos](#base-de-datos)
- [Casos de Uso](#casos-de-uso)

## Escenario Planteado

El funcionamiento básico de la farmacia es el siguiente:
- Un cliente ingresa a la farmacia y solicita un medicamento, que puede estar recetado o no.
- Se verifica si el medicamento requiere receta, la cual debe ser presentada.
- La farmacia tiene convenios con distintas obras sociales que otorgan descuentos en los medicamentos.
- Al realizar una venta, se actualiza el stock del medicamento. Si no hay suficiente stock, la venta no se puede completar.
- Se entrega el ticket al cliente junto con el medicamento.
- Al final del día, se verifica el stock de medicamentos, y se genera una nota de pedido para aquellos que están por debajo del nivel mínimo.

## Solución Planteada

Se desarrolló un programa en C# con una interfaz gráfica que permite:
- **Ingreso al sistema**: Pantalla de login que solicita usuario y contraseña.
- **Roles de usuario**: Dependiendo del rol (Empleado o Administrador), se permite acceder a diferentes funcionalidades.

### Funcionalidades por Rol

#### Administrador:
- **ABM**: Gestión completa (Alta, Baja, Modificación) de Stock, Descuentos, Laboratorios, Medicamentos, Obras Sociales, Empleados, Clientes, y Tipos de Usuario.
- **Consultas**: Posibilidad de consultar todos los elementos anteriores.
- **Reportes**: Generación de listados y estadísticas detalladas.

#### Empleado:
- **Consultas**: Acceso a información de Stock, Descuentos, Laboratorios, Medicamentos, Obras Sociales, Empleados, y Clientes.
- **Procesos**: Registro y consulta de ventas y notas de pedido.

## Características del Sistema

### Cargas y Procesos
- **Ventas**
- **Notas de pedido**

### Listados y Reportes
- **Listado de notas de pedido**: Filtros por medicamento y laboratorio, ordenado por cantidad y fecha.
- **Listado de ventas**: Filtros por tipo de factura, precio mínimo y máximo, ordenado por precio y fecha.

### Estadísticas
- **Medicamentos más vendidos**
- **Empleados con más ventas**

## Base de Datos

El sistema utiliza una base de datos en **Microsoft SQL Server Express** para almacenar toda la información relevante. A continuación, se muestra el diagrama de la base de datos:

![Base de datos Farmacia](https://github.com/acugera/farmacia-demo/blob/main/FarmaciaDB.png?raw=true "Base de datos Farmacia")

## Casos de Uso
| U.C. Id | Descripción |
| ------------ | ------------ |
| 1  | Registrar Laboratorio|
| 2  | Modificar Laboratorio|
| 3  | Consultar Laboratorio|
| 4  | Registrar Medicamento         |
| 5  | Consultar Medicamento         |
| 6  | Modificar Medicamento         |
| 7  | Registrar Obra Social         |
| 8  | Modificar Obra Social         |
| 9  | Consultar Obra Social         |
| 10 | Registrar Empleado            |
| 11 | Modificar Empleado            |
| 12 | Consultar Empleado            |
| 13 | Registrar Cliente             |
| 14 | Modificar Cliente             |
| 15 | Consultar Cliente             |
| 16 | Dar de baja Cliente           |
| 17 | Registrar Venta               |
| 18 | Consultar Venta               |
| 19 | Registrar Nota de Pedido      |
| 20 | Consultar Nota de Pedido      |
| 21 | Modificar Nota de Pedido      |
| 22 | Registrar Descuento           |
| 23 | Modificar Descuento           |
| 24 | Consultar Stock               |
| 25 | Registrar Usuario             |
| 26 | Modificar Usuario             |
| 27 | Dar de baja Usuario           |
| 28 | Consultar Usuario             |
| 29 | Registrar Tipo de Usuario     |
| 30 | Modificar Tipo de Usuario     |
| 31 | Dar de baja Tipo de Usuario   |
| 32 | Registrar Descuento           |
| 33 | Modificar Descuento           |
| 34 | Dar de baja Descuento         |
