
using UnityEngine;

public class Smol : MonoBehaviour
{

    [SerializeField] private float modifiedScale = 0.2f; //Whole negative numbers break scale use less than 1 itslef
    [SerializeField] private float changeRate = 10f;

    private Transform playerTransform; // Player's type
    private bool isShrinking = false;
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
