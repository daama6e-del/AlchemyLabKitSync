using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{

    public float xAxis;
    public float yAxis;

    private float xAxisTurnRate = 200f;
    private float yAxisTurnRate = 200f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Hides coursor
    }

    // Update is called once per frame
    void Update()
    {
        float xAxisInspute = Input.GetAxis("Mouse Y"); //gets the input adress from
        float yAxisInspute = Input.GetAxis("Mouse X");

        xAxis -= xAxisInspute * xAxisTurnRate * Time.deltaTime; //makes it move in time line
        xAxis = Mathf.Clamp(xAxis, -80f, 80f); //Clamp retraint
        yAxis += yAxisInspute * yAxisTurnRate * Time.deltaTime;


        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0f);

        Camera.main.transform.rotation = newRotation;
    }

    void LateUpdate() //Called every frame after Update method finishes
    {
        
    }
}
