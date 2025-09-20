using UnityEngine;

public class TrainController : MonoBehaviour
{
    public Animator animator;
    public string forwardClipName = "TrainForward";
    public string reverseClipName = "TrainReverse";

    private float currentTime = 0f; // store playback position

    // Pause train
    public void PauseTrain()
    {
        if (animator != null)
        {
            // Store current time
            AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);
            currentTime = state.normalizedTime % 1f; // normalized 0-1
            animator.speed = 0f;
        }
    }

    // Resume forward
    public void PlayForward()
    {
        if (animator != null)
        {
            animator.Play(forwardClipName, 0, currentTime);
            animator.speed = 1f;
        }
    }

    // Play backward
    public void PlayReverse()
    {
        if (animator != null)
        {
            animator.Play(reverseClipName, 0, currentTime); // currentTime stores paused position
            animator.speed = 1f; // always positive
        }
    }

}
