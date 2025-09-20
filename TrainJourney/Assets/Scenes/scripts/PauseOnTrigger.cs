using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PauseOnTrigger : MonoBehaviour
{
    private Animator playerAnimator;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            // Cache the player's animator when they enter
            playerAnimator = other.GetComponent<Animator>();

            if (playerAnimator != null)
            {
                playerAnimator.speed = 0f; // Pause animation
            }
        }
    }

    // Called by Resume Button
    public void ResumeAnimation()
    {
        if (playerAnimator != null)
        {
            playerAnimator.speed = 1f; // Resume animation
        }
    }
}
