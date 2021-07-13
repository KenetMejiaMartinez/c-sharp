using system;

namespace funciones
{
    class Program
    {

        static void Main(string [] args)
        {
            Alumnos a = new Alumno(1, "Juan", "Perez");
            Alumnos b = new Alumno(2, "Maria", "Martinez");

            a.inactivarAlumno();

            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());

            a.activarAlumno();

            Console.WriteLine (" ");

            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());
        }
    }
}