using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulacro : MonoBehaviour
{
    // Start is called before the first frame update

    public string nombreAlumno;
    public int año;
    public string orientacion;

    void Start()
    {
        if (nombreAlumno == "")
        {
            Debug.Log("ERROR");
            return;
        }
       else if (año > 5){

            Debug.Log("ERROR");
            return;
        }
       
        else if (orientacion != "T"|| orientacion != "G"|| orientacion != "H" || orientacion != "M"|| orientacion != "D")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
            return;
        }
       else if (año < 3)

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
