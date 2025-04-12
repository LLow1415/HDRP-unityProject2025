using UnityEngine;
using UnityEngine.UI;

public class SixthSense : MonoBehaviour
{
    public Image neutral;
    public Sprite enemy;
    public Sprite item;
    public Sprite escapeDoor;
    public Sprite none;
    public Sprite escapeKey;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            neutral.sprite = enemy;
        }
        else if (other.CompareTag("EscapeKey"))
        {
            neutral.sprite = escapeKey;
            
        }
        else if (other.CompareTag("EscapeDoor"))
        {
            neutral.sprite = escapeDoor;
            
        }
        else if (other.CompareTag("Item"))
        {
            neutral.sprite = item;
            
        }

        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy")||other.CompareTag("Item")||other.CompareTag("EscapeDoor")||other.CompareTag("EscapeKey"))
        {
            neutral.sprite = none;
        }
    }
}
