using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBaseClass : MonoBehaviour
{
	[SerializeField]int health;
	[SerializeField]string unitName;
	[SerializeField]public Ability[] abilities;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveHealth(int h)
    {
        health -= h;
    }
}
