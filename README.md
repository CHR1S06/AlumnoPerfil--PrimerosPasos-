# AlumnoPerfil--PrimerosPasos-

# Descripción del Problema

Se requiere desarrollar una aplicación que gestione la información de estudiantes. Para ello, se debe crear una clase `Alumno` que contenga las propiedades necesarias para almacenar los datos relevantes del estudiante. Las propiedades a incluir son:

- **Nombre**: Cadena de texto que representa el nombre del alumno.
- **Matrícula**: Cadena de texto que identifica al alumno en la institución.
- **Carrera**: Cadena de texto que indica la carrera que estudia el alumno.
- **Calificaciones**: Una lista de enteros que contendrá las calificaciones obtenidas por el alumno.

Además, se deben implementar dos métodos dentro de la clase `Alumno`:

1. **CalcularPromedio**: Este método debe calcular y devolver el promedio de las calificaciones del alumno.
2. **MostrarInformacion**: Este método imprimirá en la consola el nombre, la matrícula, la carrera y el promedio del alumno.

El objetivo es crear instancias de la clase `Alumno`, asignar valores a sus propiedades y mostrar la información en la consola.

## Enfoque para Resolver el Problema

Para abordar este problema, se implementó la clase `Alumno` con las propiedades y métodos requeridos. A continuación se detallan los pasos tomados en el código de C#:

1. **Definición de la Clase**: Se creó la clase `Alumno` con propiedades para el nombre, matrícula, carrera y calificaciones.
   
2. **Uso de Listas**: Se utilizó `List<int>` para manejar las calificaciones, permitiendo que el número de calificaciones sea variable y fácil de gestionar.

3. **Cálculo del Promedio**: El método `CalcularPromedio` suma todas las calificaciones en la lista y divide el total entre la cantidad de calificaciones para obtener el promedio.

4. **Mostrar Información**: En el método `MostrarInformacion`, se utiliza la función `Console.WriteLine` para imprimir todos los detalles relevantes del alumno, incluyendo su promedio.

5. **Instancias de la Clase**: Finalmente, se crearon instancias de la clase `Alumno`, se asignaron valores a las propiedades y se llamó al método `MostrarInformacion` para visualizar la información en la consola.
