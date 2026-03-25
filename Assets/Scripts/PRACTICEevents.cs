 
using UnityEngine;
using UnityEngine.Events;

public class PRACTICEevents : MonoBehaviour
{
    public UnityEvent testEvent = new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {
        testEvent.AddListener(TestListener);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            testEvent.Invoke();
        }
    }

    void TestListener()
    {
        print("Test listener called");
    }
}
