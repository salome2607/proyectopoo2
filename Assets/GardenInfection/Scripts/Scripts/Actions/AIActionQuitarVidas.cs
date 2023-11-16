using System;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using UnityEngine;

public class AIActionQuitarVidas:AIAction{
    
    [SerializeField]
    private int vidasADescontar;

    [SerializeField]
    private int cantidadDeMonedas = 5;

    private ContadorMonedas contadorMonedas;

    public override void Initialization()
    {
        contadorMonedas = FindObjectOfType<ContadorMonedas>();
        
    }

    public override void PerformAction()
    {
        Debug.Log("PerformAction en AIActionQuitarVidas");
        
        if (contadorMonedas != null)
        {
            // Llama al método SumarMonedas con la cantidad deseada
            contadorMonedas.SumarMonedas(cantidadDeMonedas);
            Debug.Log("Monedas sumadas: " + cantidadDeMonedas);
        }


        GameManager.Instance.LoseLife();
    }
}