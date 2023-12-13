using System;
// Libreria para usar las listas
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;



// Definicion de la clase para el ejercicio 3

class Estudiante
{
    public string Nombre;
    public string Apellido;
    public int Edad;
    public double Calificacion;

    // Constructor vacío
    public Estudiante() { }

    // Constructor con parámetros
    public Estudiante(string nombre, string apellido, int edad, double calificacion)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Calificacion = calificacion;
    }

    // Metodo para la pregunta 4

    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Apellido: " + Apellido);
        Console.WriteLine("Edad: " + Edad);
        Console.WriteLine("Calificación: " + Calificacion);
    }
}


// Definicion de la clase que hereda de estudiante para la pregunta 5

class EstudianteGraduado : Estudiante
{
    public string Titulo;

    public EstudianteGraduado(string nombre, string apellido, int edad, double calificacion, string titulo)
        : base(nombre, apellido, edad, calificacion)
    {
        Titulo = titulo;
    }
}


// Definicion para el control de entradas de nummeros
public class Controladores
{
    public double NumerosDecimales(string text)
    {
        bool justNumber;
        double number;
        do
        {
            Console.Write(text);
            // Comprobamos si el salario ingresado es un numero ya sea entero o decimal
            justNumber = double.TryParse(Console.ReadLine(), out number);

            if (!justNumber)
            {
                Console.WriteLine("Error: Por favor, ingrese un valor entero para el salario.");
            }

        } while (!justNumber);
        return number;
    }

    public int NumeroEntero(string text)
    {
        int number = 0;
        bool esNumero;
        do
        {
            Console.Write(text);
            esNumero = int.TryParse(Console.ReadLine(), out number);

            if (!esNumero)
            {
                Console.WriteLine("Error: Por favor, ingrese una opcion valida....");

                // Esperamos a que el usuario presione una tecla
                Console.ReadKey();

                // Borrar la consola
                Console.Clear();
            }

        } while (!esNumero);
        return number;
    }
}

class Program
{
    static void Main()
    {
        // Bucle para mostrar las opciones
        int opcion = 0;

        // Instanciamos el controlador para comprobar numeros decimales
        Controladores controlador = new Controladores();


        do
        {
            Console.WriteLine("********Bienvenidos ***************");
            Console.WriteLine("1.- Ejercicio 1: Variables y Operadores en C#");
            Console.WriteLine("2.- Ejercicio 2: Estructuras de Control en C#");
            Console.WriteLine("3.- Ejercicio 3: Programación Orientada a Objetos - Clases y Objetos");
            Console.WriteLine("4.- Ejercicio 4: Programación Orientada a Objetos - Métodos");
            Console.WriteLine("5.- Ejercicio 5: Programación Orientada a Objetos - Herencia");
            Console.WriteLine("6.- Salir");
            // Nos aseguramos de que sea un numero entero
            opcion = controlador.NumeroEntero("Ingrese la opcion que desea: ");
            // Borrar la consola
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("**********Ejercicio 1: Variables y Operadores en C#**************");
                    int x = 5;
                    int y = 10;
                    int resultado = x + y;
                    Console.WriteLine("El resultado es: " + resultado);
                    Console.WriteLine("Pulse cualquier tecla para regresar al menu principal");
                    // Esperamos a que el usuario presione una tecla
                    Console.ReadKey();
                    // Borrar la consola
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("**********Ejercicio 2: Estructuras de Control en C#**************");
                    int edad = 20; // Inicialización de la edad
                    if (edad >= 18)
                    {
                        Console.WriteLine("La persona es mayor de edad.");
                    }
                    else
                    {
                        Console.WriteLine("La persona no es mayor de edad.");
                    }
                    Console.WriteLine("Pulse cualquier tecla para regresar al menu principal");
                    // Esperamos a que el usuario presione una tecla
                    Console.ReadKey();
                    // Borrar la consola
                    Console.Clear();
                    break;
                case 3:
                    // Mostrar lista de empleados
                    Console.WriteLine("**************** Ejercicio 3: Programación Orientada a Objetos - Clases y Objetos ******************");
                    Estudiante estudiante1 = new Estudiante("Carlos", "Ipiales", 24, 8.5);
                    Console.WriteLine("Nombre: " + estudiante1.Nombre);
                    Console.WriteLine("Nombre: " + estudiante1.Apellido);
                    Console.WriteLine("Edad: " + estudiante1.Edad);
                    Console.WriteLine("Calificación: " + estudiante1.Calificacion);
                    Console.WriteLine("Pulse cualquier tecla para regresar al menu principal");
                    // Esperamos a que el usuario presione una tecla
                    Console.ReadKey();
                    // Borrar la consola
                    Console.Clear();
                    break;
                case 4:
                    // Mostrar lista de empleados
                    Console.WriteLine("**************** Ejercicio 4: Programación Orientada a Objetos - Métodos ******************");
                    Estudiante estudiante2 = new Estudiante("Joao", "Ipiales", 24, 15);
                    estudiante2.MostrarInformacion();
                    Console.WriteLine("Pulse cualquier tecla para regresar al menu principal");
                    // Esperamos a que el usuario presione una tecla
                    Console.ReadKey();
                    // Borrar la consola
                    Console.Clear();
                    break;
                case 5:
                    // Mostrar lista de empleados
                    Console.WriteLine("**************** Ejercicio 4: Programación Orientada a Objetos - Métodos ******************");
                    EstudianteGraduado estudiante3 = new EstudianteGraduado("Joao", "Ipiales", 24, 15, "Ingeniería de Software");
                    estudiante3.MostrarInformacion();
                    Console.WriteLine("Título: " + estudiante3.Titulo);
                    Console.WriteLine("Pulse cualquier tecla para regresar al menu principal");
                    // Esperamos a que el usuario presione una tecla
                    Console.ReadKey();
                    // Borrar la consola
                    Console.Clear();
                    break;
                case 6:
                    Console.WriteLine("Gracias por preferirnos :)");
                    Console.WriteLine("Pulse cualquier tecla para salir");
                    // Esperamos a que el usuario presione una tecla
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Gracias por preferirnos :)");
                    Console.WriteLine("Pulse cualquier tecla para salir");
                    // Esperamos a que el usuario presione una tecla
                    Console.ReadKey();
                    break;
            }
        } while (opcion != 6);

    }
}


