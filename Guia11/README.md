# Guía 11 - Entity Framework (C# + SQL Server)

1. Ejecutar `Guia11.sql` en SQL Server Management Studio (crea `bdd_udb` y la tabla `persona`).
2. Abrir `GuiaEntity.sln` en Visual Studio (Windows, .NET Framework 4.8; restaura el paquete NuGet EntityFramework 6.4.4).
3. En `GuiaEntity/App.config` cambiar `data source=.` por el nombre de su servidor.
4. Ejecutar: Form1 lista las personas; Nuevo / Editar / Eliminar abren `FrmTabla` o modifican la tabla.

Nota: el modelo (`Modelo/Persona.cs` y `Modelo/bdd_udbEntities.cs`) es equivalente al que genera el asistente
"ADO.NET Entity Data Model" (mismo namespace `GuiaEntity.Modelo`, contexto `bdd_udbEntities`), pero escrito a mano
para que el proyecto compile sin ejecutar el asistente gráfico.
