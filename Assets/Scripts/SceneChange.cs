using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void Game()
    {
        SceneManager.LoadScene("Game");
    }

    public void End()
    {
        SceneManager.LoadScene("End");
    }

    public void Begin()
    {
        SceneManager.LoadScene("Start");
    }
}
