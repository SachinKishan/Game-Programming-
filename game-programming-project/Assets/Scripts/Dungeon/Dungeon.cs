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
	public bool created=false;	
    
    public void SetNumber(int num)
    {
        number=num;
    }
    public void PlayerIsHere()
    {
	if(created==false)
	{
		created=true;
		Generator.main.CreateDungeons(this);
		if(right!=null)right.GetComponent<Dungeon>().left=this.gameObject;
		if(down!=null)down.GetComponent<Dungeon>().up=this.gameObject;
		if(left!=null)left.GetComponent<Dungeon>().right=this.gameObject;
		if(up!=null)up.GetComponent<Dungeon>().down=this.gameObject;
		
    	}
    }
    
    
}
