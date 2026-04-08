using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellen_Animation_WwiseEvent : MonoBehaviour
{
    public AK.Wwise.Event Play_Footsteps;
    public AK.Wwise.Event Play_Jump;
    public AK.Wwise.Event Play_Land;
    public AK.Wwise.Event Play_Death;
    public AK.Wwise.Event Play_Spawn;
    public AK.Wwise.Event Play_Atk_1;
    public AK.Wwise.Event Play_Atk_2;
    public AK.Wwise.Event Play_Atk_3;
    public AK.Wwise.Event Play_Atk_4;

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

    public void PlayLand()
    {
        Play_Land.Post(gameObject);
    }

    public void PlayDeath()
    {
        Play_Death.Post(gameObject);
    }

    public void PlaySpawn()
    {
        Play_Spawn.Post(gameObject);
    }
    public void PlayAtk1()
    {
        Play_Atk_1.Post(gameObject);
    }
    public void PlayAtk2()
    {
        Play_Atk_2.Post(gameObject);
    }
    public void PlayAtk3()
    {
        Play_Atk_3.Post(gameObject);
    }
    public void PlayAtk4()
    {
        Play_Atk_4.Post(gameObject);
    }
}
