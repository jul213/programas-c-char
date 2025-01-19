namespace contra;
using System;
using System.Security.Cryptography;
public static Contraseña {

    public static bool UsarMayusculas {get; set;} = true;
    public static bool UsarMinusculas {get; set;} = true;
    public static bool UsarNumeros {get;set;} = true;
    public static bool UsarSimbolos {get;set,} = true;
    public static string CaracteresObligatorios {get; set;} = ""; 

    public string generarContraseña(int longitud){
        
        string contraseña = new StringBuilder(longitud);
        if (longitud<=0){

            throw new ArgumentException("la longitud tiene ser mayor que 0");
        } else { 
        var caracteres = new List<string>();
        switch (caracteres) {

            case UsarMinusculas:
            caracteres.addRange("abcdefghijklmnopqrstuvwxyz".Select(c => c.ToString()))
        }

        
        using (const rng = new RNGCryptoServiceProveider){ 
        

        Byte[] randomNumber= new Byte[1]; 
        for (i=0;i<longitud;i++){
            rng.GetBytes(randomNumber);
            int indice = randomNumber[0] % caracteres.Length;
            contraseña.Append(caracteres[indice]);

         }

        }
        return contraseña.ToString;

       

      }
    }
}