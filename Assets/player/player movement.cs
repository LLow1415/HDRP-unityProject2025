using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float turnspeed;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * 10);
        transform.Rotate(Vector3.up * horizontalInput * turnspeed * Time.deltaTime * 10);

    }
}