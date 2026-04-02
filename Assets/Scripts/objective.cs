using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class objective : MonoBehaviour
{

    [SerializeField] private Text objectiveDisplay; // UI Text component to display the objective text
    [SerializeField] private string objectiveText = "Thou shall have Glorious quest!";
    [SerializeField] private string completedText = "Glory has been awarded to thee Champion!!!";

    public UnityEvent onObjectiveComplete = new UnityEvent();

    private void OnEnable()
    {
        objectiveDisplay.text = objectiveText;
        // Debug.Log(objectiveText);
    }

    public void CompleteObjective()
    {

        if (gameObject.activeSelf)
        {

            objectiveDisplay.text = "";
            // Debug.Log(completedText);

            onObjectiveComplete.Invoke(); // Start of the new Quest, hands tied.

            gameObject.SetActive(false); // Deactivates the quest after achivement.

        }

    }
}
