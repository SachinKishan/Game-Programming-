using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public TMP_Text dungeonHeader;
    public static UIManager main;
    public GameObject informationPanel;
    public TMP_Text informationText;
    public GameObject battleButton;
    private void Awake()
    {
        main = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        battleButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleInformationPanel(bool active)
    {
        informationPanel.SetActive(active);
    }
    public void SetInformationPanelText(string text)
    {
        if (text.CompareTo("Enemy encounter!") == 0) battleButton.SetActive(true);
        informationText.text = text;
        ToggleInformationPanel(true);
        
    }
    public void Battle()
    {
        SceneManager.main.Load(3);
        battleButton.SetActive(false);
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
