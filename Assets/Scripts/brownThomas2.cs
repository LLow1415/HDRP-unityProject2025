using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class brownThomas2 : MonoBehaviour
{
    public BoxCollider Collider;
    public bool isImgOn;
    public AudioSource die;
    public Image img;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player")) {
            //Destroy(gameObject);
            img.enabled = true;
            isImgOn = true;
        }
    }
    private void Update()
    {
    if (isImgOn)
        {
            if(Input.anyKeyDown)
            {
            img.enabled = false;
            die.Play();
            SceneManager.LoadScene(2);
            }
        }
    }
}
