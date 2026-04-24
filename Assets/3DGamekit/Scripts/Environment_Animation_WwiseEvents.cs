using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment_Animation_WwiseEvents : MonoBehaviour
{
    public AK.Wwise.Event Play_DestructibleBox;
    public AK.Wwise.Event Play_DoorOpen;
    public AK.Wwise.Event Play_FloorPlate_Activated;
    public AK.Wwise.Event Play_HealthCrate_Open;
    public AK.Wwise.Event Play_Switch_Activated;
    public AK.Wwise.Event Play_Switch_Idle;
    public AK.Wwise.Event Play_Teleport_Enter;
    public AK.Wwise.Event Play_Teleport_Idle;
    public AK.Wwise.Event Play_WeaponPickUp;

    public void PlayDestructibleBox()
    {
        Play_DestructibleBox.Post(gameObject);
    }
    public void PlayDoorOpen()
    {
        Play_DoorOpen.Post(gameObject);
    }
    public void PlayFloorPlateActivated()
    {
        Play_FloorPlate_Activated.Post(gameObject);
    }
    public void PlayHealthCrateOpen()
    {
        Play_HealthCrate_Open.Post(gameObject);
    }
    public void PlaySwitchActivated()
    {
        Play_Switch_Activated.Post(gameObject);
    }
    public void PlaySwitchIdle()
    {
        Play_Switch_Idle.Post(gameObject);
    }
    public void PlayTeleportEnter()
    {
        Play_Teleport_Enter.Post(gameObject);
    }
    public void PlayTeleportIdle()
    {
        Play_Teleport_Idle.Post(gameObject);
    }
    public void PlayWeaponPickUp()
    {
        Play_WeaponPickUp.Post(gameObject);
    }

}
