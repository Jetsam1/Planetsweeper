using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

 
    // Update is called once per frame
    void Update()
    {

    }
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ToGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ToPause()
    {
        Time.timeScale = 0;
    }
    public void ToResume()
    {
        Time.timeScale = 1;
    }
    public void ToExit()
    {
        Application.Quit();
    }


}
