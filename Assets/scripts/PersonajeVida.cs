using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PersonajeVida : VidaBase
{
    // Start is called before the first frame update
    public bool PuedeSerCurado => Salud < saludMax;


    protected override void Start()
    {
        base.Start();
        ActualizarBarraVida(Salud, saludMax);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            RecibirDaņo(10);

        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            RestaurarSalud(10);
        }
    }


    // Update is called once per frame
    

    public void RestaurarSalud(float cantidad)
    {
        if (PuedeSerCurado)
        {
            Salud += cantidad;
            if (Salud > saludMax)
            {
                Salud 
                      = cantidad;
            }

            ActualizarBarraVida(Salud, saludMax);
        }

    }     
    protected override void ActualizarBarraVida(float vidaActual, float vidaMax)
    {

        UIManager.Instance.ActualizarVidaPersonaje(vidaActual, vidaMax);

    }
    

}
