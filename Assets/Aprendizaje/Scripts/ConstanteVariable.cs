using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstanteVariable : MonoBehaviour
{
    //La cantidad de salud
    public int saludPersonaje = 100;
    //El deterioro de salud
    public int deterioroSalud = 10;

    public string nombrePersonaje = "Bonnie";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Salud Inicial: " + saludPersonaje);
        
        Debug.Log("Daño que recibe: " + deterioroSalud);
        Debug.Log(saludPersonaje - deterioroSalud);
        Debug.Log("el nombre del personaje es: " + nombrePersonaje);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
