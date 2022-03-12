using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDungeonTravel : MonoBehaviour
{
	[SerializeField]GameObject startDungeon;
	Dungeon d;
    // Start is called before the first frame update
    void Start()
    {
	d=startDungeon.GetComponent<Dungeon>();        
	d.PlayerIsHere();
    }

    // Update is called once per frame
    void Update()
    {
	PlayerInput();        
    }

	void PlayerInput()
	{
		if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			d=d.down.GetComponent<Dungeon>();        ;		
			
		}
		else if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			d=d.up.GetComponent<Dungeon>();        ;
		}
		else if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			d=d.right.GetComponent<Dungeon>();        ;
		}
		else if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			d=d.left.GetComponent<Dungeon>();        ;
		}
		d.PlayerIsHere();
		
	}
}
