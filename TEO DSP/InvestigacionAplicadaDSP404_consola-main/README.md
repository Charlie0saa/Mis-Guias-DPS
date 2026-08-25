# Gestor de Tareas (To-Do List) — Aplicación de Consola en C#

Aplicación de consola desarrollada en C# (.NET 8) para que un equipo de
desarrollo pueda registrar, listar, completar y eliminar tareas pendientes,
con persistencia en un archivo de texto para no perder la información al
cerrar el programa.

## Cómo ejecutar el proyecto

```bash
cd GestorTareas
dotnet build
dotnet run
```

Al iniciar, el programa carga automáticamente las tareas guardadas en
`tareas.csv` (si el archivo no existe, se crea vacío en la primera
operación). Cada vez que se agrega, completa o elimina una tarea, el archivo
se sobrescribe con el estado actualizado.

## Estructura del proyecto

| Archivo | Responsabilidad |
|---|---|
| `Program.cs` | Menú principal, interacción con el usuario y manejo de excepciones. |
| `Tarea.cs` | Clase POO que modela una tarea (título, descripción, fecha, estado) y su serialización a texto. |
| `TareaRepositorio.cs` | Lectura/escritura del archivo `tareas.csv` con `StreamReader`/`StreamWriter`. |
| `TareaNoEncontradaException.cs` | Excepción personalizada lanzada cuando se busca una tarea por Id que no existe. |

## Requerimientos cubiertos

- **POO y colecciones genéricas**: clase `Tarea` con atributos título,
  descripción, fecha y estado (`enum EstadoTarea`); las tareas se manejan en
  memoria con `List<Tarea>`.
- **Manejo de excepciones**: validación de opciones de menú, campos vacíos,
  formatos de fecha e Id inválidos, con bloques `try-catch-finally`;
  excepción personalizada `TareaNoEncontradaException`.
- **Persistencia**: guardado y carga automática en `tareas.csv` usando
  `StreamWriter`/`StreamReader`.
- **Menú por consola**: opciones para agregar, listar, completar, eliminar
  tareas y salir, con mensajes de confirmación y error.

## Uso de GitHub Copilot durante el desarrollo

A continuación se documentan al menos 3 prompts utilizados con Copilot y
cómo se ajustó el código que sugirió (completar esta sección con las
capturas/registro real de tu equipo; se deja una plantilla de ejemplo
basada en el flujo típico de desarrollo de este proyecto):

### Prompt 1
**Prompt usado:**
> "Genera una clase Tarea en C# con Id, Título, Descripción, Fecha y un
> estado que pueda ser Pendiente o Completada."

**Sugerencia de Copilot:** propuso la clase con el estado representado como
`string` ("Pendiente"/"Completada").

**Ajuste realizado:** se reemplazó el `string` por un `enum EstadoTarea`
para evitar valores inválidos escritos a mano y aprovechar el chequeo de
tipos del compilador, y se agregaron los métodos `ToLineaArchivo()` /
`FromLineaArchivo()` para la persistencia en CSV.

### Prompt 2
**Prompt usado:**
> "Escribe un método en C# que guarde una lista de tareas en un archivo de
> texto usando StreamWriter, y otro que las cargue con StreamReader."

**Sugerencia de Copilot:** generó los métodos básicos de lectura/escritura,
pero sin manejo de errores ni validación de líneas corruptas.

**Ajuste realizado:** se envolvieron ambos métodos en bloques
`try-catch-finally`, capturando `IOException` y `UnauthorizedAccessException`
por separado, y se agregó lógica para omitir (en vez de fallar por completo)
líneas del archivo con formato inválido, reportándolas al usuario.

### Prompt 3
**Prompt usado:**
> "Cómo creo una excepción personalizada en C# para cuando no se encuentra
> una tarea por su Id."

**Sugerencia de Copilot:** propuso una clase `TareaNoEncontradaException`
heredando de `Exception` con un constructor de mensaje simple.

**Ajuste realizado:** se agregó una propiedad `IdBuscado` para conservar el
Id que causó el error, útil para mensajes más claros y para futuras pruebas
o registros de log.

### Prompt 4 (opcional, menú y validaciones)
**Prompt usado:**
> "Ayúdame a validar la opción del menú y el Id ingresado por el usuario en
> una app de consola en C#, lanzando una excepción si el valor no es
> válido."

**Sugerencia de Copilot:** sugirió usar `int.TryParse` directamente en el
flujo principal.

**Ajuste realizado:** se centralizó la lectura y validación del Id en el
método `LeerIdDesdeConsola`, usando `int.Parse` dentro de un `try-catch`
que traduce `FormatException`/`OverflowException` en un
`ArgumentException` con un mensaje orientado al usuario, manteniendo el
manejo de errores consistente con el resto del programa.

> **Nota:** reemplaza estos prompts de ejemplo con los prompts reales que tu
> equipo utilizó en Copilot Chat / sugerencias inline, incluyendo capturas
> de pantalla si el formato de entrega lo permite.

### Prompt 5 (Manejo de Excepciones I/O)
**Prompt usado:**
> "Modifica los métodos CargarTareasIniciales y GuardarCambios para capturar excepciones específicas como FileNotFoundException y IOException en lugar de un Exception genérico."

**Ajuste realizado:** se reemplazó el bloque genérico por capturas específicas para darle al usuario retroalimentación exacta sobre si el archivo no existe o está bloqueado por otro proceso.


## Ejemplo de uso

```
========== GESTOR DE TAREAS ==========
1. Agregar tarea
2. Listar tareas
3. Completar tarea
4. Eliminar tarea
5. Salir
Elige una opción: 1
Título de la tarea: Preparar entrega del sprint
Descripción: Revisar checklist final antes de la demo
Fecha límite (yyyy-MM-dd), o Enter para hoy: 2026-08-15
Tarea agregada correctamente con Id 1.
```
