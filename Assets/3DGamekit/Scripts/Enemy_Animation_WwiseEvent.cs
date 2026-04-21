using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Animation_WwiseEvent : MonoBehaviour
{
    public AK.Wwise.Event Play_Ellen_Attack_Hit;
    public void PlayAttackHit()
    {
        Play_Ellen_Attack_Hit.Post(gameObject);
    } 

    //CHOMPER
    public AK.Wwise.Event Play_Chomper_Attack;
    public AK.Wwise.Event Play_Chomper_Death;
    public AK.Wwise.Event Play_Chomper_Footsteps;
    public AK.Wwise.Event Play_Chomper_Growl;
    public AK.Wwise.Event Play_Chomper_Hurt;
    
    public void PlayChomperAttack()
    {
        Play_Chomper_Attack.Post(gameObject);
    }
    public void PlayChomperDeath()
    {
        Play_Chomper_Death.Post(gameObject);
    }
    public void PlayChomperFootsteps()
    {
        Play_Chomper_Footsteps.Post(gameObject);
    }
    public void PlayChomperGrowl()
    {
        Play_Chomper_Growl.Post(gameObject);
    }
    public void PlayChomperHurt()
    {
        Play_Chomper_Hurt.Post(gameObject);
    }

    //GRENADIER
    public AK.Wwise.Event Play_Grenadier_Range_2_Throw;
    public AK.Wwise.Event Play_Grenadier_Death;
    public AK.Wwise.Event Play_Grenadier_Footsteps;
    public AK.Wwise.Event Play_Grenadier_Hurt;
    public AK.Wwise.Event Play_Grenadier_Melee;
    public AK.Wwise.Event Play_Grenadier_Range_1;
    public AK.Wwise.Event Play_Grenadier_Range_2_Ammo;

    public void PlayGrenadierRange2Throw()
    {
        Play_Grenadier_Range_2_Throw.Post(gameObject);
    }
    public void PlayGrenadierDeath()
    {
        Play_Grenadier_Death.Post(gameObject);
    }
    public void PlayGrenadierFootsteps()
    {
        Play_Grenadier_Footsteps.Post(gameObject);
    }
    public void PlayGrenadierHurt()
    {
        Play_Grenadier_Hurt.Post(gameObject);
    }
    public void PlayGrenadierMelee()
    {
        Play_Grenadier_Melee.Post(gameObject);
    }
    public void PlayGrenadierRange1()
    {
        Play_Grenadier_Range_1.Post(gameObject);
    }
    public void PlayGrenadierRange2Ammo()
    {
        Play_Grenadier_Range_2_Ammo.Post(gameObject);
    }
    
    //SPITTER
    public AK.Wwise.Event Play_Spitter_Attack;
    public AK.Wwise.Event Play_Spitter_Attack_Splat;
    public void PlaySpitterAttack()
    {
        Play_Spitter_Attack.Post(gameObject);
    }
    public void PlaySpitterAttackSplat()
    {
        Play_Spitter_Attack_Splat.Post(gameObject);
    }

}
