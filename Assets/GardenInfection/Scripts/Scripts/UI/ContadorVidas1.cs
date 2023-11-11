using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using TMPro;
using UnityEngine;
using MoreMountains.Tools;

public class ContadorVidas1 : MonoBehaviour
{
    [SerializeField]
    private TMP_Text contador;
    /*[SerializeField]
    private int vidas;*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.CurrentLives>0)
        {
            contador.SetText(GameManager.Instance.CurrentLives.ToString());
        }
        else
        {
            //MMGameEvent.Trigger("JuegoTerminado");
            MMSceneLoadingManager.LoadScene("Perdio");
        }
    }
}

