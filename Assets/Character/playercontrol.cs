using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class Playercontrol : MonoBehaviour
{
    public float walkSpeed = 4f;
    public float sprintSpeed = 7.5f;
    public float crouchSpeed = 2.0f;

    public bool sprint = false;
    public bool crouch = false;
    public float currentSpeed;

    public float standHeight = 1f;
    public float crouchHeight = 0.5f;

    private void Start()
    {
        currentSpeed = walkSpeed;
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (!crouch)
            {
                crouch = true;
                currentSpeed = crouchSpeed;
                transform.localScale = new Vector3(transform.localScale.x, crouchHeight, transform.localScale.z);
            }
        }
        else
        {
            if (crouch)
            {
                crouch = false;
                currentSpeed = walkSpeed;
                transform.localScale = new Vector3(transform.localScale.x, standHeight, transform.localScale.z);
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (!sprint)
            {
                sprint = true;
                currentSpeed = sprintSpeed;
            }
        }
        else
        {
            if (sprint)
            {
                sprint = false;
                currentSpeed = walkSpeed;
            }
        }
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.Translate((movement * currentSpeed) * Time.deltaTime);
    }
    
   
}
