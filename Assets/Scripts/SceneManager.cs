using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    public string scenename;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gottosdcene();
    }

    private void gottosdcene()
    {

        SceneManager.LoadScene(scenename);
    }
}
