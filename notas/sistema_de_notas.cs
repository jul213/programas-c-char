using System;
using notas;

    
public class Program{
    
    public static void Main(string[] args)
    {
        Notas notas = new Notas();
        int numGrades;
        Console.WriteLine("cuantos notas quiere que tenga el sistema?: ");
        
        while (!int.TryParse(Console.ReadLine(),  out numGrades) || numGrades <= 0){
            
            Console.WriteLine("numero invalido vuelva a intentarlo");
            Console.Write("ingrese la cantidad de notas: ");
            
        }
        
        for (int i=0; i < numGrades; i++){
            notas.addgrade();
        }
    }
    
    
    }