using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum AbilityType
{
	skill, magic
}
[CreateAssetMenu(fileName = "Base Ability", menuName = "ScriptableObjects/Abilties/Basic Ability", order = 1)]

public class Ability : ScriptableObject
{
	public string abilityName;
	public float cooldownTime;
    public float activeTime;
	public AbilityType type;

	public virtual void Activate()
	{
		Debug.Log(name+ " activated");
	}
	public virtual void Activate(UnitBaseClass a)
    {

    }
}
