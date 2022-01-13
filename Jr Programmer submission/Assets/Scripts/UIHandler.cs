using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class UiHandler
{
    public static void LoadCredits()
    {
        SceneManager.LoadScene("credits", LoadSceneMode.Additive);
    }
    public static void UnloadCredits()
    {
        SceneManager.UnloadSceneAsync("credits", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }
    public static void LoadMenu()
    {
        SceneManager.LoadScene("menu");
    }
    public static void StartGame()
    {
        SceneManager.LoadScene("main");
    }

    public static void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
Application.Quit();
#endif
    }
}
