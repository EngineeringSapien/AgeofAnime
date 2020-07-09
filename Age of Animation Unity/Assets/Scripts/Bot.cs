using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Bot : MonoBehaviour {

    public characterSpawner p2Spawner;

    public score scoreManager;
    public Age age;

    public buttonClick unit1Button;
    public buttonClick unit2Button;
    public buttonClick unit3Button;
    public buttonClick evolveButton;

    private int currentUnit1Attractiveness;
    private int currentUnit2Attractiveness;
    private int currentUnit3Attractiveness;

    private bool botCanSpawn = true;


    private void Update()
    {
        if ((unit1Button._button.interactable == true || unit2Button._button.interactable == true || unit3Button._button.interactable == true) && botCanSpawn == true)
        { StartCoroutine(Delay(Random.Range(0, 5f))); }

        if (evolveButton._button.interactable == true)
        { evolveButton.BotClick(); }
    }


    IEnumerator Delay(float wait)
    {
        botCanSpawn = false;
        yield return new WaitForSeconds(wait);

        GetUnitAttractiveness();
    }


    private void GetUnitAttractiveness()
    {
        currentUnit1Attractiveness = 100;
        currentUnit2Attractiveness = 110;
        currentUnit3Attractiveness = 150;

        currentUnit1Attractiveness -= (p2Spawner.unit1BotsCount * 10);
        currentUnit2Attractiveness -= (p2Spawner.unit2BotsCount * 10);
        currentUnit3Attractiveness -= (p2Spawner.unit3BotsCount * 10);

        int adjustment1 = Mathf.RoundToInt(scoreManager.P2Gold / scoreManager.p2Unit1cost);
        currentUnit1Attractiveness += adjustment1;

        int adjustment2 = Mathf.RoundToInt(scoreManager.P2Gold / scoreManager.p2Unit2cost);
        currentUnit2Attractiveness += adjustment2;

        int adjustment3 = Mathf.RoundToInt(scoreManager.P2Gold / scoreManager.p2Unit3cost);
        currentUnit3Attractiveness += adjustment3;

        if (unit1Button._button.interactable == false)
        { currentUnit1Attractiveness = 0; }

        if (unit2Button._button.interactable == false)
        { currentUnit2Attractiveness = 0; }

        if (unit3Button._button.interactable == false)
        { currentUnit3Attractiveness = 0; }

        BotSelectUnit();
    }


    void BotSelectUnit()
    {
        int sum = currentUnit1Attractiveness + currentUnit2Attractiveness + currentUnit3Attractiveness;
        int unitSelection = Mathf.RoundToInt(Random.Range(0, sum-1));

        if (unitSelection >= 0 && unitSelection < currentUnit1Attractiveness)
        { unit1Button.BotClick(); }

        else if (unitSelection >= currentUnit1Attractiveness && unitSelection < (currentUnit1Attractiveness + currentUnit2Attractiveness))
        { unit2Button.BotClick(); }

        else if (unitSelection >= (currentUnit1Attractiveness + currentUnit2Attractiveness) && unitSelection < (currentUnit1Attractiveness + currentUnit2Attractiveness + currentUnit3Attractiveness))
        { unit3Button.BotClick(); }

        botCanSpawn = true;
    }

}