using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dungeon : MonoBehaviour
{
    [SerializeField] int number;
	public GameObject right;
	public GameObject left;
	public GameObject up;
	public GameObject down;	
	bool created=false;	
    
    public void SetNumber(int num)
    {
        number=num;
    }
    public void PlayerIsHere()
    {
	if(!created)
	{
		created=true;
		Generator.main.CreateDungeons(this);
		
    	}
    }
    
    
}
