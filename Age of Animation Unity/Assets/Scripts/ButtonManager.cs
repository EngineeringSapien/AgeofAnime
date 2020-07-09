using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ButtonManager : MonoBehaviour {


    public characterSpawner spawner1;
    public characterSpawner spawner2;

    public Age ageManager;
    public score Score;
    public Units units;
    public Sound music;
    public ButtonSpriteManager buttonSpriteManager;
       
    public buttonClick P1key1;
    public buttonClick P1key2;
    public buttonClick P1key3;
    public buttonClick P1keyEvolve;
    public buttonClick P2key1;
    public buttonClick P2key2;
    public buttonClick P2key3;
    public buttonClick P2keyEvolve;

    public Button p1button1;
    public Button p1button2;
    public Button p1button3;
    public Button p1buttonEvolve;

    public Button p2button1;
    public Button p2button2;
    public Button p2button3;
    public Button p2buttonEvolve;


    private void Start()
    {
        p2buttonEvolve.interactable = false;
    }


    private void Update()
    {
        CheckP1XP();

        CheckP2XP();

        if (spawner1.canSpawn == true) { CheckP1Gold(); }

        else { p1button1.interactable = p1button2.interactable = p1button3.interactable = false; }

        if (spawner2.canSpawn == true) { CheckP2Gold(); }

        else { p2button1.interactable = p2button2.interactable = p2button3.interactable = false; }
    }


    private void CheckP1Gold()
    {
        CompareGoldtoUnitCost(Score.P1Gold, Score.p1Unit1cost, p1button1);
        CompareGoldtoUnitCost(Score.P1Gold, Score.p1Unit2cost, p1button2);
        CompareGoldtoUnitCost(Score.P1Gold, Score.p1Unit3cost, p1button3);
    }


    private void CheckP2Gold()
    {
        CompareGoldtoUnitCost(Score.P2Gold, Score.p2Unit1cost, p2button1);
        CompareGoldtoUnitCost(Score.P2Gold, Score.p2Unit2cost, p2button2);
        CompareGoldtoUnitCost(Score.P2Gold, Score.p2Unit3cost, p2button3);
    }


    private void CompareGoldtoUnitCost(float playersGold, float unitCost, Button button)
    {
        if (playersGold < unitCost) { button.interactable = false; }

        else if (playersGold >= unitCost) { button.interactable = true; }
    }


    private void CheckP1XP()
    {
        if (Score.P1Exp < Score.P1EvolveXPCost) { p1buttonEvolve.interactable = false; }

        else { p1buttonEvolve.interactable = true; }
    }


    private void CheckP2XP()
    {
        if (Score.P2Exp < Score.P2EvolveXPCost) { p2buttonEvolve.interactable = false; }

        else { p2buttonEvolve.interactable = true; }
    }


    public void CheckButtonName()
    {

        if (P1key1.key_pressed == true) { TriggerP1Button1(); }

        if (P1key2.key_pressed == true) { TriggerP1Button2(); }

        if (P1key3.key_pressed == true) { TriggerP1Button3(); }

        if (P2key1.key_pressed == true) { TriggerP2Button1(); }

        if (P2key2.key_pressed == true) { TriggerP2Button2(); }

        if (P2key3.key_pressed == true) { TriggerP2Button3(); }

        if (P1keyEvolve.key_pressed == true) { TriggerP1Evolve(); }

        if (P2keyEvolve.key_pressed == true) { TriggerP2Evolve(); }
    }


    private void TriggerP1Button1()
    {
        spawner1.StartUnitSpawn(units.P1character1, "P1", ageManager.P1Age);
        Score.ChangeTreasury("decrease", "Character1", "Player1");
    }


    private void TriggerP1Button2()
    {
        spawner1.StartUnitSpawn(units.P1character2, "P1", ageManager.P1Age);
        Score.ChangeTreasury("decrease", "Character2", "Player1");
    }


    private void TriggerP1Button3()
    {
        spawner1.StartUnitSpawn(units.P1character3, "P1", ageManager.P1Age);
        Score.ChangeTreasury("decrease", "Character3", "Player1");
    }


    private void TriggerP2Button1()
    {
        spawner2.StartUnitSpawn(units.P2character1, "P2", ageManager.P2Age);
        Score.ChangeTreasury("decrease", "Character1", "Player2");
    }


    private void TriggerP2Button2()
    {
        spawner2.StartUnitSpawn(units.P2character2, "P2", ageManager.P2Age);
        Score.ChangeTreasury("decrease", "Character2", "Player2");
    }


    private void TriggerP2Button3()
    {
        spawner2.StartUnitSpawn(units.P2character3, "P2", ageManager.P2Age);
        Score.ChangeTreasury("decrease", "Character3", "Player2");
    }


    private void TriggerP1Evolve()
    {
        music.ChangeMusic(ageManager.P1Age + 1);
        ageManager.ChangeAge("P1");
        buttonSpriteManager.changeButtons("P1");
    }


    private void TriggerP2Evolve()
    {
        music.ChangeMusic(ageManager.P2Age + 1);
        ageManager.ChangeAge("P2");
        buttonSpriteManager.changeButtons("P2");
    }

}
