namespace contra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
public static Contraseña {

    public static bool UsarMayusculas {get; set;} = true;
    public static bool UsarMinusculas {get; set;} = true;
    public static bool UsarNumeros {get;set;} = true;
    public static bool UsarSimbolos {get;set,} = true;
    public static string CaracteresObligatorios {get; set;} = ""; 

    public string generarContraseña(int longitud){
        
        if (longitud<=0){

            throw new ArgumentException("la longitud tiene ser mayor que 0");
        } else { 
        var caracteres = new List<string>();
        switch (caracteres) {

            case UsarMinusculas:
            caracteres.addRange("abcdefghijklmnopqrstuvwxyz".Select(c => c.ToString()));
            break;
            
            case UsarMayusculas:
            caracteres.addRange("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Select(c => c.ToString()));
            break;

            case UsarNumeros:
            caracteres.addRange("0123456789".Select(c => ToString()));
            break;

            case UsarSimbolos:
            caracteres.addRange("!@#$%^&*()_-+=[]{}|;:,.<>?".Select(c => ToString()));
            break;
        }
        if (caracteres.Count == 0){
            throw new InvalidOperationException("debe seleccionar al menos un modo de caracteres");
        }


        var contraseña = new stringBuilder(CaracteresObligatorios);
        using (const rng = new RNGCryptoServiceProveider){ 
        

        Byte[] randomNumber= new Byte[1]; 
        while (contraseña.Length < longitud){
            rng.GetBytes(randomNumber);
            int indice = randomNumber[0] % caracteres.Length;
            contraseña.Append(caracteres[indice]);

         }

        }
        return contraseña.ToString;

       

      }
    }
}