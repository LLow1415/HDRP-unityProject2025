using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string playerTag = "Player";

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            Debug.Log("Player caught! Game Over.");

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}