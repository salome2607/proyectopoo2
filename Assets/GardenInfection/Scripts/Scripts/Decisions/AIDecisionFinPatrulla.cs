using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using MoreMountains.TopDownEngine;
using UnityEngine;

public class AIDecisionFinPatrulla : AIDecision
{
    public Ruta ruta;

    private int enemigosQueLlegaronAlFinal = 0;

    public override void Initialization(){
        ruta = GetComponent<Ruta>();
        if(ruta==null){
            throw new Exception("La ruta no se asigno como componente del Character");
        }
    }

    public override bool Decide(){
        if(ruta.FinRuta())
        {
            GameManager.Instance.LoseLife();  
            enemigosQueLlegaronAlFinal++;
        }
        return ruta.FinRuta();
    }

public void OleadaCompleta()
    {
        // Verificar si ningún enemigo llegó al final de la ruta durante esta oleada
        if (enemigosQueLlegaronAlFinal == 0)
        {
            // No se perdió ninguna vida, puedes mostrar la escena de "Gano"
            MMSceneLoadingManager.LoadScene("Gano");
        }

        // Reiniciar el contador para la próxima oleada
        enemigosQueLlegaronAlFinal = 0;
    }
   
}
