using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoEscena : MonoBehaviour
{

    public GameObject personajeEncontrado;
    public GameObject nombreEncontrado;
    public GameObject obejtoEncontrado;

    // Start is called before the first frame update
    void Start()
    {
        GameObject objetoEncontrado = GameObject.FindObjectOfType<SpriteRenderer>().gameObject;
        GameObject personajeEncontrado = GameObject.FindWithTag("Personaje");
        GameObject nombreEncontrado = GameObject.Find("Square");

        Debug.Log(objetoEncontrado);
        Debug.Log(personajeEncontrado);
        Debug.Log(nombreEncontrado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
