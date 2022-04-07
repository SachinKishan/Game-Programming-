using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBaseClass : MonoBehaviour
{
	[SerializeField]public int health;
    public int currentHealth;
	[SerializeField]public string unitName;
	[SerializeField]public Ability[] abilities;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void RemoveHealth(int h)
    {
        currentHealth -= h;
    }
}
