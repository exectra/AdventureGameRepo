using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellen_Animation_WwiseEvent : MonoBehaviour
{
    public AK.Wwise.Event Play_Ellen_Attack;
    public AK.Wwise.Event Play_Ellen_Attack_VO;
    public AK.Wwise.Event Play_Ellen_Death;
    public AK.Wwise.Event Play_Ellen_Footsteps;
    public AK.Wwise.Event Play_Ellen_Heal;
    public AK.Wwise.Event Play_Ellen_Hurt;
    public AK.Wwise.Event Play_Ellen_Jump;
    public AK.Wwise.Event Play_Ellen_Land_Roll;
    public AK.Wwise.Event Play_Ellen_ShieldCrack;
    public AK.Wwise.Event Play_Ellen_Spawn;


    public void PlayAttack()
    {
        Play_Ellen_Attack.Post(gameObject);
    }
    public void PlayAttackVO()
    {
        Play_Ellen_Attack_VO.Post(gameObject);
    }
    public void PlayDeath()
    {
        Play_Ellen_Death.Post(gameObject);
    }
    public void PlayFootsteps()
    {
        Play_Ellen_Footsteps.Post(gameObject);
    }
    public void PlayHeal()
    {
        Play_Ellen_Heal.Post(gameObject);
    }
    public void PlayHurt()
    {
        Play_Ellen_Hurt.Post(gameObject);
    }
    public void PlayJump()
    {
        Play_Ellen_Jump.Post(gameObject);
    }
    public void PlayLandRoll()
    {
        Play_Ellen_Land_Roll.Post(gameObject);
    }
    public void PlayShieldCrack()
    {
        Play_Ellen_ShieldCrack.Post(gameObject);
    }
    public void PlaySpawn()
    {
        Play_Ellen_Spawn.Post(gameObject);
    }


}
