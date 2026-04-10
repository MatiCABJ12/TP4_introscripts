using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej0_PositivoONegativo : MonoBehaviour
{
    public int num1;
    
    // Start is called before the first frame update
    void Start()
    {
        if(num1 > 0){
            Debug.Log("El numero es positivo");
        }else if(num1 < 0){
            Debug.Log("El numero es negativo");
        }else{
            Debug.Log("El numnero es cero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
