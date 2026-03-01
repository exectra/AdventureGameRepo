using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellen_Animation_WwiseEvent : MonoBehaviour
{
    public AK.Wwise.Event Play_Footsteps;

    public void PlayRunFootsteps()
    {
        string surface = DetectSurface();
        AkUnitySoundEngine.SetSwitch("FoostepsState", surface, gameObject);

        Debug.Log ("Footsteps Played");
        Play_Footsteps.Post(gameObject);
    }
    string DetectSurface()
    {
        RaycastHit hit;

        Vector3 origin = transform.position + Vector3.up * 0.2f;

        Debug.DrawRay(origin, Vector3.down * 3f, Color.red);

        if (Physics.Raycast(origin, Vector3.down, out hit, 3f))
        {
            Debug.Log("Hit: " + hit.collider.name + " | Tag: " + hit.collider.tag);
            return hit.collider.tag;
        }

        return "Grass";
    }

}
