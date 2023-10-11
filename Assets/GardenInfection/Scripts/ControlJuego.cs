using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class ControlJuego : MonoBehaviour
{
    public void OnJugar()
    {
        Debug.Log("Ir a Jugar");
        MMSceneLoadingManager.LoadScene("Nivel1");
    }

    public void IrAInstrucciones()
    {
        Debug.Log("Ir a instrucciones");
        MMSceneLoadingManager.LoadScene("Instrucciones");
    }

     public void IrAInicio()
    {
        Debug.Log("Ir a inicio");
        MMSceneLoadingManager.LoadScene("Home");
    }

    public void IrACreditos()
    {
        Debug.Log("Ir a creditos");
        MMSceneLoadingManager.LoadScene("Creditos");
    }
}
