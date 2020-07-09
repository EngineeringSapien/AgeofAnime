using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class characterSpawner : MonoBehaviour {

    public bool canSpawn;
    public float spawnTime;

    string myTag;
    int myLayer;

    private Age age;
    public Units units;
    public GameObject SpawnBar;

    public List<string> inGameUnit1Bots = new List<string>();
    public List<string> inGameUnit2Bots = new List<string>();
    public List<string> inGameUnit3Bots = new List<string>();

    public int unit1BotsCount;
    public int unit2BotsCount;
    public int unit3BotsCount;

    private string nameEdit1 = "(Clone)";
    private string nameEdit2 = " (UnityEngine.GameObject)";

    private string unit1SpawnName = "Character1";
    private string unit2SpawnName = "Character2";
    private string unit3SpawnName = "Character3";


    void Start()
    {
        canSpawn = true;
        age = GameObject.Find("AgeManager").GetComponent<Age>();
    }


    private void Update()
    {
        if (gameObject.name == "p2Spawner")
        {
            Debug.Log("Unit1 " + inGameUnit1Bots.Count);
            Debug.Log("unit 2 " + inGameUnit2Bots.Count);
            Debug.Log("Unit   3 " + inGameUnit3Bots.Count);
        }
    }


    public void QueueUnitSpawn(GameObject character, string player, int age)
    {
        AssignTags(player);

        if (canSpawn == true)
        {
            GetSpawntime(character, age);
            StartCoroutine(SpawnUnit(spawnTime, character));
        }
    }


    private void AssignTags(string player)
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
    }


    private void GetSpawntime(GameObject character, int age)
    {
        for (int i = 0; i < units.unit1Characters.Count; i++)
        {
            if (units.unit1Characters.Contains(character.name))
            {
                spawnTime = units.eachUnit1Spawntime[age];
            }
        }

        for (int i = 0; i < units.unit2Characters.Count; i++)
        {
            if (units.unit2Characters.Contains(character.name))
            {
                spawnTime = units.eachUnit2Spawntime[age];
            }
        }

        for (int i = 0; i < units.unit3Characters.Count; i++)
        {
            if (units.unit3Characters.Contains(character.name))
            {
                spawnTime = units.eachUnit3Spawntime[age];
            }
        }
    }


    IEnumerator SpawnUnit(float delay, GameObject charactertobeSpawn)
    {
        canSpawn = false;
        var offset = new Vector3(0, 2f, 0);

        GameObject cloneBar = Instantiate(SpawnBar, transform.position + offset, Quaternion.identity);
        cloneBar.GetComponent<spawnBar>().unitsSpawnTime = spawnTime;

        yield return new WaitForSeconds(delay);

        canSpawn = true;
        charactertobeSpawn.transform.tag = myTag;
        charactertobeSpawn.gameObject.layer = myLayer;

        var clone = Instantiate(charactertobeSpawn, transform.position, Quaternion.identity);

        if (clone.name.Replace(nameEdit1, nameEdit2) == units.P2character1.ToString())
        {
            clone.name = unit1SpawnName;
            inGameUnit1Bots.Add(clone.name);
            UpdateUnitCount();
        }

        if (clone.name.Replace(nameEdit1, nameEdit2) == units.P2character2.ToString())
        {
            clone.name = unit2SpawnName;
            inGameUnit2Bots.Add(clone.name);
            UpdateUnitCount();
        }

        if (clone.name.Replace(nameEdit1, nameEdit2) == units.P2character3.ToString())
        {
            clone.name = unit3SpawnName;
            inGameUnit3Bots.Add(clone.name);
            UpdateUnitCount();
        }
    }


    public void UpdateUnitCount()
    {
        unit1BotsCount = inGameUnit1Bots.Count;
        unit2BotsCount = inGameUnit2Bots.Count;
        unit3BotsCount = inGameUnit3Bots.Count;
    }

}