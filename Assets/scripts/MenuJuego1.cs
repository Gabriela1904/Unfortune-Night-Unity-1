using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJuego1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void CargarNivel(string patilla)
    {

        SceneManager.LoadScene(patilla);

    }

    public void Salir()
    {
        Application.Quit();
    }
}
