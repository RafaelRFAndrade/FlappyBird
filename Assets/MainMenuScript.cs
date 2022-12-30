using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour

{
    public GameObject creditsPanel;

    private void Start()
    {
        creditsPanel.SetActive(false);
    }

   public void Jogar()
    {
        SceneManager.LoadScene("SampleScene");
    }

   public void Credits()
    {
        creditsPanel.SetActive(true);
    }

    public void Back()
    {
        creditsPanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("QuitGame");
    }
}
