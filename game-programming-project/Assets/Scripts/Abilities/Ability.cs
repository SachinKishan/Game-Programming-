using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Base Ability", menuName = "ScriptableObjects/Abilties/Basic Ability", order = 1)]
public class Ability : ScriptableObject
{
	public string abilityName;
	public virtual void Activate()
	{
		Debug.Log(name+ " activated");
	}
}