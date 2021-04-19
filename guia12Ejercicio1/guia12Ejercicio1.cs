using System;

class Program {
  struct programa {
    public string Universidad;
    public string Carrera;
  }
  
  struct Estudiante {
    public string nombre;
    public int edad;
    public programa Estudios;
  }
  
  static void Main(string[] args){
    int numreg;
    Console.WriteLine("Cuantos registros quiere ingresar");
    numreg = int.Parse(Console.ReadLine());

    Estudiante[] students = new Estudiante[numreg];
    //Entrada de datos
    for(int cont = 0; cont < numreg; cont++){
      Console.Write("Ingrese Nombre: ");
      students[cont].nombre = Console.ReadLine();
      Console.Write("Edad: ");
      students[cont].edad = int.Parse(Console.ReadLine());
      Console.Write("Carrera: ");
      //Accedemos a miembros de otra estructura
      students[cont].Estudios.Carrera = Console.ReadLine();
      Console.Write("Universidad: ");
      students[cont].Estudios.Universidad = Console.ReadLine();
      Console.Clear();
    }
    
    Console.WriteLine("Mostrando datos: ");

    for(int cont = 0; cont < numreg; cont++){
      Console.WriteLine("Estudiante: " + students[cont].nombre);
      Console.WriteLine("Edad: " + students[cont].edad);
      Console.WriteLine("Carrera: " + students[cont].Estudios.Carrera);
      Console.WriteLine("Universidad: " + students[cont].Estudios.Universidad);
      Console.WriteLine();
    }
  }
}