# 🚀 SQL Server con Docker - RecetasDB

Este proyecto levanta un contenedor de **SQL Server 2022** en Docker y crea automáticamente la base de datos `RecetasDB` con sus tablas (`Categorias`, `Recetas`, `Ingredientes`).

---

## 📂 Archivos necesarios
- `Dockerfile` → define la imagen personalizada de SQL Server.
- `init.sql` → script de inicialización con la creación de la base de datos y tablas.

---

## 🛠️ Construcción de la imagen

En la carpeta del proyecto, ejecuta:

```bash
docker build -t recetas-sqlserver .
