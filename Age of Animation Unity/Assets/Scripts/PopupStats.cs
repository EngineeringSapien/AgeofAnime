using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupStats : MonoBehaviour {

    // since these are children of the object this script sits on, we could try using GetComponentinChild
    // However, there are multiple Text Components making it difficult to decipher
    public Text UnitName;
    public Text UnitCost;
    public Text UnitDamage;
    public Text UnitSpawn;
    public Text UnitHealth;

    public Units units;
    public score Score;
    public Age age;

    string thisButtonName;


    private void Start()
    {
        thisButtonName = transform.parent.gameObject.name;
    }


    void Update ()
    {
        if (thisButtonName == "P1Button1") { SetP1Button1Text(); }
        else if (thisButtonName == "P1Button2") { SetP1Button2Text(); }
        else if (thisButtonName == "P1Button3") { SetP1Button3Text(); }
        else if (thisButtonName == "P2Button1") { SetP2Button1Text(); }
        else if (thisButtonName == "P2Button2") { SetP2Button2Text(); }
        else if (thisButtonName == "P2Button3") { SetP2Button3Text(); }
    }


    private void SetP1Button1Text()
    {
        SetCostText(Score.p1Unit1cost);
        SetDamageText(units.eachUnit1Damage[age.P1Age]);
        SetHealthText(units.eachUnit1Health[age.P1Age]);
        SetNameText(units.P1character1.gameObject.name);
        SetSpawnTimeText(units.eachUnit1Spawntime[age.P1Age]);
    }


    private void SetP1Button2Text()
    {
        SetCostText(Score.p1Unit2cost);
        SetDamageText(units.eachUnit2Damage[age.P1Age]);
        SetHealthText(units.eachUnit2Health[age.P1Age]);
        SetNameText(units.P1character2.gameObject.name);
        SetSpawnTimeText(units.eachUnit2Spawntime[age.P1Age]);
    }


    private void SetP1Button3Text()
    {
        SetCostText(Score.p1Unit3cost);
        SetDamageText(units.eachUnit3Damage[age.P1Age]);
        SetHealthText(units.eachUnit3Health[age.P1Age]);
        SetNameText(units.P1character3.gameObject.name);
        SetSpawnTimeText(units.eachUnit3Spawntime[age.P1Age]);
    }


    private void SetP2Button1Text()
    {
        SetCostText(Score.p2Unit1cost);
        SetDamageText(units.eachUnit1Damage[age.P2Age]);
        SetHealthText(units.eachUnit1Health[age.P2Age]);
        SetNameText(units.P2character1.gameObject.name);
        SetSpawnTimeText(units.eachUnit1Spawntime[age.P2Age]);
    }


    private void SetP2Button2Text()
    {
        SetCostText(Score.p2Unit2cost);
        SetDamageText(units.eachUnit2Damage[age.P2Age]);
        SetHealthText(units.eachUnit2Health[age.P2Age]);
        SetNameText(units.P2character2.gameObject.name);
        SetSpawnTimeText(units.eachUnit2Spawntime[age.P2Age]);
    }


    private void SetP2Button3Text()
    {
        SetCostText(Score.p2Unit3cost);
        SetDamageText(units.eachUnit3Damage[age.P2Age]);
        SetHealthText(units.eachUnit3Health[age.P2Age]);
        SetNameText(units.P2character3.gameObject.name);
        SetSpawnTimeText(units.eachUnit3Spawntime[age.P2Age]);
    }


    private void SetCostText(float unitCost)
    {
        UnitCost.text = "Cost: " + unitCost + " gold";
    }


    private void SetDamageText(int unitDamage)
    {
        UnitDamage.text = "Damage: " + unitDamage + " HP";
    }
  

    private void SetHealthText(float unitHealth)
    {
        UnitHealth.text = "Health: " + unitHealth + " HP";
    }


    private void SetNameText(string unitName)
    {
        UnitName.text = "Unit: " + UnitName;
    }


    private void SetSpawnTimeText(float unitSpawnTime)
    {
        UnitSpawn.text = "Spawn Time: " + unitSpawnTime + " s";
    }

}
