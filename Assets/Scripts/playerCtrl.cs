using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCtrl : MonoBehaviour
{

    private float xAxis;
    private float yAxis;

    public float xAxisTurnRate = 360f;
    public float yAxisTurnRate = 360f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        float xAxisInput = Input.GetAxis("Mouse Y");
        float yAxisInput = Input.GetAxis("Mouse X");

        xAxis -= xAxisInput * xAxisTurnRate * Time.deltaTime;
        xAxis = Mathf.Clamp(xAxis, -85f, 85f);
        yAxis += yAxisInput * yAxisTurnRate * Time.deltaTime;

        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0);
        Camera.main.transform.rotation = newRotation;
    }
}
