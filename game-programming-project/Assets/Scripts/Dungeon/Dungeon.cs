using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CreatedBy
{
	up,down,left,right
};
public class Dungeon : MonoBehaviour
{
    [SerializeField] int number;
	
    public void SetNumber(int num)
    {
        number=num;
    }
   
    
    
}
