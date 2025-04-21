using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int SceneIndex;
    public BoxCollider Collider;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player")) {
            SceneManager.LoadScene(SceneIndex);
        }
    }
    
}
