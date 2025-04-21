using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class flashlightTutorial : MonoBehaviour
{
  void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            Destroy(gameObject);
        }
    }
}
