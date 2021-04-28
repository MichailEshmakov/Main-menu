using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private int GameSceneIndex;
    [SerializeField] private int CreditsSceneIndex;

    private void OnValidate()
    {
        GameSceneIndex = Mathf.Clamp(GameSceneIndex, 0, int.MaxValue);
        CreditsSceneIndex = Mathf.Clamp(CreditsSceneIndex, 0, int.MaxValue);
    }

    public void Exit() 
    {
        Application.Quit();
    }

    public void GoToGame()
    {
        SceneManager.LoadScene(GameSceneIndex);
    }

    public void GoToCredits()
    {
        SceneManager.LoadScene(CreditsSceneIndex);
    }
}
