using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class spawn : MonoBehaviour {


    public Age ageManager;

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
    }


    public void changeButtons(string player)
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
