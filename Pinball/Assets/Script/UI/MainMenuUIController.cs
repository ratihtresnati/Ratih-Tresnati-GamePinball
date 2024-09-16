using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public string sceneGame;

    void Start()
    {
        if (playButton != null & exitButton != null)
        {
            playButton.onClick.AddListener(PlayGame);
            exitButton.onClick.AddListener(ExitGame);
        }
    }

    void PlayGame()
    {
        SceneManager.LoadScene(sceneGame);
    }

    public void LoadScene(string sceneGame)
    {
        SceneManager.LoadScene(sceneGame);
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
