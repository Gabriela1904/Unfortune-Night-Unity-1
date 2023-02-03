using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludPersonaje : MonoBehaviour

{

    public int vidaSalud = 100;
    public int dañoProyectil = 30;

    // Start is called before the first frame update
    void Start()
    {

        comprobarSaludRestante();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void comprobarSaludRestante()
    {

        int saludRestante = vidaSalud - dañoProyectil;
        Debug.Log("La salud restante es: " + saludRestante);



    }

}
