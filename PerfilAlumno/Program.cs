using PerfilAlumno.App;
using System;

namespace PerfilAlumno
{
    /// <summary>
    /// Clase principal que ejecuta la aplicación de perfil de alumno.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Método principal que inicia la aplicación.
        /// Crea un objeto Alumno, llama al método para ingresar datos y muestra la información del alumno.
        /// </summary>
        /// <param name="args">Argumentos de la línea de comandos (no se utilizan).</param>
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno(); // Crea una instancia de la clase Alumno
            alumno.App(); // Llama al método App para ingresar datos del alumno

            MostrarInformacionAlumno(alumno); // Muestra la información del alumno
        }

        /// <summary>
        /// Muestra la información del alumno en la consola.
        /// Obtiene la información del alumno utilizando el método MostrarInformacion y la imprime.
        /// </summary>
        /// <param name="alumno">Instancia de la clase Alumno cuyos datos se mostrarán.</param>
        static void MostrarInformacionAlumno(Alumno alumno)
        {
            // Obtener la información del alumno
            var (nombre, matricula, carrera, promedio) = alumno.MostrarInformacion();

            // Imprimir la información en consola
            Console.WriteLine("\nInformación del alumno:");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Matrícula: {matricula}");
            Console.WriteLine($"Carrera: {carrera}");
            Console.WriteLine($"Promedio: {promedio}");
        }
    }
}
