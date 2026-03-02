using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellen_Animation_WwiseEvent : MonoBehaviour
{
    public void PlayRunFootsteps()
    {
        string surface = DetectSurface();
        AkUnitySoundEngine.SetSwitch("FoostepsState", surface, gameObject);

        Debug.Log ("Footsteps Played");
        Play_Footsteps.Post(gameObject);
    }
}
