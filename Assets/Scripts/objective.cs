
using UnityEngine;

public class objective : MonoBehaviour
{
    [SerializeField] private string objectiveText = "Thou shall have Glorious quest!";

    private void OnEnable()
    {
        Debug.Log(objectiveText);
    } 
}
