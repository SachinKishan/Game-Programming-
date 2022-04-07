using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Scenario
{
    Battle,//0
    Treasure,//1
    Nothing,//2
    Saferoom//3
};

public class Dungeon : MonoBehaviour
{
    [SerializeField] Scenario sc;

    private void Start()
    {
        SetScenario();
        PlayerInformationManager.main.AddDungeonNumber();
        Debug.Log(sc);
    }

    void SetScenario()
    {
        sc = (Scenario)Random.Range(0, 4);
        
        UIManager.main.UpdateDungeonHeader(sc);
        if(sc==Scenario.Battle)
        {
            Battle(); 
        }
        else if (sc == Scenario.Nothing)
        {
            Nothing();
        }
        else if (sc == Scenario.Saferoom)
        {
            Saferoom();
        }
        else if (sc == Scenario.Treasure)
        {
            Treasure();
        }
    }

    void Battle()
    {
        //call battle scene
        UIManager.main.SetInformationPanelText("Enemy encounter!");
        
    }

    void Treasure()
    {
        UIManager.main.SetInformationPanelText("You've found treasure!");
        PlayerInformationManager.main.AddMoney(100);
        //collect treasure, gives a stat buff in some form
        //add money? we need to create a function for this
    }

    void Nothing()
    {
        UIManager.main.SetInformationPanelText("You've reached an empty room");
        //produce text saying we are in an empty room
    }

    void Saferoom()
    {
        //recover 25% of max health and mp
        UIManager.main.SetInformationPanelText("You've found a saferoom! Your health has been restored!");
        PlayerInformationManager.main.AddHealth((int)(PlayerInformationManager.main.GetMaxHealth() * 0.25f));
    }

}
