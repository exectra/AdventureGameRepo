using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Animation_WwiseEvents : MonoBehaviour
{
    public AK.Wwise.Event Play_UI_Exit;
    public AK.Wwise.Event Play_UI_OnClick;
    public AK.Wwise.Event Play_UI_OnHover;
    public AK.Wwise.Event Play_UI_Open;
    public AK.Wwise.Event Play_UI_StartGame;

    public void PlayExit()
    {
        Play_UI_Exit.Post(gameObject);
    }
    public void PlayOnClick()
    {
        Play_UI_OnClick.Post(gameObject);
    }
    public void PlayOnHover()
    {
        Play_UI_OnHover.Post(gameObject);
    }
    public void PlayOpen()
    {
        Play_UI_Open.Post(gameObject);
    }
    public void PlayStartGame()
    {
        Play_UI_StartGame.Post(gameObject);
    }



}
