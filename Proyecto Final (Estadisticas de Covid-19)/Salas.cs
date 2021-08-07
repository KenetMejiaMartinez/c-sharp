using System;
using System.Collections.Generic;

public class Salas
{

     public List<Paciente> ListadePaciente { get; set; }

    public Salas ()
    {   
        ListadePaciente = new List<Paciente> ();
   
        Paciente a = new Paciente("01", "Sala de Cuidados Leves", 100);
        Paciente b = new Paciente("02", "Sala de Cuidados Intermedios", 170);
        Paciente c = new Paciente("03", "Sala de Cuidados Graves", 210);

        ListadePaciente.Add(a);
        ListadePaciente.Add(b);
        ListadePaciente.Add(c);
    } 
    public void listarPacientes() {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listado de Pacientes");
        Console.WriteLine("=====================");
        Console.WriteLine ("Codido, Descripcion, Existencia");

        foreach (var paciente in ListadePaciente)
        {
            Console.WriteLine(paciente.Codigo + " | " + paciente.Descripcion + " | " + paciente.Existencia );
        }
        
        Console.ReadLine();
    }

    private void movimientoSalas (string codigo, int cantidad, string tipoMovimiento){
        foreach (var paciente in ListadePaciente)
        {
            if (paciente.Codigo == codigo) {
                if (tipoMovimiento == "+"){
                    paciente.Existencia =  paciente.Existencia + cantidad;
                } else {
                    paciente.Existencia = paciente.Existencia - cantidad;
                }       
            }
        }
    }

    public void ingresoDePruebas() {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de pruebas a la Sala");
        Console.WriteLine("=============================");
        Console.WriteLine("Ingrese el codigo de la Sala: "); 
        codigo = Console.ReadLine(); 
        Console.WriteLine("Ingrese la cantidad de Pacientes: ");
        cantidad = Console.ReadLine();

        movimientoSalas(codigo, Int32.Parse(cantidad),"+");
    }

    public void salidaDePacientes (){
        string codigo = "";
        string cantidad ="";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de Pacientes Recuperados");
        Console.WriteLine("=================================");
        Console.WriteLine("Ingrese el codigo de la Sala: "); 
        codigo = Console.ReadLine(); 
        Console.WriteLine("Ingrese la cantidad de Pacientes: ");
        cantidad = Console.ReadLine();

        movimientoSalas(codigo, Int32.Parse(cantidad),"-");
    }

}
