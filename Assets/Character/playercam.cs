using UnityEngine;

public class playercam : MonoBehaviour
{
    public float sensX, sensY;
    public Transform orientation;
    float xRotation;
    float yRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * 70;

        yRotation = yRotation + mouseX;
        //xRotation = 0;
        xRotation = xRotation - mouseY;
        xRotation = Mathf.Clamp(xRotation, -25, 40);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
