using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    void menu()
    {
        Debug.Log("Main Menu");
        SceneManager.LoadScene(0);

    }
}
