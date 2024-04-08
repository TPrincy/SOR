using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DialogueEditor;

public class SceneSwitcher : MonoBehaviour
{
    public void goToGameplayScene()
    {
        SceneManager.LoadScene("Gameplay");
    }
    
    public void goToStartScene()
    {
        SceneManager.LoadScene("Start");
    }

    public void goToMainMenu()
    {
        SceneManager.LoadScene("Main");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
