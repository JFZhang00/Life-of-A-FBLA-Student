using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {


    public void PlayGame(){
        Debug.Log("Hello World");
        SceneManager.LoadScene("Neighborhood");

    }

    public void QuitGame(){
        Debug.Log("Quitting Game");
        Application.Quit();

    }

}
