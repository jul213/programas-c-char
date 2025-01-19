
public static Contraseña {

    public String generarContraseña(int longitud){
        
        String contraseña = String.Empty;
        String[] caracteres = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=", "[", "]", "{", "}", ";", ":", "<", ">", "|", ".", "?"}

        Random eleccion = new Random();

        for (i=0;i<longitud;i++){
            int indice = eleccion.Next(0,caracteres.Length);
            contraseña += caracteres[indice];

        }
        return contraseña;
    }
}