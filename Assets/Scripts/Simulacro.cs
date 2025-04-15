using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulacro : MonoBehaviour
{
    // Start is called before the first frame update

    public string nombreAlumno;
    public int anio;
    public string orientacion;

    void Start()
    {
        if (nombreAlumno == "")
        {
            Debug.Log("El nombre no puede estar vacío");
            return;
        }
       if (anio < 1 || anio > 5){

            Debug.Log("Año ingresado no válido");
            return;
        }
       
        if (orientacion != "T"|| orientacion != "G"|| orientacion != "H" || orientacion != "M"|| orientacion != "D")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
            return;
        }
       
        if (anio < 3)

        {
            Debug.Log("Error. Aún estás en el ciclo básico");
        }

        else
        {
            Debug.Log("Muchas gracias " + nombreAlumno);
        }
   
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
