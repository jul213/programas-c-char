using System.Linq;
using System.Collections.Generic;
using System;

class Historial {

  public static historial(var contraseña){

    private static List<string> historial = new List<string>;

    public static void AgregarContraseña(string contraseña){

      historial.Add(contraseña);
    }

    public static List<string> ObtenerHistorial(){

      return new List<string>(historial)
    }

    public static void LimpiarHistorial(){

      historial.Clear();
    }

    public static void EliminarContraseña(string contraseña){
      
  }
  }

}
