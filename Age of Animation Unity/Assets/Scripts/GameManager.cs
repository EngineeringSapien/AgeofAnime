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


    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            winnerUI.SetActive(true);
        }
    }

}