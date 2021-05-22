using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControlManager : MonoBehaviour
{
    public GameObject BGPanel, HelpPanel;
    public GameObject MiddlePanel;
    public void startGame()
    {
        SceneManager.LoadScene(0);
    }

    public void HelpButton()
    {
        BGPanel.SetActive(true);
        MiddlePanel.SetActive(false);
        HelpPanel.SetActive(true);
    }


    public void BackButton()
    {
        BGPanel.SetActive(true);
        MiddlePanel.SetActive(true);
        HelpPanel.SetActive(false);
    }

   

   

}
