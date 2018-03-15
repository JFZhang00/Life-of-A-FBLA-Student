using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    private PlayerController player;

    public void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    public void PlayGame(){
        Debug.Log("Hello World");
        SceneManager.LoadScene("Map");
        player.startPoint = "HomeExit";

    }

    public void QuitGame(){
        Debug.Log("Quitting Game");
        Application.Quit();

    }

}
