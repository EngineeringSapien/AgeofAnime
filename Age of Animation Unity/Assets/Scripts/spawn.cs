using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class spawn : MonoBehaviour {

    public characterSpawner spawner1;
    public characterSpawner spawner2;

    public Age ageManager;
    public score Score;
    public Units units;
    public Sound music;

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
    public Button p1button4;
    public Button p1buttonEvolve;

    public Button p2button1;
    public Button p2button2;
    public Button p2button3;
    public Button p2button4;
    public Button p2buttonEvolve;

    public Sprite KakashiImage;
    public Sprite Itachimage;
    public Sprite ZabuzaImage;
    public Sprite fourthImage;
    public Sprite PainImage;
    public Sprite NarutoImage;
    public Sprite MustangImage;
    public Sprite EricImage;
    public Sprite FuhrerImage;
    public Sprite VegetaImage;
    public Sprite GokuImage;
    public Sprite FriezaImage;
    public Sprite IchigoImage;
    public Sprite ByakuyaImage;
    public Sprite RukiaImage;

    private List<Sprite> button1SpriteList = new List<Sprite>();
    private List<Sprite> button2SpriteList = new List<Sprite>();
    private List<Sprite> button3SpriteList = new List<Sprite>();



    private void Awake()
    {
        button1SpriteList.AddRange(new Sprite[] { KakashiImage, fourthImage, VegetaImage, RukiaImage, EricImage });
        button2SpriteList.AddRange(new Sprite[] { Itachimage, PainImage, GokuImage, IchigoImage, MustangImage });
        button3SpriteList.AddRange(new Sprite[] { ZabuzaImage, NarutoImage, FriezaImage, ByakuyaImage, FuhrerImage });

        p2buttonEvolve.interactable = false;
    }


    private void Update()
    {

        #region Player 1 Gold Button

        if (spawner1.canSpawn == true)
        {
            if (Score.P1Gold < Score.p1Unit1cost)
            {
                p1button1.interactable = false;
            }
            else if (Score.P1Gold >= Score.p1Unit1cost) { p1button1.interactable = true; }

            if (Score.P1Gold < Score.p1Unit2cost)
            {
                p1button2.interactable = false;
            }
            else if (Score.P1Gold >= Score.p1Unit2cost) { p1button2.interactable = true; }

            if (Score.P1Gold < Score.p1Unit3cost)
            {
                p1button3.interactable = false;
            }
            else if (Score.P1Gold >= Score.p1Unit3cost) { p1button3.interactable = true; }

        }
        else if (spawner1.canSpawn == false) { p1button1.interactable = p1button2.interactable =
             p1button3.interactable = p1button4.interactable = false; }
        #endregion


        #region Player 2 Gold Button
        if (spawner2.canSpawn == true)
        {
            if (Score.P2Gold < Score.p2Unit1cost)
            {
                p2button1.interactable = false;
            } else if (Score.P2Gold >= Score.p2Unit1cost) { p2button1.interactable = true; }

            if (Score.P2Gold < Score.p2Unit2cost)
            {
                p2button2.interactable = false;
            } else if (Score.P2Gold >= Score.p2Unit2cost) { p2button2.interactable = true; }

            if (Score.P2Gold < Score.p2Unit3cost)
            {
                p2button3.interactable = false;
            } else if (Score.P2Gold >= Score.p2Unit3cost) { p2button3.interactable = true; }
        }
        else if (spawner2.canSpawn == false) { p2button1.interactable = p2button2.interactable =
             p2button3.interactable = p2button4.interactable = false; }

        #endregion


        #region Player 1 Experience Button

        if (Score.P1Exp < Score.P1EvolveReq)
        {
            p1buttonEvolve.interactable = false;
        } else if (Score.P1Exp >= Score.P1EvolveReq) { p1buttonEvolve.interactable = true; }
        #endregion

        
        #region Player 2 Experience Button

        if (Score.P2Exp < Score.P2EvolveReq)
        {
            p2buttonEvolve.interactable = false;
        } else if (Score.P2Exp >= Score.P2EvolveReq) { p2buttonEvolve.interactable = true; }
        #endregion

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
        spawner1.QueueUnitSpawn(units.P1character1, "P1", ageManager.P1Age);
        Score.ChangeTreasury("decrease", "Character1", "Player1");
    }


    private void TriggerP1Button2()
    {
        spawner1.QueueUnitSpawn(units.P1character2, "P1", ageManager.P1Age);
        Score.ChangeTreasury("decrease", "Character2", "Player1");
    }


    private void TriggerP1Button3()
    {
        spawner1.QueueUnitSpawn(units.P1character3, "P1", ageManager.P1Age);
        Score.ChangeTreasury("decrease", "Character3", "Player1");
    }


    private void TriggerP2Button1()
    {
        spawner2.QueueUnitSpawn(units.P2character1, "P2", ageManager.P2Age);
        Score.ChangeTreasury("decrease", "Character1", "Player2");
    }


    private void TriggerP2Button2()
    {
        spawner2.QueueUnitSpawn(units.P2character2, "P2", ageManager.P2Age);
        Score.ChangeTreasury("decrease", "Character2", "Player2");
    }


    private void TriggerP2Button3()
    {
        spawner2.QueueUnitSpawn(units.P2character3, "P2", ageManager.P2Age);
        Score.ChangeTreasury("decrease", "Character3", "Player2");
    }


    private void TriggerP1Evolve()
    {
        music.ChangeMusic(ageManager.P1Age + 1);
        ageManager.ChangeAge("P1");
        changeButtons("P1");
    }


    private void TriggerP2Evolve()
    {
        music.ChangeMusic(ageManager.P2Age + 1);
        ageManager.ChangeAge("P2");
        changeButtons("P2");
    }
















          


    void changeButtons(string player)
    {
        if (player == "P1")
        {
            GameObject.Find("P1Button1").GetComponent<Button>().image.overrideSprite = button1SpriteList[ageManager.P1Age];
            GameObject.Find("P1Button2").GetComponent<Button>().image.overrideSprite = button2SpriteList[ageManager.P1Age];
            GameObject.Find("P1Button3").GetComponent<Button>().image.overrideSprite = button3SpriteList[ageManager.P1Age];
        }

        if (player == "P2")
        {
            GameObject.Find("P2Button1").GetComponent<Button>().image.overrideSprite = button1SpriteList[ageManager.P2Age];
            GameObject.Find("P2Button2").GetComponent<Button>().image.overrideSprite = button2SpriteList[ageManager.P2Age];
            GameObject.Find("P2Button3").GetComponent<Button>().image.overrideSprite = button3SpriteList[ageManager.P2Age];
        } 

    }

}
