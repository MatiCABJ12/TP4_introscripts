using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1_ValidacionDeIngreso : MonoBehaviour
{
    public int num1;
    
    // Start is called before the first frame update
    void Start()
    {
        if(num1 > 1899 && num1 < 2028){
            Debug.Log("Gracias");
        }else{
            Debug.Log("Ano no valido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
