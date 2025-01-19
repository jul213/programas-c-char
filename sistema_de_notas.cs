using System;
using System.Collections.Generic;
using notas;

    
public class program{
    
    public static void Main(string[] args)
    {
        HelloWorld notas = new HelloWorld();
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