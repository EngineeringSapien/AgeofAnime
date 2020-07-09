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

    public int inGameUnit1Count;
    public int inGameUnit2Count;
    public int inGameUnit3Count;

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


    public void StartUnitSpawn(GameObject character, string player, int age)
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
            { spawnTime = units.eachUnit1Spawntime[age]; }
        }

        for (int i = 0; i < units.unit2Characters.Count; i++)
        {
            if (units.unit2Characters.Contains(character.name))
            { spawnTime = units.eachUnit2Spawntime[age]; }
        }

        for (int i = 0; i < units.unit3Characters.Count; i++)
        {
            if (units.unit3Characters.Contains(character.name))
            { spawnTime = units.eachUnit3Spawntime[age]; }
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

        UpdateInGameUnitList(clone.name);
    }


    private void UpdateInGameUnitList(string unitName)
    {
        if (unitName.Replace(nameEdit1, nameEdit2) == units.P2character1.ToString())
        {
            unitName = unit1SpawnName;
            inGameUnit1Bots.Add(unitName);
            UpdateUnitCount();
        }

        if (unitName.Replace(nameEdit1, nameEdit2) == units.P2character2.ToString())
        {
            unitName = unit2SpawnName;
            inGameUnit2Bots.Add(unitName);
            UpdateUnitCount();
        }

        if (unitName.Replace(nameEdit1, nameEdit2) == units.P2character3.ToString())
        {
            unitName = unit3SpawnName;
            inGameUnit3Bots.Add(unitName);
            UpdateUnitCount();
        }
    }


    public void UpdateUnitCount()
    {
        inGameUnit1Count = inGameUnit1Bots.Count;
        inGameUnit2Count = inGameUnit2Bots.Count;
        inGameUnit3Count = inGameUnit3Bots.Count;
    }

}