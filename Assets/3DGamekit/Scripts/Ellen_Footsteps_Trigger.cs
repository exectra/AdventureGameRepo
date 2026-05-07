using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AK.Wwise;

public class Ellen_Footsteps_Trigger : MonoBehaviour
{
    [Header("Wwise State Group")]
    public AK.Wwise.State stateGroup; 

    public enum SurfaceType
    {
        Grass,
        Stone,
        Wet
    }
    
    //Default Surface
    public SurfaceType surface = SurfaceType.Grass;

    private readonly string[] stateNames = { "Grass", "Stone", "Wet" };

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        SetFootstepState();
    }

    private void SetFootstepState()
    {
        string stateName = stateNames[(int)surface];

        // Sets the Wwise State using the state group name and state name
        AkUnitySoundEngine.SetState("FootstepState", stateName);
    }
}
