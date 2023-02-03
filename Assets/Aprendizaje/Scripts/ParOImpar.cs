using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParOImpar : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Text componenteTexto = null;

    private string dato1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IngresarDato1(string ingreso)
    {

        dato1 = ingreso;
        Debug.Log(dato1);

    }

    public void AlgoritmoEjercicio()
    {
        int entero = int.Parse(dato1);
        int resto = entero % 2;

        string resultado;

        if (resto == 0)
        {
            resultado = ("Es par");
        }
        else
        {
            resultado = ("Es impar"); 
        }

        componenteTexto.text = resultado;

    }

}

