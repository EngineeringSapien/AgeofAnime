using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject winnerUI;
    public Text winnerText;

    private bool gameHasEnded = false;


    public void GameOver(string losingPlayer)
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            
            if (losingPlayer == "1") { winnerText.text = "PLAYER 2"; }

            else { winnerText.text = "PLAYER 1"; }

            winnerUI.SetActive(true);
        }
    }

}