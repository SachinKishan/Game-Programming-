using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInformationManager : MonoBehaviour
{

    [SerializeField] int baseHealth;
    
    int currentHealth;
    [SerializeField] int monies = 0;
    [SerializeField] int battlesWon=0;
    [SerializeField] int dNumber = 0;
    public static PlayerInformationManager main;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
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

    public void UpdatePlayerHealth(int health)
    {
        currentHealth = health;
    }

    public void AddHealth(int addition)
    {
        currentHealth += addition;
    }

    public void RemoveHealth(int reduction)
    {
        currentHealth -= reduction;
    }

    public void AddBattlesWon()
    {
        battlesWon++;
    }

    public int GetCurrentHealth() { return currentHealth; }
    public int GetMaxHealth() { return baseHealth; }
    public int GetMoney() => monies;
    public int GetBattlesWon() => battlesWon;
    public int GetDungeonNumber() => battlesWon;
    public void AddDungeonNumber() { dNumber++; }
    public void AddMoney(int m)
    {
        monies += m;
    }

    public void SpendMoney(int m)
    {
        monies -= m;
    }
}

