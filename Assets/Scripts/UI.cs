using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Conrtols()
    {
        SceneManager.LoadScene("Controls");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
