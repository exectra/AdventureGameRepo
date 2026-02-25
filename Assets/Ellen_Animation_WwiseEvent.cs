using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellen_Animation_WwiseEvent : MonoBehaviour
{

    public AK.Wwise.Event Play_Footsteps;

public void PlayRunFootsteps()
{
    Debug.Log ("Footsteps Played");
    Play_Footsteps.Post(gameObject);
}

 
}
