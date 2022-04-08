using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LossManager : MonoBehaviour
{
    [SerializeField] TMP_Text money;
    [SerializeField] TMP_Text battlesWon;
    [SerializeField] TMP_Text deepScore;
    // Start is called before the first frame update
    void Start()
    {
        money.text = "Money left: " + PlayerInformationManager.main.GetMoney();
        battlesWon.text = "Battles won: " + PlayerInformationManager.main.GetBattlesWon();
        deepScore.text = "Number of rooms travelled: " + PlayerInformationManager.main.GetDungeonNumber();
    }

    public void GoBackToStart()
    {
        SceneManager.main.Load(0);
    }
    
}
