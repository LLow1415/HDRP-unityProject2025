using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlightLight;

    public AudioSource turnOn;
    public AudioSource turnOff;

    public bool power;
    
    void Start()
    {
        power = false;
        flashlightLight.SetActive(false);
    }




    private void Update()
    {
        if((power == false) && (Input.GetKeyDown(KeyCode.F)))
        {
            flashlightLight.SetActive(true);
            turnOn.Play();
            power = true;
        }  
        else if (power && Input.GetKeyDown(KeyCode.F))
        {
            flashlightLight.SetActive(false);
            turnOff.Play();
            power = false;
        }



    }
}
