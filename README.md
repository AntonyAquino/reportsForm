
# 📊 Sistema de Reportes de Ventas con Exportación a Excel

Aplicación de escritorio en **C# WinForms** conectada a **MySQL** que genera reportes dinámicos de ventas y los exporta directamente a Excel.

## 🖥️ Vista previa
[![imagen-2026-03-27-163342634.png](https://i.postimg.cc/mrMTDJ2X/imagen-2026-03-27-163342634.png)](https://postimg.cc/PLtgV6DY)

## 🚀 Funcionalidades
- 📦 Reporte de producto más vendido
- 💰 Reporte de total de ingresos por producto
- 📅 Reporte de ventas por día
- 📤 Exportación de reportes a Excel (.xlsx)
- 🔄 Visualización dinámica en DataGridView

## 🛠️ Tecnologías usadas
- C# .NET 4.7.2 — WinForms
- MySQL
- MySql.Data
- ClosedXML (exportación a Excel)
- ConfigurationManager

## ⚙️ Requisitos
- Visual Studio 2022 o superior
- MySQL Server local
- NuGet: `MySql.Data`, `ClosedXML`

## 🗄️ Base de datos
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

## 📁 Estructura
```
reportsForm/
├── Form1.cs      — Formulario principal
├── Conexion.cs   — Conexión MySQL
└── App.config    — Cadena de conexión
```

## 👨‍💻 Autor
**Steven Herrarte Aquino**  

Estudiante de Ingeniería en Sistemas — Universidad Mariano Gálvez  

