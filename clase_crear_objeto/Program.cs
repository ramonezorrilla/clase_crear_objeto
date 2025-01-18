using System;

public class Persona
  {

    public string Nombre;
    public int Edad;

    //CONSTRUCTOR
    public Persona(string nombre, int edad)

    { 
        Nombre = nombre;
        Edad = edad;
    
    
    }

    //METODO
    public void Saludar()

    { 
    Console.WriteLine($"Hola, Soy {Nombre} y Tengo {Edad} años.");
    }

    }

class Program
{

    static void Main()
    {
        Persona persona1 = new Persona("Maria",25);
       // persona1.Nombre = "Carlos";
      //  persona1.Edad = 30;
        persona1.Saludar();
    
    }

}
