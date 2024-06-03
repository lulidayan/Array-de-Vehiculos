using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VEHICULOSMANAGER : MonoBehaviour
{

    public Vehiculo VehiculoScript;
    
    // Start is called before the first frame update
    void Start()
    {
        int cantRuedas = VehiculoScript.cantRuedas;
        Debug.Log("Cant ruedas: " + cantRuedas);
        if (cantRuedas < 6) ;

        {
            VehiculoScript.gameObject.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
