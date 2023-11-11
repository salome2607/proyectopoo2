using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.TopDownEngine;
using TMPro;
using MoreMountains.Tools;

public class ContadorMonedas : MonoBehaviour
{

    [SerializeField]
    private TMP_Text contador;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* if(GameManager.Instance.CurrentLives>0)
        {
            contador.SetText(GameManager.Instance.CurrentLives.ToString());
        }
        else
        {
            //MMGameEvent.Trigger("JuegoTerminado");
            MMSceneLoadingManager.LoadScene("Perdio");
        }*/
    }
}
