using System; // Importar el espacio de nombres necesario para la consola
// Tarea 03: Registro de Estudiantes

public class RegistroEstudiante // Clase para almacenar la información del estudiante
{
    public int Id { get; set; }// Propiedad para el ID del estudiante
    // Propiedades para almacenar la información del estudiante
    public required string Nombre { get; set; }// Propiedad para el nombre del estudiante
    public required string Apellido { get; set; }// Propiedad para el apellido del estudiante
    public required string FechaNacimiento { get; set; }// Propiedad para la fecha de nacimiento del estudiante
    public int Edad { get; set; }// Propiedad para la edad del estudiante
    public required string Carrera { get; set; }// Propiedad para la carrera del estudiante
    public required string Universidad { get; set; }// Propiedad para la universidad del estudiante
    public required string CorreoElectronico { get; set; }// Propiedad para el correo electrónico del estudiante
    public string[] Telefono { get; set; } = new string[3];// Propiedad para los teléfonos del estudiante
    public required string Direccion { get; set; }// Propiedad para la dirección del estudiante
    public required string Estado { get; set; }// Propiedad para el estado del estudiante            
}

class Program // Clase principal para ejecutar el programa  
{
    public static void Main(string[] args) // Método principal que se ejecuta al iniciar el programa
    {
        RegistroEstudiante estudiante = new RegistroEstudiante // Crear una instancia de RegistroEstudiante y asignar valores a sus propiedades     
        {
            // Asignar valores a las propiedades del estudiante
            Id = 1,
            Nombre = "Cesar",
            Apellido = "Castro",
            FechaNacimiento = "1989-05-23",
            Edad = 36,
            Carrera = "Ingeniería de Tecnologia de la Información",
            Universidad = "Universidad Estatal Amazónica",
            CorreoElectronico = "cesar.castro@uea.edu.ec",
            Telefono = new string[] { "0991234567", "022345678", "027654321" },// Asignar un arreglo de números de teléfono
            Direccion = "Av. Universitaria, Quito",
            Estado = "Activo"
        };

        // Mostrar información del estudiante
        Console.WriteLine("Información del Estudiante:");
        Console.WriteLine("=====================================");
        Console.WriteLine($"ID: {estudiante.Id}");
        Console.WriteLine($"Nombre: {estudiante.Nombre}");
        Console.WriteLine($"Apellido: {estudiante.Apellido}");
        Console.WriteLine($"Fecha de Nacimiento: {estudiante.FechaNacimiento}");
        Console.WriteLine($"Edad: {estudiante.Edad}");
        Console.WriteLine($"Carrera: {estudiante.Carrera}");
        Console.WriteLine($"Universidad: {estudiante.Universidad}");
        Console.WriteLine($"Correo Electrónico: {estudiante.CorreoElectronico}");
        Console.WriteLine($"Dirección: {estudiante.Direccion}");
        Console.WriteLine($"Estado: {estudiante.Estado}");
        Console.WriteLine("=====================================");
        // Validar y mostrar los números de teléfono

        foreach (var telefono in estudiante.Telefono) // Iterar sobre cada número de teléfono en el arreglo Telefono
        {
            if (string.IsNullOrEmpty(telefono)) // Verificar si el número de teléfono es nulo o vacío
            {
                continue; // Saltar números de teléfono vacíos
            }
            Console.WriteLine($"Teléfono: {telefono}");// Mostrar el número de teléfono
        }
    }
}