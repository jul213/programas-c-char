namespace contra;
using System;
using System.Security.Cryptography;
public static Contraseña {

    public static bool UsarMayusculas {get; set;} = true;
    public static bool UsarMinusculas {get; set;} = true;

    public String generarContraseña(int longitud){
        
        String contraseña = new StringBuilder(longitud);
        if (longitud<=0){

            throw new ArgumentException("la longitud tiene ser mayor que 0");
        } else { 
        String[] caracteres = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=", "[", "]", "{", "}", ";", ":", "<", ">", "|", ".", "?"}

        
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