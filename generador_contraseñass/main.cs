using contra;
using System;

public static void main(String []args){
    Console.WriteLine("bienvenido al generador de contraseñas");
    Console.Write("ingresa la longitud de contraseña");
    int longitud = int.Parse(Console.ReadLine());

    String contraseñaGenerada = contra.generarContraseña(longitud);
    Console.WriteLine($"la contraseña generada es: {contraseñaGenerada}");

    Console.ReadKey();
}