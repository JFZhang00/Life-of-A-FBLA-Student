﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour
{

    public string levelToLoad;
    public string exitPoint;

    private PlayerController player;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<PlayerController>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Player")
        {
            player.startPoint = exitPoint;
            SceneManager.LoadScene(levelToLoad);



        }
    }
}
