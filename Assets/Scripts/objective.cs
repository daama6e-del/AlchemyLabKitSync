using UnityEngine.Events;
using UnityEngine;

public class objective : MonoBehaviour
{
    [SerializeField] private string objectiveText = "Thou shall have Glorious quest!";
    [SerializeField] private string completedText = "Glory has been awarded to thee Champion!!!";

    public UnityEvent onObjectiveComplete = new UnityEvent();

    private void OnEnable()
    {
        Debug.Log(objectiveText);
    }

    public void CompleteObjective()
    {
        Debug.Log(completedText);

        onObjectiveComplete.Invoke(); // Start of the new Quest, hands tied.

        gameObject.SetActive(false); // Deactivates the quest after achivement.
    }
}
