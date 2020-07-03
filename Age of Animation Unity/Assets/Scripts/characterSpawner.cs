using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class characterSpawner : MonoBehaviour {

    public bool canSpawn;
    public float spawnTime;

    string myTag;
    int myLayer;

    public Units units;
    public GameObject SpawnBar;
    Age age;

    public List<string> inGameUnit1Bots = new List<string>();
    public List<string> inGameUnit2Bots = new List<string>();
    public List<string> inGameUnit3Bots = new List<string>();

    public int unit1BotsCount;
    public int unit2BotsCount;
    public int unit3BotsCount;

    string nameEdit1 = "(Clone)";
    string nameEdit2 = " (UnityEngine.GameObject)";

    string Character1 = "Character1";
    string Character2 = "Character2";
    string Character3 = "Character3";



    void Start()
    {
        canSpawn = true;
        age = GameObject.Find("AgeManager").GetComponent<Age>();
    }


    private void Update()
    {
        if (this.gameObject.tag == "P2Base")
        {
            unit1BotsCount = inGameUnit1Bots.Count;
            unit2BotsCount = inGameUnit2Bots.Count;
            unit3BotsCount = inGameUnit3Bots.Count;
        }
    }


    //Function that spawns characters and defines delays
    public void spawnCharacter(GameObject character, string player, int age)
    {
        if (player == "P1")
        {
            myTag = "Player1";
            myLayer = 12;
        }
        if (player == "P2")
        {
            myTag = "Player2";
            myLayer = 13;
        }


        if (canSpawn == true)
        {
            // Check which list the unit being spawned comes from (unit1, unit2, or unit3)
            // Then matches the spawn time from the corresponding unit spawn time list by using the current age of player (unit 1 age 1 = kakashi)
            for (int i = 0; i < units.unit1List.Count; i++)
            {
                if (units.unit1List.Contains(character.name))
                {
                    spawnTime = units.unit1SpawntimeList[age];
                }
            }

            for (int i = 0; i < units.unit2List.Count; i++)
            {
                if (units.unit2List.Contains(character.name))
                {
                    spawnTime = units.unit2SpawntimeList[age];
                }
            }

            for (int i = 0; i < units.unit3List.Count; i++)
            {
                if (units.unit3List.Contains(character.name))
                {
                    spawnTime = units.unit3SpawntimeList[age];
                }
            }

            StartCoroutine(SpawnDelay(spawnTime, character));
        }
    }


    IEnumerator SpawnDelay(float delay, GameObject charactertobeSpawn)
    {
        canSpawn = false;
        var offset = new Vector3(0, 2f, 0);

        GameObject cloneBar = Instantiate(SpawnBar, transform.position + offset, Quaternion.identity);
        cloneBar.GetComponent<spawnBar>().spawnTime = spawnTime;

        yield return new WaitForSeconds(delay);

        canSpawn = true;
        charactertobeSpawn.transform.tag = myTag;
        charactertobeSpawn.gameObject.layer = myLayer;

        var clone = Instantiate(charactertobeSpawn, transform.position, Quaternion.identity);
        if (clone.name.Replace(nameEdit1, nameEdit2) == units.P2character1.ToString())
        { clone.name = Character1; inGameUnit1Bots.Add(clone.name); }

        if (clone.name.Replace(nameEdit1, nameEdit2) == units.P2character2.ToString())
        { clone.name = Character2; inGameUnit2Bots.Add(clone.name); }

        if (clone.name.Replace(nameEdit1, nameEdit2) == units.P2character3.ToString())
        { clone.name = Character3; inGameUnit3Bots.Add(clone.name); }
       
    }


}
