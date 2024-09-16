using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUIController : MonoBehaviour
{
    public Button mainMenuButton;
    public string scene;

    private void Start()
    {
        if (mainMenuButton != null)
        {
            mainMenuButton.onClick.AddListener(MainMenu);            
        }

    }

    public void MainMenu()
    {
        SceneManager.LoadScene(scene);
    }
}
