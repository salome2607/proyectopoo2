using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.TopDownEngine;
using TMPro;
using MoreMountains.Tools;

public class ContadorMonedas : MonoBehaviour
{

     public int monedasIniciales = 0; // Monedas iniciales
    public TMP_Text textoContador; // Texto para mostrar el contador en la interfaz de usuario

    private int monedasActuales;

    private void Start()
    {
        monedasActuales = monedasIniciales;
        ActualizarTextoContador();
    }

    // Método para sumar monedas
    public void SumarMonedas(int cantidad)
    {
        monedasActuales += cantidad;
        ActualizarTextoContador();
         Debug.Log("Monedas sumadas en ContadorMonedas: " + cantidad);
    }

    // Método para actualizar el texto del contador en la interfaz de usuario
    private void ActualizarTextoContador()
    {
        if (textoContador != null)
        {
            textoContador.text = "Monedas: " + monedasActuales.ToString();
        }
    }
}
