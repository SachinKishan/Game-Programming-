using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    public TMP_Text dungeonHeader;
    public static UIManager main;

    private void Awake()
    {
        main = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateDungeonHeader(Scenario sc)
    {
        if (sc == Scenario.Battle)
            dungeonHeader.text = "Battle";
        else if (sc == Scenario.Nothing)
            dungeonHeader.text = "Nothing";
        else if (sc == Scenario.Saferoom)
            dungeonHeader.text = "Saferoom";
        else if (sc == Scenario.Treasure)
            dungeonHeader.text = "Treasure";

    }
}
