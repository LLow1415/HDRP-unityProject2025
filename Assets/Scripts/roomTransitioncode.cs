using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using UnityEngine.SceneManagement;



public class roomTransitioncode : MonoBehaviour
{

    public bool nearFront = false;

    public static int x = 0,y = 0,z = 0;
    
    private GameObject player;
    
    public Vector3 xyz = new Vector3(x,y,z);
    public BoxCollider frontDoor;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag ("Player");
    }

    void Update()
    {
        
            if(Input.GetKeyDown(KeyCode.E) && nearFront){
                Debug.Log("tests");
                player.SetActive(false);
                player.transform.position = player.transform.position + xyz;
                player.SetActive(true);
            }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player")) {
            nearFront = true;
            Debug.Log("near = true");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag ("Player")) {
            nearFront = false;
            Debug.Log("near = false");
        }
    }
    
}
