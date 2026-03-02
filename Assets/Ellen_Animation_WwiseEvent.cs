using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellen_Animation_WwiseEvent : MonoBehaviour
{
    public AK.Wwise.Event Play_Footsteps;
    public AK.Wwise.Event Play_Jump;
    
    public void PlayRunFootsteps()
    {
        Debug.Log ("Footsteps Played");
        Play_Footsteps.Post(gameObject);
    }

    public void PlayJump()
    {
        Debug.Log("Jump Played");
        Play_Jump.Post(gameObject);
    }
}
