# 📊 Sistema de Reportes de Ventas

Aplicación de escritorio desarrollada en **C# con WinForms** y conexión a base de datos **MySQL**. Genera reportes dinámicos de ventas seleccionando el tipo desde un menú desplegable.

## 🖥️ Vista previa
[![imagen-2026-03-27-160930777.png](https://i.postimg.cc/MGsv7h8k/imagen-2026-03-27-160930777.png)](https://postimg.cc/cKnxZkHT)

## 🚀 Funcionalidades
- 📦 Reporte de producto más vendido
- 💰 Reporte de total de ingresos por producto
- 📅 Reporte de ventas por día
- 🔄 Visualización dinámica en tabla (DataGridView)
- ❌ Botón para cerrar la aplicación

## 🛠️ Tecnologías usadas
- C# .NET 4.7.2 — WinForms
- MySQL
- MySql.Data (conector oficial)
- ConfigurationManager (conexión desde App.config)

## ⚙️ Requisitos para correrlo
- Visual Studio 2022 o superior
- MySQL Server corriendo localmente
- Paquetes NuGet: `MySql.Data` y `System.Configuration`

## 🗄️ Estructura de la base de datos
```sql
CREATE DATABASE sistema_ventas;

CREATE TABLE productos (
  id     INT PRIMARY KEY AUTO_INCREMENT,
  nombre VARCHAR(100),
  precio DOUBLE
);

CREATE TABLE ventas (
  id          INT PRIMARY KEY AUTO_INCREMENT,
  id_producto INT,
  cantidad    INT,
  fecha       DATE,
  FOREIGN KEY (id_producto) REFERENCES productos(id)
);
```

## ⚙️ Configuración de conexión
En `App.config` actualiza con tus credenciales de MySQL:
```xml
<add name="MiBaseDatos"
     connectionString="server=localhost;database=sistema_ventas;uid=TU_USUARIO;pwd=TU_PASSWORD;"
     providerName="MySql.Data.MySqlClient"/>
```

## 📁 Estructura del proyecto
```
reportsForm/
├── Form1.cs        — Formulario principal y lógica de reportes
├── Conexion.cs     — Clase de conexión a MySQL
└── App.config      — Configuración de cadena de conexión
```

## 👨‍💻 Autor
**Steven Herrarte Aquino**  
Estudiante de Ingeniería en Sistemas — Universidad Mariano Gálvez  
📧 antonyaquino444@gmail.com
