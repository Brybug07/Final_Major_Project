using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(Constants.Scene1);
    }

    public void Settings()
    {
        SceneManager.LoadScene(Constants.Settings);
    }

    public void Controls()
    {
        SceneManager.LoadScene(Constants.Controls);
    }

    public void Menu()
    {
        SceneManager.LoadScene(Constants.Menu);
    }
}
