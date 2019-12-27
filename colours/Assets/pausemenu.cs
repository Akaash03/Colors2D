using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour {

    public static bool gameispaused = false;

    public GameObject pausemenuUI;
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameispaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
	}
    public void resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameispaused = false;
    }
    void pause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameispaused = true;
    }
    public void loadmenu(){
        SceneManager.LoadScene("startmenu");
    }
    public void quitgame()
    {
        Debug.Log("Quiting game..!");
        Application.Quit();
    }
}
