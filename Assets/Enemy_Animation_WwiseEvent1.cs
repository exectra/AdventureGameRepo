using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Animation_WwiseEvent : MonoBehaviour
{
    public AK.Wwise.Event Play_Pink_Bite;
    public AK.Wwise.Event Play_Pink_Death;
    public AK.Wwise.Event Play_Pink_Growl;
    public AK.Wwise.Event Play_Pink_Footsteps;

    public void PlayPinkBite()
    {
        Play_Pink_Bite.Post(gameObject);
    }
    public void PlayPinkDeath()
    {
        Play_Pink_Death.Post(gameObject);
    }
    public void PlayPinkGrowl()
    {
        Play_Pink_Growl.Post(gameObject);
    }
    public void PlayPinkFootsteps()
    {
        Play_Pink_Footsteps.Post(gameObject);
    }


}
