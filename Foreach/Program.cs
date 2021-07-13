using System;
using System.Collections.Genereci;

namespace listados
{

    class Program
    {
        static void Main(string[] args)
        {
            list<string> nombres = new List<string>();
            nombres.Add("Juan");
            nombres.Add("Pedro");
            nombres.Add("Maria");

            foreach (var nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            list<int> numeros = new list<int> ();
            numeros.Add(10);
            numeros.Add(1);
            numeros.Add(5);

            foreach (var n in numeros)
            {
                Console.WriteLine(n);   
            }

            List<Alumno> alumnos = new List<Alumno>();
            Alumno a = new Alumno(1, "Pedro");
            Alumno b = new Alumno(1, "Maria");
            Alumno c = new Alumno(1, "Juan");

            alumnos.Add(a);
            alumnos.Add(b);
            alumnos.Add(c);

            foreach (var alumno in alumnos)
            {
                 Console.WriteLine(alumnos.Id);  
            }  
        }
    }
}