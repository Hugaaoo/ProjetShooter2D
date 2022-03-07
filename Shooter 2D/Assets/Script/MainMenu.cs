using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad;

    public GameObject settingsWindow;

    public void StartLevel1()
    {
        SceneManager.LoadScene(levelToLoad);

    }

    public void StartLevel2()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void StartLevel3()
    {
        SceneManager.LoadScene(levelToLoad);
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
