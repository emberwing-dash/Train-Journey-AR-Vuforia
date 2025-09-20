using UnityEngine;

public class TrainTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Look for a TrainController in the parent hierarchy
        TrainController controller = other.GetComponentInParent<TrainController>();
        if (controller != null)
        {
            controller.PauseTrain(); // Pause the train animation
        }
    }
}
