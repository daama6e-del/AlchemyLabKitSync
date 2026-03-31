
using UnityEngine;

public class Smol : MonoBehaviour
{

    [SerializeField] private float modifiedScale = -2f;
    [SerializeField] private float changeRate = 10f;

    private Transform playerTransform; // Player's type
    private bool isShrinking = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (isShrinking && playerTransform != null)
        {
            playerTransform.localScale = Vector3.MoveTowards(playerTransform.localScale, GetTargetScale(), changeRate * Time.deltaTime);
        }

        if (playerTransform != null && playerTransform.localScale == GetTargetScale())
        {
            isShrinking = false; // Stops Shrinking when reached
        }
    }

    private Vector3 GetTargetScale()
    {
        return Vector3.one * modifiedScale; //Vector3.one is short hand for Vector3(1, 1, 1)
        //Is isScaled true? if so do math above || if not use the initial scale of object
    }

    public void Smallering(GameObject player)
    {
        if (player.CompareTag("Player"))
        {
            playerTransform = player.transform; // Gets the player's transform
            isShrinking = true; // Starts Shrinking
        }
    }
}
