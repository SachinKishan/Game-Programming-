using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Scenario
{
    Battle,
    Treasure,
    Nothing,
    Saferoom
};

public class Dungeon : MonoBehaviour
{
    [SerializeField] Scenario sc;

    private void Start()
    {
        SetScenario();
        Debug.Log(sc);
    }

    void SetScenario()
    {
        sc = (Scenario)Random.Range(0, 3);
        
        UIManager.main.UpdateDungeonHeader(sc);

    }

}
