using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUiHandler : MonoBehaviour
{
    public void StartGame()
    {
        UiHandler.StartGame();
    }

    public void LoadCredits()
    {
        UiHandler.LoadCredits();
    }

    public void ExitGame()
    {
        UiHandler.QuitGame();
    }
}
