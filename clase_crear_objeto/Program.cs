using System;

public class Persona
  {

    public string Nombre;
    public int Edad;

    public void Saludar()

    { 
    Console.WriteLine($"Hola, Soy {Nombre} y Tengo {Edad} años.");
    }

    }

class Program
{

    static void Main()
    {
        Persona persona1 = new Persona();
        persona1.Nombre = "Carlos";
        persona1.Edad = 30;
        persona1.Saludar();
    
    }

}
