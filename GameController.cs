using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GameController : MonoBehaviour
{
    public ParticleSystem polvo;
    public SteamVR_Action_Boolean action;
    public GameObject mataFuego;
    public GameObject palanca;
    private bool pressingTrigger = false;
    bool isAttached = false;
    bool pin = true;
    void Start()
    {
        polvo.gameObject.SetActive(false);
    }

    void Update()
    {
       /*if (action.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            Debug.Log("funca");
            pressingTrigger = true;
        }
        else
        {
            pressingTrigger = false;
        }*/
        if (pin)
        {
            return;
        }

        if ((Input.GetKey(KeyCode.Space) && isAttached == true) || action.GetState(SteamVR_Input_Sources.LeftHand) && isAttached)
        {
            polvo.gameObject.SetActive(true);
        }
        else
        {
            polvo.gameObject.SetActive(false);
        }
    }
   
    public void SetAttached (bool b)
    {
        isAttached = b;
    }

    public void NoPin (bool e)
    {
        pin = e;
    }
}
