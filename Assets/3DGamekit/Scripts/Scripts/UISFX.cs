using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISFX : MonoBehaviour
{
    public string StartGame = "Play_UI_StartGame";
    public string Onhover = "Play_UI_OnHover";
    public string Onclick = "Play_UI_OnClick";
    public string Onexit = "Play_UI_Exit";

    public void PlayStart()
    {
        AkUnitySoundEngine.PostEvent(StartGame, gameObject);
    }

    public void PlayHover()
    {
        AkUnitySoundEngine.PostEvent(Onhover, gameObject);
    }
    public void PlayClick()
    {
        AkUnitySoundEngine.PostEvent(Onclick, gameObject);
    }
    public void PlayExit()
    {
        AkUnitySoundEngine.PostEvent(Onexit, gameObject);
    }
}
