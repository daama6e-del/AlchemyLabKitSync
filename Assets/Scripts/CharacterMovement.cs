using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CharacterMovement : MonoBehaviour
{

    CharacterController characterController;

    public float moveSpeed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical"); //Getss input from adress
        float rightInput = Input.GetAxis("Horizontal");

        Vector3 forward = Camera.main.transform.forward; //What component to look for to control and move in what direction that object is facing
        Vector3 right = Camera.main.transform.right;

        forward.y = 0f; //want to move only horizontally, if camera points down it applies force downward- can create
        right.y = 0f;   // bugs thought it may not always force itself through the floor you see?

        forward.Normalize(); //So all vectors are at length- 1 (one)-
        right.Normalize();

        Vector3 moveDirection = (forwardInput * forward) + (rightInput * right);
        moveDirection.Normalize();
        moveDirection.y = -1f; //Contstantly moves downward so we dont float upward

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
}
