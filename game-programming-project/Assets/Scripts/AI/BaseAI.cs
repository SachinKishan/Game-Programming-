using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAI : MonoBehaviour
{

	public GameObject target;
	public float variableOfInterest;
	public Ability action;
    	public virtual void ChooseAbility()
	{
		//Include script to choose ability here
	}
}
