# 🔥Documentación de la Interfaz - ProjectStore🔥

## Realizado por el Equipo 1🏅
- Cristian👨‍💻
- Raúl👨‍💻
- Ethan👨‍💻
- Miguel👨‍💻
- Leila👩‍💻

## Tabla de contenidos📝

1. [Introducción](#introducción)
2. [Configuración](#configuración)
3. [Metodos principales](#Metodos principales)
4. [Estructura de ProjectStore](#estructura-de-projectstore)
5. [Modelos (Entities)](#modelos-entities)
6. [Vistas](#Vistas)
7. 
8. [Conclusión](#conclusión)

## Introducción🚀

Esta interfaz utiliza la API para gestionar los registros de la base de datos Proyectos del I.E.S. Miguel Herrero, con funcionalidades para ver los registros  sobre alumnos, profesores y proyectos realizados, 
añadir nuevos, eliminar elementos, modificar los existentes y ver los datos de los proyectos guardados.


## Configuración⚙️

En la carpeta configuracion encontramos el fichero 'APIConnection.cs' en el cual se recogen las implementaciones de los metodos recogidos en la API, 
utilizando HttpClient para conectarnos mediante internet a la APi y utilizar dichos metodos.

### Metodos principales🍃

# Metodos para recoger una entidad concreta

  GetAlumnoById(string id)
  GetProfesorById(string id)
  GetProyectoById(int id)
  GetCicloById(string id)


# Metodos para recoger todos los registros de cada tabla

  GetAllAlumnos()
  GetAllProfesores()
  GetAllCiclos()
  GetAllProyectos()
  GetRealizan()
  GetEvaluan()

# Metodos para insertar registros

  PostAlumno(Alumno alumno)
  PostProfesor(Profesor profesor)
  PostProyecto(Proyecto proyecto)
  PostEntity<T>(string url, T entidad) -- (generico)

# Metodos de modificacion de registros

  UpdateAlumno(Alumno alumno)
  UpdateProfesor(Profesor profesor)
  UpdateProyecto(Proyecto proyecto)
  UpdateEntity<T>(string url, T entidad) -- (generico)

# Metodo de comprobacion de usuario para el Loggin

  GetProfesorByCredentials(string correo, string password) -- recoge si existe en la base de datos un profesor con esos datos

# Metodos de subida y descarga de ficheros

  Download(int id_proyecto, string etapa_proyecto)
  Upload(int id_proyecto, string rutaFichero)

# Mmetodos de eliminacion de registros concretos

  DeleteProyecto(int id)
  DeleteProfesor(string id)
  DeleteAlumno(string id)

## Estructura de ProjectStore🏗️

El proyecto sigue una estructura organizada en paquetes separando las vistas de la interfaz de las entidades, el acceso a la API
y las APIUtilities

## Modelos (Entities)📚

public enum Genero{ M, F, NB }

public enum Familia{ ADG, FME, IFC, TMA }

public enum Tipo{ Final, Intermodular }

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

### Principales entidades del proyecto

1. **Alumno**: Representa a un estudiante registrado en el sistema.
2. **Ciclo**: Representa un ciclo formativo con sus características.
3. **Proyecto**: Representa un proyecto realizado por uno o más alumnos.
4. **Profesor**: Representa a un profesor asociado con la evaluación de proyectos.
5. **Realiza**: Relación entre alumnos y proyectos que indica qué alumnos realizan qué proyectos.
6. **Evalua**: Relación entre profesores y proyectos, indicando evaluaciones realizadas.

Además, se utilizan los **Enums** para valores constantes como género, familia profesional, o Tipo de proyecto.


```
# Conclusión🚩

En ProjectStore hemos implementado varias funcionalidades para la gestión de ficheros y la manipulación de recursos en una aplicación Spring Boot. A través de la creación de controladores y servicios, hemos logrado estructurar y desarrollar una API que nos permite manejar todos los datos 
de los proyectos de IES MIGUEL HERRERO, y como siempre hay margen de mejora pero estaremos encantados de traerles nuevas mejoras
contacten con nosotros para continuar ayudandoles. Muchas gracias😄🔥.
