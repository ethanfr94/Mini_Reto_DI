# 🔥Documentación de la Interfaz - ProjectStore🔥

# Realizado por el Equipo 1🏅
- Cristian👨‍💻
- Raúl👨‍💻
- Ethan👨‍💻
- Miguel👨‍💻
- Leila👩‍💻

## Tabla de contenidos📝

1. [Introducción](#introducción)
2. [Configuración](#configuración)
3. [Metodos principales](#metodos-principales)
4. [Estructura de ProjectStore](#estructura-de-projectstore)
5. [Modelos (Entities)](#modelos-entities)
6. [Vistas](#vistas)

## Introducción🚀

Esta interfaz utiliza la API para gestionar los registros de la base de datos Proyectos del I.E.S. Miguel Herrero, con funcionalidades para ver los registros  sobre alumnos, profesores y proyectos realizados, 
añadir nuevos, eliminar elementos, modificar los existentes y ver los datos de los proyectos guardados.


## Configuración⚙️

En la carpeta configuracion encontramos el fichero 'APIConnection.cs' en el cual se recogen las implementaciones de los metodos recogidos en la API, 
utilizando HttpClient para conectarnos mediante internet a la APi y utilizar dichos metodos.

## Metodos principales🍃

### Metodos para recoger una entidad concreta

`GetAlumnoById(string id)`

`GetProfesorById(string id)`

`GetProyectoById(int id)`

`GetCicloById(string id)`


### Metodos para recoger todos los registros de cada tabla

`GetAllAlumnos()`

`GetAllProfesores()`

`GetAllCiclos()`

`GetAllProyectos()`

`GetRealizan()`

`GetEvaluan()`

### Metodos para insertar registros

  `PostAlumno(Alumno alumno)`
  
  `PostProfesor(Profesor profesor)`
  
  `PostProyecto(Proyecto proyecto)`
  
  `PostEntity<T>(string url, T entidad) //genérico`

### Metodos de modificacion de registros

  `UpdateAlumno(Alumno alumno)`
  
  `UpdateProfesor(Profesor profesor)`
  
  `UpdateProyecto(Proyecto proyecto)`
  
  `UpdateEntity<T>(string url, T entidad) //genérico`

### Metodo de comprobacion de usuario para el Loggin

  `GetProfesorByCredentials(string correo, string password) //recoge si existe en la base de datos un profesor con esos datos`

### Metodos de subida y descarga de ficheros

  `Download(int id_proyecto, string etapa_proyecto)`
  
  `Upload(int id_proyecto, string rutaFichero)`

### Metodos de eliminacion de registros concretos

  `DeleteProyecto(int id)`
  
  `DeleteProfesor(string id)`
  
  `DeleteAlumno(string id)`

## Estructura de ProjectStore🏗️

El proyecto sigue una estructura organizada en paquetes separando las vistas de la interfaz de las entidades, el acceso a la API
y las APIUtilities

## Modelos (Entities)📚

```cs
public enum Genero
{
  M,
  F,
  NB
}

public enum Familia
{
  ADG,
  FME,
  IFC,
  TMA
}

public enum Tipo
{
  Final,
  Intermodular
}

public class Alumno{
    private string id;
    private string nombre;
    private string apellidos;
    private string dni;
    private string email;
    private string contraseña;
    private string telefono;
    private Genero genero;
    private DateTime fechaNacimiento;
    private bool activo;
    private Ciclo ciclo;
}

public class Profesor{
    private string id;
    private string nombre;
    private string apellidos;
    private string dni;
    private string email;
    private string contraseña;
    private string telefono;
    private Genero genero;
    private DateTime fechaNacimiento;
    private string especialidad;
    private bool activo;
    private bool admin;
}

public class Ciclo{
    private string codigo;
    private string nombre;
    private string etapa;
    private string titulo;
    private string curriculo;
    private string familia;
}

public class Proyecto{
    private int id;
    private string nombre;
    private string tipo;
    private string resumen;
    private int? anioAcademico;
    private DateTime? fechaPresentacion;
    private string logo;
    private string memoria;
    private string archivos;
    private string comentarios;
    private Ciclo ciclo;
    private Profesor? tutor;
}

public class Realizan{
    private int id;
    private int calificacion;
    private string idAlumno;
    private int idProyecto;
    private string comentario;
}

public class Evaluan{
    private int id;
    private float calificacion_pers;
    private string comentario;
    private int idProyecto;
    private string idProfesor;
}
```

## Principales entidades del proyecto

1. **Alumno**: Representa a un estudiante registrado en el sistema.

2. **Ciclo**: Representa un ciclo formativo con sus características.

3. **Proyecto**: Representa un proyecto realizado por uno o más alumnos.

4. **Profesor**: Representa a un profesor asociado con la evaluación de proyectos.

5. **Realiza**: Relación entre alumnos y proyectos que indica qué alumnos realizan qué proyectos.

6. **Evalua**: Relación entre profesores y proyectos, indicando evaluaciones realizadas.

Además, se utilizan los **Enums** para valores constantes como género, familia profesional, o Tipo de proyecto.

## Vistas

### Login

 En esta ventana introducimos el correo y contraseña del usuario y al pulsar iniciar sesion conectamos a la API
 para comprobar que el existe un usuario con ese correo y esa contraseña y de existir abrimos el siguiente formulario
 
### Principal

 Recibe un objeto profesor desde el Login, del cual utilizamos sus datos para comprobar si es o no admin, 
 que tendra acceso a mas funcionalidades que uno que no lo es.

 Encontramos un menu superior con diferentes botones que se desplegaran al pulsarlos mostrandonos las opciones disponibles
 o en el ultimo caso cerrando la ventana y abriendo de nuevo el Login.

 En los botones ciclos, alumnos, proyectos y profesores solo se mostrara la opcion Ver*, que nos cargara el listview que tenemos debajo y si somos un usuario admin 
 tambien nos hara visibles el resto de opciones(añadir, modificar, borrar) que utilizan la API (al igual que la funcionque carga la tabla) para acceder a la BD
 y consultar los datos oportunos, modificar o borrar registros y añadir nuevos registros.

 En el caso de proyectos tambien tendremos una opcion ver proyecto, a la que tambien podremos acceder haciendo doble click sobre un proyecto que nos abrira 
 una nueva ventana con los datos del proyecto seleccionado.

 Las opciones de añadir nos abriran un Formulario Add* en el que podremos introducir los datos del nuevo registro. 

 Las opciones de modificar nos abriran un Formulario Mod* en el que podremos modificar los datos del registro seleccionado. 

 Las opciones de borrar nos pediran confirmacion para borrar el registro seleccionado y en caso afirmativo lo borrara de la BD. 

 Los botones de subir y descargar ficheros nos permiten subir y descargar ficheros de un directorio predefinido.

### Add*
 
 En este formulario introducimos los datos del nuevo registro que queremos añadir a la BD y al pulsar el boton añadir se conecta a la API
 y añade el nuevo registro a la BD.

### Mod*
    
 En este formulario introducimos los datos del registro que queremos modificar y al pulsar el boton modificar se conecta a la API
 y modifica el registro seleccionado en la BD.

### Ver Proyecto

 En este formulario se nos muestran los datos del proyecto seleccionado en la tabla de proyectos de la ventana principal y nos permite
 ver los datos del proyecto seleccionado.
