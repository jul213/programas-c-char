using System;
using System.Collections.Generic;
namespace notas;


public class HelloWorld
{
    
    private List<double> lista = new List<double>();
    public void addgrade(){
        
        Console.Write("ingrese una nota de 0-100 para el sistema");
        double gradeInput;
        
        while (!double.TryParse(Console.ReadLine(), out gradeInput) || gradeInput < 0 ){
            
            Console.WriteLine("nota invalida recuerde que es de 0-100");
            Console.Write("ingrese una nota de 0-100 para el sistema: ");
        }
        
        lista.Add(gradeInput);
        Console.WriteLine("nota añadida exitosamente");
    }
    
    public void deleteGrade(int index){
        
        if (index >= 0 && index < lista.Count){
            
            lista.RemoveAt(index);
            Console.WriteLine("la nota a sido eliminada");
        }
        
        Console.Write("indice incorrecto");
    }
    
    
    public double calculateGrade(){
        
        if (lista.Count > 0){
            
            double total = 0;
            
            foreach(double elemento in lista){
                
                total += elemento;
            }
            return total / lista.Count;
        } else{
            
            Console.WriteLine("no hay elementos para calcular el promedio");
            return 0;
        }
        
         
    }
    
    public bool checkGrade(){
        
        double average = calculateGrade();
        if (average > 70){
            Console.WriteLine("felicidades a aprobado satisfactoriamente");
            return true;
        } else{
            Console.WriteLine("lo siento no a pasado");
            return false;
        }
    }
        
}