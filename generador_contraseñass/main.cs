using contra;
using System;
using historial;
class Program { 
    public static void main(String []args){
        Console.WriteLine("bienvenido al generador de contraseñas");
        Console.Write("ingresa la longitud de contraseña que quieres tener");
        int longitud = int.Parse(Console.ReadLine());

        Contraseña.UsarMayusculas = true;
        Contraseña.UsarMinusculas = true;
        Contraseña.UsarNumeros = true;
        Contraseña.UsarSimbolos = false;
        Contraseña.CaracteresObligatorios = "AB80";

        String contraseñaGenerada = Contraseña.generarContraseña(longitud);
        Console.WriteLine($"la contraseña generada es: {contraseñaGenerada}");

        Historial.AgregarContraseña(contraseñaGenerada);

        Console.WriteLine("historial de contraseñas");
        
        Hisstorial.obtenerHistorial();

        Console.WriteLine("presiona cualquier tecla para salir");
        Console.ReadKey();
    }
}
