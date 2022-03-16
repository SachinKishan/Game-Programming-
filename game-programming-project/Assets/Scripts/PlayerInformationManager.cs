using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInformationManager : MonoBehaviour
{

    [SerializeField] int baseHealth;
    
    int currentHealth;
    [SerializeField] int monies = 0;
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

    public void AddMoney(int m)
    {
        monies += m;
    }

    public void SpendMoney(int m)
    {
        monies -= m;
    }
}

