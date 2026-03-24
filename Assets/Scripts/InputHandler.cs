using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class InputHandler : MonoBehaviour
{

    FirstPersonCamera firstPersonCamera;
    CharacterMovement characterMovement;
    // Start is called before the first frame update
    void Start()
    {
        firstPersonCamera = GetComponent<FirstPersonCamera>();
        characterMovement = GetComponent<CharacterMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        HandleCameraInput();
        HandleMovementInput();
    }

    void HandleCameraInput()
    {
        firstPersonCamera.AddXAxisInput(Input.GetAxis("Mouse Y") * Time.deltaTime);
        firstPersonCamera.AddYAxisInput(Input.GetAxis("Mouse X") * Time.deltaTime);
    }

    void HandleMovementInput()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float rightInput = Input.GetAxis("Horizontal");

        characterMovement.AddMoveInput(forwardInput, rightInput);
    }
}
