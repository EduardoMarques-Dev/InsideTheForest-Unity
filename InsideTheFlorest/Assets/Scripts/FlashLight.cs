using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    //public GameObject lightObject;
    private Light myLightComponent;


    void Start()
    {
         //lightObject = GameObject.Find("<Insert Objects Name>");
         myLightComponent = this.GetComponent<Light>();
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            myLightComponent.enabled = !myLightComponent.enabled;
        }
    }
}
