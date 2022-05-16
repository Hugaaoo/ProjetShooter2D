using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad;

    public string levelToLoad2;

    public string levelToLoad3;


    public GameObject settingsWindow;

    public void StartLevel1()
    {
        SceneManager.LoadScene(levelToLoad);

    }

    public void StartLevel2()
    {
        SceneManager.LoadScene(levelToLoad2);
    }

    public void StartLevel3()
    {
        SceneManager.LoadScene(levelToLoad3);
    }

    public void Settings()
    {
        settingsWindow.SetActive(true);
    }


    public void CloseSettingsWindow()
    {
        settingsWindow.SetActive(false);
    }





    public void Quit()
    {
        Application.Quit();
    }
}
