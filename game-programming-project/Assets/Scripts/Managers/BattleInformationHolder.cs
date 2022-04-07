using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;
public class BattleInformationHolder : MonoBehaviour
{
    public EnemyOnField target;
    public static BattleInformationHolder main;
    public EnemyOnField[] enemies;
    public Player[] players;
    [SerializeField]int ecount = 0;
    [SerializeField]int pcount = 0;
    [SerializeField] GameObject winPanel;
    [SerializeField] GameObject losePanel;
    [SerializeField] GameObject abilityPanel;

    private void Awake()
    {
        main = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        winPanel.SetActive(false);
        losePanel.SetActive(false);
        players = FindObjectsOfType<Player>();
        enemies = FindObjectsOfType<EnemyOnField>();
        ecount = enemies.Length;
        pcount = players.Length;
        NewTarget(FindObjectOfType<EnemyOnField>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewTarget(EnemyOnField t)
    {
        if(target)target.pointer.SetActive(false);
        target = t;
        t.pointer.SetActive(true);
    }
    public void SubtractEnemy()
    {
        ecount--;
        if(ecount==0)
        {
            //player has won battle, move back to dungeon menu
            Debug.Log("Player has won");
            FindObjectOfType<Player>().GetComponent<Player>().enabled = false;
            winPanel.SetActive(true);
            PlayerInformationManager.main.AddBattlesWon();


        }
    }
    public void SubtractPlayer()
    {
        pcount--;
        if(pcount==0)
        {
            losePanel.SetActive(true);
            //player has lost, go to loss screen
           
        }
    }

    public void Win()
    {
        SceneManager.main.Load(1);
    }

    public void Lose()
    {
        SceneManager.main.Load(2);
    }
        
}
