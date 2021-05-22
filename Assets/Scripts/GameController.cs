using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void GoToNextScene()
    {
        SceneManager.LoadScene(0);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(2);
    }
}