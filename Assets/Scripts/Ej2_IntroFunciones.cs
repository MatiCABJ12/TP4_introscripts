using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2_IntroFunciones : MonoBehaviour
{
    public string Contrasena;
    
    // crear la funcion MensajeAccesoDenegado que se escribe en consola eso
    // e implementar las funcionalidades que permitan ingresar por inspector   
    // una cadena de caracteres y ejecutar la funcion MensajeBienvenida si 
    // el string coincide con "TIC2026", si no coincide, ejecutar MensajeAccesoDenegado
    
    // Start is called before the first frame update
    void Start()
    {
        if(Contrasena == "TIC2026"){
            MensajeBienvenida();
        }else{
            MensajeAccesoDenegado();
        }
    }

    void MensajeBienvenida(){
        Debug.Log("Le damos la bienvenida");
    }
    void MensajeAccesoDenegado(){
        Debug.Log("eso");
    }
}
