using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PerfilAlumno.App
{
    /// <summary>
    /// Representa un alumno con información básica y calificaciones.
    /// </summary>
    public class Alumno
    {
        // Campos privados para almacenar la información del alumno
        private string nombre;
        private string matricula;
        private string carrera;
        private double promedio;
        private List<double> calificacion;

        /// <summary>
        /// Propiedad que representa el nombre del alumno.
        /// Se verifica que no esté vacío ni contenga solo espacios.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nombre = value;  // Asigna el valor a la variable nombre
                }
                else
                {
                    Console.WriteLine("El nombre no puede estar vacío o contener solo espacios en blanco. Intente nuevamente.");
                }
            }
        }

        /// <summary>
        /// Propiedad que representa la matrícula del alumno.
        /// Se verifica que no esté vacío ni contenga solo espacios.
        /// </summary>
        public string Matricula
        {
            get { return matricula; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    matricula = value;  // Asigna el valor a la variable matricula
                }
                else
                {
                    Console.WriteLine("La matrícula no puede estar vacía o contener solo espacios en blanco. Intente nuevamente.");
                }
            }
        }

        /// <summary>
        /// Propiedad que representa la carrera del alumno.
        /// Se verifica que no esté vacío ni contenga solo espacios.
        /// </summary>
        public string Carrera
        {
            get { return carrera; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    carrera = value;  // Asigna el valor a la variable carrera
                }
                else
                {
                    Console.WriteLine("La carrera no puede estar vacía o contener solo espacios en blanco. Intente nuevamente.");
                }
            }
        }

        /// <summary>
        /// Propiedad que representa la lista de calificaciones del alumno.
        /// </summary>
        public List<double> Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }  // Asigna el valor a la variable calificacion
        }

        /// <summary>
        /// Calcula el promedio de las calificaciones del alumno.
        /// Si no hay calificaciones, imprime un mensaje y retorna 0.
        /// </summary>
        /// <returns>El promedio de las calificaciones.</returns>
        public double CalcularPromedio()
        {
            if (calificacion == null || calificacion.Count == 0)
            {
                Console.WriteLine("No hay calificaciones disponibles para calcular el promedio.");
                return 0; // Retorna 0 si no hay calificaciones
            }

            double suma = calificacion.Sum(); // Suma de todas las calificaciones
            promedio = suma / calificacion.Count; // Cálculo del promedio
            return promedio; // Retorna el promedio
        }

        /// <summary>
        /// Muestra la información del alumno, incluyendo nombre, matrícula, carrera y promedio.
        /// </summary>
        /// <returns>Una tupla con el nombre, matrícula, carrera y promedio del alumno.</returns>
        public (string, string, string, double) MostrarInformacion()
        {
            return (nombre, matricula, carrera, promedio);
        }

        /// <summary>
        /// Método principal para la aplicación que solicita información del alumno
        /// y las calificaciones, y luego calcula el promedio.
        /// </summary>
        public void App()
        {
            Console.Write("Digite el nombre del alumno: ");
            Nombre = Console.ReadLine();

            Console.Write("");

            Console.Write("Digite la matrícula del alumno: ");
            Matricula = Console.ReadLine();

            Console.Write("");

            Console.Write("Digite la carrera del alumno: ");
            Carrera = Console.ReadLine();

            Console.Write("");
            Console.Write("Ingrese la cantidad de calificaciones a ingresar: ");
            int capacidad;

            // Validación para que la capacidad sea un número mayor a cero
            while (true)
            {
                try
                {
                    capacidad = Convert.ToInt16(Console.ReadLine());
                    if (capacidad > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese un número válido.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error de entrada: " + ex.Message);
                }
            }

            Calificacion = new List<double>(capacidad);
            double elementos;

            // Ciclo para ingresar las calificaciones
            for (int i = 0; i < capacidad; i++)
            {
                Console.Write($"Introduzca el valor de la materia{i}: ");
                while (true)
                {
                    try
                    {
                        elementos = Convert.ToDouble(Console.ReadLine());
                        if (elementos >= 0)
                        {
                            Calificacion.Add(elementos); // Agrega la calificación a la lista
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un número válido.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error de entrada: " + ex.Message);
                    }
                }
            }

            CalcularPromedio(); // Calcula el promedio de las calificaciones

            Console.Clear(); // Limpia la consola
        }
    }
}
