using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surface_Detector : MonoBehaviour
{
    private string currentSurface = "";

    private void Update()
    {
        CheckSurface();
    }

    private void CheckSurface()
    {
        // Overlap a small sphere at the player's feet
        Collider[] hits = Physics.OverlapSphere(transform.position, 0.5f);

        foreach (Collider hit in hits)
        {
            Ellen_Footsteps_Trigger trigger = hit.GetComponent<Ellen_Footsteps_Trigger>();
            if (trigger != null)
            {
                string newSurface = trigger.surface.ToString();
                if (newSurface != currentSurface)
                {
                    currentSurface = newSurface;
                    AkUnitySoundEngine.SetState("FootstepState", newSurface);
                }
                return;
            }
        }
    }
}
