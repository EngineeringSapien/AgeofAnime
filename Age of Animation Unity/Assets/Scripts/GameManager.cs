using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public baseHealth baseHealth1;
    public baseHealth baseHealth2;

    public GameObject winnerUI;

    int PlayerOne = 1;
    int PlayerTwo = 2;

    bool gameHasEnded = false;

    GameObject Char1;
    GameObject Char2;
    GameObject Char3;
    GameObject Char4;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update ()
    {
        if (baseHealth1.currentHealth <= 0)
        {
            var winner = PlayerTwo;
            GameOver();

        }
        else if (baseHealth2.currentHealth <= 0)
        {
            var winner = PlayerOne;
            GameOver();
        }

    }

    void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            winnerUI.SetActive(true);

        }
    }






}
