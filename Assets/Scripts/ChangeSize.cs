
using UnityEngine;

public class ChangeSize : MonoBehaviour
{

    [SerializeField] private float modifiedScale = 2f;
    [SerializeField] private float changeRate = 5f;

    private Vector3 initialScale;
    private bool isScaled = false;
    // Start is called before the first frame update
    void Start()
    {
        initialScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, GetTargetScale(), changeRate * Time.deltaTime);
    }

    private Vector3 GetTargetScale()
    {
        return isScaled ? Vector3.one * modifiedScale : initialScale; //Vector3.one is short hand for Vector3(1, 1, 1)
        //Is isScaled true? if so do math above || if not use the initial scale of object
    }

    public void ToggleScale()
    {
        isScaled = !isScaled;
    }
}
