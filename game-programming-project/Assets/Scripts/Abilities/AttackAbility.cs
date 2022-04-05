using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Attack Ability", menuName = "ScriptableObjects/Abilities/Attack Ability", order = 1)]

public class AttackAbility : Ability
{
    [SerializeField] int attack;
    public override void Activate(UnitBaseClass obj)
    {
        base.Activate();
        obj.RemoveHealth(attack);
    }
}
