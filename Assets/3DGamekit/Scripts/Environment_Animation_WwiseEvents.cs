using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment_Animation_WwiseEvents : MonoBehaviour
{
    public AK.Wwise.Event Play_FloorPlate;
    public AK.Wwise.Event Play_ChestOpen;
    public AK.Wwise.Event Play_ChestAvailable;
    public AK.Wwise.Event Play_DoorOpen;
    public AK.Wwise.Event Play_StoneKey;
    public AK.Wwise.Event Play_CollectedKey;

    public void PlayFloorPlateTrigger()
    {
        Play_FloorPlate.Post(gameObject);
    }

    public void PlayChestOpen()
    {
        Play_ChestOpen.Post(gameObject);
    }
    public void PlayChestDirectional()
    {
        Play_ChestAvailable.Post(gameObject);
    }
    public void PlayDoorOpen()
    {
        Play_DoorOpen.Post(gameObject);
    }
    public void PlayStoneKeyDirectional()
    {
        Play_StoneKey.Post(gameObject);
    }
    public void PlayActivateKey()
    {
        Play_CollectedKey.Post(gameObject);
    }
}
