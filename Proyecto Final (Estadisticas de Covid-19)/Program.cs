using System;

namespace Estadisticas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            Salas salas = new Salas();
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Estadisticas de Covid-19");
                Console.WriteLine("====================================");
                Console.WriteLine("1 - Tipos de Salas");
                Console.WriteLine("2 - Ingreso de Pacientes");
                Console.WriteLine("3 - Pacientes recuperados");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        salas.listarPacientes();
                        break;
                    case "2":
                        salas.ingresoDePruebas();
                        break;
                    case "3":
                        salas.salidaDePacientes();
                        break;                                 
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}